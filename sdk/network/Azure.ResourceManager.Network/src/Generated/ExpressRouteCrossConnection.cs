// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ExpressRouteCrossConnection along with the instance operations that can be performed on it. </summary>
    public class ExpressRouteCrossConnection : ExpressRouteCrossConnectionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteCrossConnection"/> class for mocking. </summary>
        protected ExpressRouteCrossConnection() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteCrossConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ExpressRouteCrossConnection(OperationsBase options, ExpressRouteCrossConnectionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ExpressRouteCrossConnectionData. </summary>
        public virtual ExpressRouteCrossConnectionData Data { get; private set; }
    }
}
