// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a HubVirtualNetworkConnection along with the instance operations that can be performed on it. </summary>
    public class HubVirtualNetworkConnection : HubVirtualNetworkConnectionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "HubVirtualNetworkConnection"/> class for mocking. </summary>
        protected HubVirtualNetworkConnection() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HubVirtualNetworkConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal HubVirtualNetworkConnection(OperationsBase options, HubVirtualNetworkConnectionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the HubVirtualNetworkConnectionData. </summary>
        public virtual HubVirtualNetworkConnectionData Data { get; private set; }
    }
}
