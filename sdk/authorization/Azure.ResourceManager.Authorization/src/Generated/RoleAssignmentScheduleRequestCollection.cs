// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing collection of RoleAssignmentScheduleRequest and their operations over its parent. </summary>
    public partial class RoleAssignmentScheduleRequestCollection : ArmCollection, IEnumerable<RoleAssignmentScheduleRequest>, IAsyncEnumerable<RoleAssignmentScheduleRequest>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RoleAssignmentScheduleRequestsRestOperations _roleAssignmentScheduleRequestsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleRequestCollection"/> class for mocking. </summary>
        protected RoleAssignmentScheduleRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentScheduleRequestCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RoleAssignmentScheduleRequestCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _roleAssignmentScheduleRequestsRestClient = new RoleAssignmentScheduleRequestsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.Root.ResourceType;

        /// <summary> Verify that the input resource Id is a valid collection for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        // Collection level operations.

        /// <summary> Creates a role assignment schedule request. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name of the role assignment to create. It can be any valid GUID. </param>
        /// <param name="parameters"> Parameters for the role assignment schedule request. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual RoleAssignmentScheduleRequestCreateOperation CreateOrUpdate(string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestsRestClient.Create(Id, roleAssignmentScheduleRequestName, parameters, cancellationToken);
                var operation = new RoleAssignmentScheduleRequestCreateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a role assignment schedule request. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name of the role assignment to create. It can be any valid GUID. </param>
        /// <param name="parameters"> Parameters for the role assignment schedule request. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RoleAssignmentScheduleRequestCreateOperation> CreateOrUpdateAsync(string roleAssignmentScheduleRequestName, RoleAssignmentScheduleRequestData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestsRestClient.CreateAsync(Id, roleAssignmentScheduleRequestName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new RoleAssignmentScheduleRequestCreateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified role assignment schedule request. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual Response<RoleAssignmentScheduleRequest> Get(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestsRestClient.Get(Id, roleAssignmentScheduleRequestName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleRequest(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified role assignment schedule request. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public async virtual Task<Response<RoleAssignmentScheduleRequest>> GetAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestsRestClient.GetAsync(Id, roleAssignmentScheduleRequestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RoleAssignmentScheduleRequest(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual Response<RoleAssignmentScheduleRequest> GetIfExists(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRequestsRestClient.Get(Id, roleAssignmentScheduleRequestName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<RoleAssignmentScheduleRequest>(null, response.GetRawResponse())
                    : Response.FromValue(new RoleAssignmentScheduleRequest(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public async virtual Task<Response<RoleAssignmentScheduleRequest>> GetIfExistsAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRequestsRestClient.GetAsync(Id, roleAssignmentScheduleRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<RoleAssignmentScheduleRequest>(null, response.GetRawResponse())
                    : Response.FromValue(new RoleAssignmentScheduleRequest(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(roleAssignmentScheduleRequestName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            if (roleAssignmentScheduleRequestName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentScheduleRequestName));
            }

            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(roleAssignmentScheduleRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets role assignment schedule requests for a scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleAssignmentScheduleRequest" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleAssignmentScheduleRequest> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<RoleAssignmentScheduleRequest> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleAssignmentScheduleRequestsRestClient.ListForScope(Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleRequest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RoleAssignmentScheduleRequest> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleAssignmentScheduleRequestsRestClient.ListForScopeNextPage(nextLink, Id, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleRequest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets role assignment schedule requests for a scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignment schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role assignment schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role assignment schedule requests requested by the current user. Use $filter=asTarget() to return all role assignment schedule requests created for the current user. Use $filter=asApprover() to return all role assignment schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleAssignmentScheduleRequest" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleAssignmentScheduleRequest> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RoleAssignmentScheduleRequest>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleAssignmentScheduleRequestsRestClient.ListForScopeAsync(Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleRequest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RoleAssignmentScheduleRequest>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RoleAssignmentScheduleRequestCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleAssignmentScheduleRequestsRestClient.ListForScopeNextPageAsync(nextLink, Id, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleAssignmentScheduleRequest(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<RoleAssignmentScheduleRequest> IEnumerable<RoleAssignmentScheduleRequest>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleAssignmentScheduleRequest> IAsyncEnumerable<RoleAssignmentScheduleRequest>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, RoleAssignmentScheduleRequest, RoleAssignmentScheduleRequestData> Construct() { }
    }
}
