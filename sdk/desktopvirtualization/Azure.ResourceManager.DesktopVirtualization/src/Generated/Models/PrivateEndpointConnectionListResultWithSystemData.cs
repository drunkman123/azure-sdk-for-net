// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
    internal partial class PrivateEndpointConnectionListResultWithSystemData
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResultWithSystemData. </summary>
        internal PrivateEndpointConnectionListResultWithSystemData()
        {
            Value = new ChangeTrackingList<DesktopVirtualizationPrivateEndpointConnectionDataData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionListResultWithSystemData. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal PrivateEndpointConnectionListResultWithSystemData(IReadOnlyList<DesktopVirtualizationPrivateEndpointConnectionDataData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<DesktopVirtualizationPrivateEndpointConnectionDataData> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
