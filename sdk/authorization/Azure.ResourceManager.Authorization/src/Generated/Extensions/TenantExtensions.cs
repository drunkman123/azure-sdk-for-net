// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        #region TenantAccessReviewScheduleDefinitionInstance
        /// <summary> Gets an object representing a TenantAccessReviewScheduleDefinitionInstanceCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="TenantAccessReviewScheduleDefinitionInstanceCollection" /> object. </returns>
        public static TenantAccessReviewScheduleDefinitionInstanceCollection GetTenantAccessReviewScheduleDefinitionInstances(this Tenant tenant)
        {
            return new TenantAccessReviewScheduleDefinitionInstanceCollection(tenant);
        }
        #endregion

        #region DenyAssignment
        /// <summary> Gets an object representing a DenyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DenyAssignmentCollection" /> object. </returns>
        public static DenyAssignmentCollection GetDenyAssignments(this Tenant tenant)
        {
            return new DenyAssignmentCollection(tenant);
        }
        #endregion

        #region DenyAssignmentById
        /// <summary> Gets an object representing a DenyAssignmentByIdCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DenyAssignmentByIdCollection" /> object. </returns>
        public static DenyAssignmentByIdCollection GetDenyAssignmentByIds(this Tenant tenant)
        {
            return new DenyAssignmentByIdCollection(tenant);
        }
        #endregion

        #region ProviderOperationsMetadata
        /// <summary> Gets an object representing a ProviderOperationsMetadataCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ProviderOperationsMetadataCollection" /> object. </returns>
        public static ProviderOperationsMetadataCollection GetProviderOperationsMetadatas(this Tenant tenant)
        {
            return new ProviderOperationsMetadataCollection(tenant);
        }
        #endregion

        #region RoleAssignment
        /// <summary> Gets an object representing a RoleAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentCollection" /> object. </returns>
        public static RoleAssignmentCollection GetRoleAssignments(this Tenant tenant)
        {
            return new RoleAssignmentCollection(tenant);
        }
        #endregion

        #region RoleAssignmentById
        /// <summary> Gets an object representing a RoleAssignmentByIdCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentByIdCollection" /> object. </returns>
        public static RoleAssignmentByIdCollection GetRoleAssignmentByIds(this Tenant tenant)
        {
            return new RoleAssignmentByIdCollection(tenant);
        }
        #endregion

        #region RoleDefinition
        /// <summary> Gets an object representing a RoleDefinitionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleDefinitionCollection" /> object. </returns>
        public static RoleDefinitionCollection GetRoleDefinitions(this Tenant tenant)
        {
            return new RoleDefinitionCollection(tenant);
        }
        #endregion

        #region RoleDefinitionById
        /// <summary> Gets an object representing a RoleDefinitionByIdCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleDefinitionByIdCollection" /> object. </returns>
        public static RoleDefinitionByIdCollection GetRoleDefinitionByIds(this Tenant tenant)
        {
            return new RoleDefinitionByIdCollection(tenant);
        }
        #endregion

        #region RoleAssignmentSchedule
        /// <summary> Gets an object representing a RoleAssignmentScheduleCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentScheduleCollection" /> object. </returns>
        public static RoleAssignmentScheduleCollection GetRoleAssignmentSchedules(this Tenant tenant)
        {
            return new RoleAssignmentScheduleCollection(tenant);
        }
        #endregion

        #region RoleAssignmentScheduleInstance
        /// <summary> Gets an object representing a RoleAssignmentScheduleInstanceCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentScheduleInstanceCollection" /> object. </returns>
        public static RoleAssignmentScheduleInstanceCollection GetRoleAssignmentScheduleInstances(this Tenant tenant)
        {
            return new RoleAssignmentScheduleInstanceCollection(tenant);
        }
        #endregion

        #region RoleAssignmentScheduleRequest
        /// <summary> Gets an object representing a RoleAssignmentScheduleRequestCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentScheduleRequestCollection" /> object. </returns>
        public static RoleAssignmentScheduleRequestCollection GetRoleAssignmentScheduleRequests(this Tenant tenant)
        {
            return new RoleAssignmentScheduleRequestCollection(tenant);
        }
        #endregion

        #region RoleEligibilitySchedule
        /// <summary> Gets an object representing a RoleEligibilityScheduleCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleEligibilityScheduleCollection" /> object. </returns>
        public static RoleEligibilityScheduleCollection GetRoleEligibilitySchedules(this Tenant tenant)
        {
            return new RoleEligibilityScheduleCollection(tenant);
        }
        #endregion

        #region RoleEligibilityScheduleInstance
        /// <summary> Gets an object representing a RoleEligibilityScheduleInstanceCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleEligibilityScheduleInstanceCollection" /> object. </returns>
        public static RoleEligibilityScheduleInstanceCollection GetRoleEligibilityScheduleInstances(this Tenant tenant)
        {
            return new RoleEligibilityScheduleInstanceCollection(tenant);
        }
        #endregion

        #region RoleEligibilityScheduleRequest
        /// <summary> Gets an object representing a RoleEligibilityScheduleRequestCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleEligibilityScheduleRequestCollection" /> object. </returns>
        public static RoleEligibilityScheduleRequestCollection GetRoleEligibilityScheduleRequests(this Tenant tenant)
        {
            return new RoleEligibilityScheduleRequestCollection(tenant);
        }
        #endregion

        #region RoleManagementPolicy
        /// <summary> Gets an object representing a RoleManagementPolicyCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleManagementPolicyCollection" /> object. </returns>
        public static RoleManagementPolicyCollection GetRoleManagementPolicies(this Tenant tenant)
        {
            return new RoleManagementPolicyCollection(tenant);
        }
        #endregion

        #region RoleManagementPolicyAssignment
        /// <summary> Gets an object representing a RoleManagementPolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleManagementPolicyAssignmentCollection" /> object. </returns>
        public static RoleManagementPolicyAssignmentCollection GetRoleManagementPolicyAssignments(this Tenant tenant)
        {
            return new RoleManagementPolicyAssignmentCollection(tenant);
        }
        #endregion

        private static AccessReviewScheduleDefinitionsAssignedForMyApprovalRestOperations GetAccessReviewScheduleDefinitionsAssignedForMyApprovalRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new AccessReviewScheduleDefinitionsAssignedForMyApprovalRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint);
        }

        /// <summary> Lists the AccessReviewScheduleDefinitions for this <see cref="Tenant" />. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AccessReviewScheduleDefinition> GetAccessReviewScheduleDefinitionsAssignedForMyApprovalsAsync(this Tenant tenant, CancellationToken cancellationToken = default)
        {
            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetAccessReviewScheduleDefinitionsAssignedForMyApprovalRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                async Task<Page<AccessReviewScheduleDefinition>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetAccessReviewScheduleDefinitionsAssignedForMyApprovals");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(tenant, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<AccessReviewScheduleDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetAccessReviewScheduleDefinitionsAssignedForMyApprovals");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(tenant, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the AccessReviewScheduleDefinitions for this <see cref="Tenant" />. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<AccessReviewScheduleDefinition> GetAccessReviewScheduleDefinitionsAssignedForMyApprovals(this Tenant tenant, CancellationToken cancellationToken = default)
        {
            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetAccessReviewScheduleDefinitionsAssignedForMyApprovalRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                Page<AccessReviewScheduleDefinition> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetAccessReviewScheduleDefinitionsAssignedForMyApprovals");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(tenant, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<AccessReviewScheduleDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("TenantExtensions.GetAccessReviewScheduleDefinitionsAssignedForMyApprovals");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(tenant, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }
    }
}
