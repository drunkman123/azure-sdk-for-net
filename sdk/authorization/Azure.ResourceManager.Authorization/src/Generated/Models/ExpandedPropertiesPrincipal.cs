// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Details of the principal. </summary>
    public partial class ExpandedPropertiesPrincipal
    {
        /// <summary> Initializes a new instance of ExpandedPropertiesPrincipal. </summary>
        internal ExpandedPropertiesPrincipal()
        {
        }

        /// <summary> Initializes a new instance of ExpandedPropertiesPrincipal. </summary>
        /// <param name="id"> Id of the principal. </param>
        /// <param name="displayName"> Display name of the principal. </param>
        /// <param name="email"> Email id of the principal. </param>
        /// <param name="type"> Type of the principal. </param>
        internal ExpandedPropertiesPrincipal(string id, string displayName, string email, string type)
        {
            Id = id;
            DisplayName = displayName;
            Email = email;
            Type = type;
        }

        /// <summary> Id of the principal. </summary>
        public string Id { get; }
        /// <summary> Display name of the principal. </summary>
        public string DisplayName { get; }
        /// <summary> Email id of the principal. </summary>
        public string Email { get; }
        /// <summary> Type of the principal. </summary>
        public string Type { get; }
    }
}
