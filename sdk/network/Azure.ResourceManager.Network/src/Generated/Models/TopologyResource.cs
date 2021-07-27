// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The network resource topology information for the given resource group. </summary>
    public partial class TopologyResource : Resources.Models.SubResource
    {
        /// <summary> Initializes a new instance of TopologyResource. </summary>
        internal TopologyResource()
        {
            Associations = new ChangeTrackingList<TopologyAssociation>();
        }

        /// <summary> Initializes a new instance of TopologyResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="associations"> Holds the associations the resource has with other resources in the resource group. </param>
        internal TopologyResource(string id, string name, string location, IReadOnlyList<TopologyAssociation> associations) : base(id)
        {
            Name = name;
            Location = location;
            Associations = associations;
        }

        /// <summary> Name of the resource. </summary>
        public string Name { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> Holds the associations the resource has with other resources in the resource group. </summary>
        public IReadOnlyList<TopologyAssociation> Associations { get; }
    }
}
