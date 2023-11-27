// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the MongoDBRoleDefinition data model.
    /// An Azure Cosmos DB Mongo Role Definition.
    /// </summary>
    public partial class MongoDBRoleDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of MongoDBRoleDefinitionData. </summary>
        public MongoDBRoleDefinitionData()
        {
            Privileges = new ChangeTrackingList<MongoDBPrivilege>();
            Roles = new ChangeTrackingList<MongoDBRole>();
        }

        /// <summary> Initializes a new instance of MongoDBRoleDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="roleName"> A user-friendly name for the Role Definition. Must be unique for the database account. </param>
        /// <param name="roleDefinitionType"> Indicates whether the Role Definition was built-in or user created. </param>
        /// <param name="databaseName"> The database name for which access is being granted for this Role Definition. </param>
        /// <param name="privileges"> A set of privileges contained by the Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as privilege. </param>
        /// <param name="roles"> The set of roles inherited by this Role Definition. </param>
        internal MongoDBRoleDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string roleName, MongoDBRoleDefinitionType? roleDefinitionType, string databaseName, IList<MongoDBPrivilege> privileges, IList<MongoDBRole> roles) : base(id, name, resourceType, systemData)
        {
            RoleName = roleName;
            RoleDefinitionType = roleDefinitionType;
            DatabaseName = databaseName;
            Privileges = privileges;
            Roles = roles;
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        public string RoleName { get; set; }
        /// <summary> The database name for which access is being granted for this Role Definition. </summary>
        public string DatabaseName { get; set; }
        /// <summary> A set of privileges contained by the Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as privilege. </summary>
        public IList<MongoDBPrivilege> Privileges { get; }
        /// <summary> The set of roles inherited by this Role Definition. </summary>
        public IList<MongoDBRole> Roles { get; }
    }
}
