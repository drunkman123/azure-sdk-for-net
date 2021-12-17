// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region DenyAssignment
        /// <summary> Gets an object representing a DenyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DenyAssignmentCollection" /> object. </returns>
        public static DenyAssignmentCollection GetDenyAssignments(this ResourceGroup resourceGroup)
        {
            return new DenyAssignmentCollection(resourceGroup);
        }
        #endregion

        #region RoleAssignment
        /// <summary> Gets an object representing a RoleAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentCollection" /> object. </returns>
        public static RoleAssignmentCollection GetRoleAssignments(this ResourceGroup resourceGroup)
        {
            return new RoleAssignmentCollection(resourceGroup);
        }
        #endregion

        #region RoleDefinition
        /// <summary> Gets an object representing a RoleDefinitionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleDefinitionCollection" /> object. </returns>
        public static RoleDefinitionCollection GetRoleDefinitions(this ResourceGroup resourceGroup)
        {
            return new RoleDefinitionCollection(resourceGroup);
        }
        #endregion

        #region RoleAssignmentSchedule
        /// <summary> Gets an object representing a RoleAssignmentScheduleCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentScheduleCollection" /> object. </returns>
        public static RoleAssignmentScheduleCollection GetRoleAssignmentSchedules(this ResourceGroup resourceGroup)
        {
            return new RoleAssignmentScheduleCollection(resourceGroup);
        }
        #endregion

        #region RoleAssignmentScheduleInstance
        /// <summary> Gets an object representing a RoleAssignmentScheduleInstanceCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentScheduleInstanceCollection" /> object. </returns>
        public static RoleAssignmentScheduleInstanceCollection GetRoleAssignmentScheduleInstances(this ResourceGroup resourceGroup)
        {
            return new RoleAssignmentScheduleInstanceCollection(resourceGroup);
        }
        #endregion

        #region RoleAssignmentScheduleRequest
        /// <summary> Gets an object representing a RoleAssignmentScheduleRequestCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleAssignmentScheduleRequestCollection" /> object. </returns>
        public static RoleAssignmentScheduleRequestCollection GetRoleAssignmentScheduleRequests(this ResourceGroup resourceGroup)
        {
            return new RoleAssignmentScheduleRequestCollection(resourceGroup);
        }
        #endregion

        #region RoleEligibilitySchedule
        /// <summary> Gets an object representing a RoleEligibilityScheduleCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleEligibilityScheduleCollection" /> object. </returns>
        public static RoleEligibilityScheduleCollection GetRoleEligibilitySchedules(this ResourceGroup resourceGroup)
        {
            return new RoleEligibilityScheduleCollection(resourceGroup);
        }
        #endregion

        #region RoleEligibilityScheduleInstance
        /// <summary> Gets an object representing a RoleEligibilityScheduleInstanceCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleEligibilityScheduleInstanceCollection" /> object. </returns>
        public static RoleEligibilityScheduleInstanceCollection GetRoleEligibilityScheduleInstances(this ResourceGroup resourceGroup)
        {
            return new RoleEligibilityScheduleInstanceCollection(resourceGroup);
        }
        #endregion

        #region RoleEligibilityScheduleRequest
        /// <summary> Gets an object representing a RoleEligibilityScheduleRequestCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleEligibilityScheduleRequestCollection" /> object. </returns>
        public static RoleEligibilityScheduleRequestCollection GetRoleEligibilityScheduleRequests(this ResourceGroup resourceGroup)
        {
            return new RoleEligibilityScheduleRequestCollection(resourceGroup);
        }
        #endregion

        #region RoleManagementPolicy
        /// <summary> Gets an object representing a RoleManagementPolicyCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleManagementPolicyCollection" /> object. </returns>
        public static RoleManagementPolicyCollection GetRoleManagementPolicies(this ResourceGroup resourceGroup)
        {
            return new RoleManagementPolicyCollection(resourceGroup);
        }
        #endregion

        #region RoleManagementPolicyAssignment
        /// <summary> Gets an object representing a RoleManagementPolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="RoleManagementPolicyAssignmentCollection" /> object. </returns>
        public static RoleManagementPolicyAssignmentCollection GetRoleManagementPolicyAssignments(this ResourceGroup resourceGroup)
        {
            return new RoleManagementPolicyAssignmentCollection(resourceGroup);
        }
        #endregion

        private static PermissionsRestOperations GetPermissionsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new PermissionsRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint);
        }

        /// <summary> Lists the Permissions for this <see cref="ResourceGroup" />. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Permission> GetForResourceGroupPermissionsAsync(this ResourceGroup resourceGroup, CancellationToken cancellationToken = default)
        {
            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPermissionsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                async Task<Page<Permission>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourceGroupPermissions");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListForResourceGroupAsync(resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Permission>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourceGroupPermissions");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListForResourceGroupNextPageAsync(nextLink, resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the Permissions for this <see cref="ResourceGroup" />. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Permission> GetForResourceGroupPermissions(this ResourceGroup resourceGroup, CancellationToken cancellationToken = default)
        {
            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPermissionsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                Page<Permission> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourceGroupPermissions");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListForResourceGroup(resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Permission> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourceGroupPermissions");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListForResourceGroupNextPage(nextLink, resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the Permissions for this <see cref="ResourceGroup" />. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/>, <paramref name="parentResourcePath"/>, <paramref name="resourceType"/>, or <paramref name="resourceName"/> is null. </exception>
        public static AsyncPageable<Permission> GetForResourcePermissionsAsync(this ResourceGroup resourceGroup, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (parentResourcePath == null)
            {
                throw new ArgumentNullException(nameof(parentResourcePath));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPermissionsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                async Task<Page<Permission>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourcePermissions");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListForResourceAsync(resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Permission>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourcePermissions");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListForResourceNextPageAsync(nextLink, resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the Permissions for this <see cref="ResourceGroup" />. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/>, <paramref name="parentResourcePath"/>, <paramref name="resourceType"/>, or <paramref name="resourceName"/> is null. </exception>
        public static Pageable<Permission> GetForResourcePermissions(this ResourceGroup resourceGroup, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (parentResourcePath == null)
            {
                throw new ArgumentNullException(nameof(parentResourcePath));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPermissionsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                Page<Permission> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourcePermissions");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListForResource(resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Permission> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.GetForResourcePermissions");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListForResourceNextPage(nextLink, resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
