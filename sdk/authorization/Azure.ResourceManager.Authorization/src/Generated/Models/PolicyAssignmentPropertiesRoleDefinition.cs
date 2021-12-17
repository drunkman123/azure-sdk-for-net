// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Details of role definition. </summary>
    public partial class PolicyAssignmentPropertiesRoleDefinition
    {
        /// <summary> Initializes a new instance of PolicyAssignmentPropertiesRoleDefinition. </summary>
        internal PolicyAssignmentPropertiesRoleDefinition()
        {
        }

        /// <summary> Initializes a new instance of PolicyAssignmentPropertiesRoleDefinition. </summary>
        /// <param name="id"> Id of the role definition. </param>
        /// <param name="displayName"> Display name of the role definition. </param>
        /// <param name="type"> Type of the role definition. </param>
        internal PolicyAssignmentPropertiesRoleDefinition(string id, string displayName, string type)
        {
            Id = id;
            DisplayName = displayName;
            Type = type;
        }

        /// <summary> Id of the role definition. </summary>
        public string Id { get; }
        /// <summary> Display name of the role definition. </summary>
        public string DisplayName { get; }
        /// <summary> Type of the role definition. </summary>
        public string Type { get; }
    }
}
