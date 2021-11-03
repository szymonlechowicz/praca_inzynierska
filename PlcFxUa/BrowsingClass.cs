/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;
using System.Windows.Forms;


namespace PlcFxUa
{
    class BrowsingClass
    {
        private Session session;
        public BrowsingClass(Session newSession)
        {
            this.session = newSession;
        }

        public void ReadMethodArguments(Argument[] inputArguments, NodeId nodeId)
        {

            // build list of references to browse.
            BrowseDescriptionCollection nodesToBrowse = new BrowseDescriptionCollection();

            BrowseDescription nodeToBrowse = new BrowseDescription();

            nodeToBrowse.NodeId = nodeId;
            nodeToBrowse.BrowseDirection = BrowseDirection.Forward;
            nodeToBrowse.ReferenceTypeId = ReferenceTypeIds.HasProperty;
            nodeToBrowse.IncludeSubtypes = true;
            nodeToBrowse.NodeClassMask = (uint)NodeClass.Variable;
            nodeToBrowse.ResultMask = (uint)BrowseResultMask.BrowseName;

            nodesToBrowse.Add(nodeToBrowse);

            // find properties.
            ReferenceDescriptionCollection references = Browse(this.session, nodesToBrowse, false);

            // build list of properties to read.
            ReadValueIdCollection nodesToRead = new ReadValueIdCollection();

            for (int i = 0; references != null && i < references.Count; i++)
            {
                ReferenceDescription reference = references[i];

                // ignore out of server references.
                if (reference.NodeId.IsAbsolute)
                {
                    continue;
                }

                // ignore other properties.
                if (reference.BrowseName != BrowseNames.InputArguments && reference.BrowseName != BrowseNames.OutputArguments)
                {
                    continue;
                }

                ReadValueId nodeToRead = new ReadValueId();
                nodeToRead.NodeId = (NodeId)reference.NodeId;
                nodeToRead.AttributeId = Attributes.Value;
                nodeToRead.Handle = reference;
                nodesToRead.Add(nodeToRead);
            }

            // method has no arguments.
            if (nodesToRead.Count == 0)
            {
                return;
            }

            // read the arguments.
            DataValueCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;

            this.session.Read(
                null,
                0,
                TimestampsToReturn.Neither,
                nodesToRead,
                out results,
                out diagnosticInfos);

            ClientBase.ValidateResponse(results, nodesToRead);
            ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToRead);

            // save the results.
            for (int i = 0; i < results.Count; i++)
            {
                ReferenceDescription reference = (ReferenceDescription)nodesToRead[i].Handle;

                if (StatusCode.IsGood(results[i].StatusCode))
                {
                    if (reference.BrowseName == BrowseNames.InputArguments)
                    {
                        inputArguments = (Argument[])ExtensionObject.ToArray(results[i].GetValue<ExtensionObject[]>(null), typeof(Argument));
                    }

                    //if (reference.BrowseName == BrowseNames.OutputArguments)
                    //{
                    //    outputArguments = (Argument[])ExtensionObject.ToArray(results[i].GetValue<ExtensionObject[]>(null), typeof(Argument));
                    //}
                }
            }

