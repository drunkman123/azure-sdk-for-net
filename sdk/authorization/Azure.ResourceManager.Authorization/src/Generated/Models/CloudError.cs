// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> An error response from the service. </summary>
    internal partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"> An error response from the service. </param>
        internal CloudError(CloudErrorBody error)
        {
            Error = error;
        }

        /// <summary> An error response from the service. </summary>
        public CloudErrorBody Error { get; }
    }
}
