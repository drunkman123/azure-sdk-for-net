// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The PolicyAssignmentProperties. </summary>
    public partial class PolicyAssignmentProperties
    {
        /// <summary> Initializes a new instance of PolicyAssignmentProperties. </summary>
        internal PolicyAssignmentProperties()
        {
        }

        /// <summary> Initializes a new instance of PolicyAssignmentProperties. </summary>
        /// <param name="scope"> Details of the resource scope. </param>
        /// <param name="roleDefinition"> Details of role definition. </param>
        /// <param name="policy"> Details of the policy. </param>
        internal PolicyAssignmentProperties(PolicyAssignmentPropertiesScope scope, PolicyAssignmentPropertiesRoleDefinition roleDefinition, PolicyAssignmentPropertiesPolicy policy)
        {
            Scope = scope;
            RoleDefinition = roleDefinition;
            Policy = policy;
        }

        /// <summary> Details of the resource scope. </summary>
        public PolicyAssignmentPropertiesScope Scope { get; }
        /// <summary> Details of role definition. </summary>
        public PolicyAssignmentPropertiesRoleDefinition RoleDefinition { get; }
        /// <summary> Details of the policy. </summary>
        public PolicyAssignmentPropertiesPolicy Policy { get; }
    }
}