            // set default values for input arguments.
            if (inputArguments != null)
            {
                foreach (Argument argument in inputArguments)
                {
                    argument.Value = TypeInfo.GetDefaultValue(argument.DataType, argument.ValueRank, this.session.TypeTree);
                }
            }
        }
        public void Populate(NodeId sourceId, TreeNodeCollection nodes)
        {

            nodes.Clear();


            // find all of the components of the node.
            BrowseDescription nodeToBrowse1 = new BrowseDescription();

            nodeToBrowse1.NodeId = sourceId;
            nodeToBrowse1.BrowseDirection = BrowseDirection.Forward;
            nodeToBrowse1.ReferenceTypeId = ReferenceTypeIds.Aggregates;
            nodeToBrowse1.IncludeSubtypes = true;
            nodeToBrowse1.NodeClassMask = (uint)(NodeClass.Object | NodeClass.ObjectType | 
                NodeClass.Variable | NodeClass.Method | NodeClass.ReferenceType);
            nodeToBrowse1.ResultMask = (uint)BrowseResultMask.All;
            
            // find all nodes organized by the node.
            BrowseDescription nodeToBrowse2 = new BrowseDescription();

            nodeToBrowse2.NodeId = sourceId;
            nodeToBrowse2.BrowseDirection = BrowseDirection.Forward;
            nodeToBrowse2.ReferenceTypeId = ReferenceTypeIds.Organizes;
            nodeToBrowse2.IncludeSubtypes = true;
            nodeToBrowse2.NodeClassMask = (uint)(NodeClass.Object | NodeClass.Variable | NodeClass.Method);
            nodeToBrowse2.ResultMask = (uint)BrowseResultMask.All;

            BrowseDescriptionCollection nodesToBrowse = new BrowseDescriptionCollection();
            nodesToBrowse.Add(nodeToBrowse1);
            nodesToBrowse.Add(nodeToBrowse2);

            // fetch references from the server.
            ReferenceDescriptionCollection references = Browse(session, nodesToBrowse, false);

            // process results.
            for (int ii = 0; ii < references.Count; ii++)
            {
                ReferenceDescription target = references[ii];

                // add node.
                TreeNode child = new TreeNode(Utils.Format("{0}", target));
                child.Tag = target;
                child.Nodes.Add(new TreeNode());
                nodes.Add(child);
            }

        }
        private static ReferenceDescriptionCollection Browse(Session browsingSession, BrowseDescriptionCollection nodesToBrowse, bool throwOnError)
        {
            try
            {
                ReferenceDescriptionCollection references = new ReferenceDescriptionCollection();
                BrowseDescriptionCollection unprocessedOperations = new BrowseDescriptionCollection();

                while (nodesToBrowse.Count > 0)
                {
                    // start the browse operation.
                    BrowseResultCollection results = null;
                    DiagnosticInfoCollection diagnosticInfos = null;

                    browsingSession.Browse(
                        null,
                        null,
                        0,
                        nodesToBrowse,
                        out results,
                        out diagnosticInfos);

                    ClientBase.ValidateResponse(results, nodesToBrowse);
                    ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToBrowse);

                    ByteStringCollection continuationPoints = new ByteStringCollection();

                    for (int ii = 0; ii < nodesToBrowse.Count; ii++)
                    {
                        // check for error.
                        if (StatusCode.IsBad(results[ii].StatusCode))
                        {
                            // this error indicates that the server does not have enough simultaneously active 
                            // continuation points. This request will need to be resent after the other operations
                            // have been completed and their continuation points released.
                            if (results[ii].StatusCode == StatusCodes.BadNoContinuationPoints)
                            {
                                unprocessedOperations.Add(nodesToBrowse[ii]);
                            }

                            continue;
                        }

                        // check if all references have been fetched.
                        if (results[ii].References.Count == 0)
                        {
                            continue;
                        }

                        // save results.
                        references.AddRange(results[ii].References);

                        // check for continuation point.
                        if (results[ii].ContinuationPoint != null)
                        {
                            continuationPoints.Add(results[ii].ContinuationPoint);
                        }
                    }

                    // process continuation points.
                    ByteStringCollection revisedContiuationPoints = new ByteStringCollection();

                    while (continuationPoints.Count > 0)
                    {
                        // continue browse operation.
                        browsingSession.BrowseNext(
                            null,
                            false,
                            continuationPoints,
                            out results,
                            out diagnosticInfos);

                        ClientBase.ValidateResponse(results, continuationPoints);
                        ClientBase.ValidateDiagnosticInfos(diagnosticInfos, continuationPoints);

                        for (int ii = 0; ii < continuationPoints.Count; ii++)
                        {
                            // check for error.
                            if (StatusCode.IsBad(results[ii].StatusCode))
                            {
                                continue;
                            }

                            // check if all references have been fetched.
                            if (results[ii].References.Count == 0)
                            {
                                continue;
                            }

                            // save results.
                            references.AddRange(results[ii].References);

                            // check for continuation point.
                            if (results[ii].ContinuationPoint != null)
                            {
                                revisedContiuationPoints.Add(results[ii].ContinuationPoint);
                            }
                        }

                        // check if browsing must continue;
                        revisedContiuationPoints = continuationPoints;
                    }

                    // check if unprocessed results exist.
                    nodesToBrowse = unprocessedOperations;
                }

                // return complete list.
                return references;
            }
            catch (Exception exception)
            {
                if (throwOnError)
                {
                    throw new ServiceResultException(exception, StatusCodes.BadUnexpectedError);
                }

                return null;
            }
        }
    }
}
