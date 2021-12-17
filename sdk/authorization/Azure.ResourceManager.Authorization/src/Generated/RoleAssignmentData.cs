// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing the RoleAssignment data model. </summary>
    public partial class RoleAssignmentData : Resource
    {
        /// <summary> Initializes a new instance of RoleAssignmentData. </summary>
        internal RoleAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="scope"> The role assignment scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="description"> Description of role assignment. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently accepted value is &apos;2.0&apos;. </param>
        /// <param name="createdOn"> Time it was created. </param>
        /// <param name="updatedOn"> Time it was updated. </param>
        /// <param name="createdBy"> Id of the user who created the assignment. </param>
        /// <param name="updatedBy"> Id of the user who updated the assignment. </param>
        /// <param name="delegatedManagedIdentityResourceId"> Id of the delegated managed identity resource. </param>
        internal RoleAssignmentData(ResourceIdentifier id, string name, ResourceType type, string scope, string roleDefinitionId, string principalId, PrincipalType? principalType, string description, string condition, string conditionVersion, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string createdBy, string updatedBy, string delegatedManagedIdentityResourceId) : base(id, name, type)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            Description = description;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            DelegatedManagedIdentityResourceId = delegatedManagedIdentityResourceId;
        }

        /// <summary> The role assignment scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public string PrincipalId { get; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public PrincipalType? PrincipalType { get; }
        /// <summary> Description of role assignment. </summary>
        public string Description { get; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase &apos;foo_storage_container&apos;. </summary>
        public string Condition { get; }
        /// <summary> Version of the condition. Currently accepted value is &apos;2.0&apos;. </summary>
        public string ConditionVersion { get; }
        /// <summary> Time it was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time it was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Id of the user who created the assignment. </summary>
        public string CreatedBy { get; }
        /// <summary> Id of the user who updated the assignment. </summary>
        public string UpdatedBy { get; }
        /// <summary> Id of the delegated managed identity resource. </summary>
        public string DelegatedManagedIdentityResourceId { get; }
    }
}
