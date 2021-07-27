// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Azure Web Category Resource. </summary>
    public partial class AzureWebCategory : Resources.Models.Resource
    {
        /// <summary> Initializes a new instance of AzureWebCategory. </summary>
        internal AzureWebCategory()
        {
        }

        /// <summary> Initializes a new instance of AzureWebCategory. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="group"> The name of the group that the category belongs to. </param>
        internal AzureWebCategory(ResourceIdentifier id, string name, ResourceType type, string etag, string group) : base(id, name, type)
        {
            Etag = etag;
            Group = group;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The name of the group that the category belongs to. </summary>
        public string Group { get; }
    }
}
