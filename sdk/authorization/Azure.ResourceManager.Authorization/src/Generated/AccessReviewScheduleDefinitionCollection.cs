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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing collection of AccessReviewScheduleDefinition and their operations over its parent. </summary>
    public partial class AccessReviewScheduleDefinitionCollection : ArmCollection, IEnumerable<AccessReviewScheduleDefinition>, IAsyncEnumerable<AccessReviewScheduleDefinition>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AccessReviewScheduleDefinitionsRestOperations _accessReviewScheduleDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AccessReviewScheduleDefinitionCollection"/> class for mocking. </summary>
        protected AccessReviewScheduleDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of AccessReviewScheduleDefinitionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AccessReviewScheduleDefinitionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _accessReviewScheduleDefinitionsRestClient = new AccessReviewScheduleDefinitionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Collection level operations.

        /// <summary> Create or Update access review schedule definition. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="properties"> Access review schedule definition properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="properties"/> is null. </exception>
        public virtual AccessReviewScheduleDefinitionCreateOrUpdateByIdOperation CreateOrUpdate(string scheduleDefinitionId, AccessReviewScheduleDefinitionProperties properties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _accessReviewScheduleDefinitionsRestClient.CreateOrUpdateById(Id.SubscriptionId, scheduleDefinitionId, properties, cancellationToken);
                var operation = new AccessReviewScheduleDefinitionCreateOrUpdateByIdOperation(Parent, response);
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

        /// <summary> Create or Update access review schedule definition. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="properties"> Access review schedule definition properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<AccessReviewScheduleDefinitionCreateOrUpdateByIdOperation> CreateOrUpdateAsync(string scheduleDefinitionId, AccessReviewScheduleDefinitionProperties properties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _accessReviewScheduleDefinitionsRestClient.CreateOrUpdateByIdAsync(Id.SubscriptionId, scheduleDefinitionId, properties, cancellationToken).ConfigureAwait(false);
                var operation = new AccessReviewScheduleDefinitionCreateOrUpdateByIdOperation(Parent, response);
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

        /// <summary> Get single access review definition. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        public virtual Response<AccessReviewScheduleDefinition> Get(string scheduleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _accessReviewScheduleDefinitionsRestClient.GetById(Id.SubscriptionId, scheduleDefinitionId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AccessReviewScheduleDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get single access review definition. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        public async virtual Task<Response<AccessReviewScheduleDefinition>> GetAsync(string scheduleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _accessReviewScheduleDefinitionsRestClient.GetByIdAsync(Id.SubscriptionId, scheduleDefinitionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AccessReviewScheduleDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        public virtual Response<AccessReviewScheduleDefinition> GetIfExists(string scheduleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _accessReviewScheduleDefinitionsRestClient.GetById(Id.SubscriptionId, scheduleDefinitionId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AccessReviewScheduleDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new AccessReviewScheduleDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        public async virtual Task<Response<AccessReviewScheduleDefinition>> GetIfExistsAsync(string scheduleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _accessReviewScheduleDefinitionsRestClient.GetByIdAsync(Id.SubscriptionId, scheduleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AccessReviewScheduleDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new AccessReviewScheduleDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string scheduleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(scheduleDefinitionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="scheduleDefinitionId"> The id of the access review schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleDefinitionId"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string scheduleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (scheduleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(scheduleDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(scheduleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get access review schedule definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AccessReviewScheduleDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AccessReviewScheduleDefinition> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AccessReviewScheduleDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _accessReviewScheduleDefinitionsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AccessReviewScheduleDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _accessReviewScheduleDefinitionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get access review schedule definitions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AccessReviewScheduleDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AccessReviewScheduleDefinition> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AccessReviewScheduleDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _accessReviewScheduleDefinitionsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AccessReviewScheduleDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _accessReviewScheduleDefinitionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AccessReviewScheduleDefinition" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AccessReviewScheduleDefinition.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AccessReviewScheduleDefinition" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AccessReviewScheduleDefinition.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AccessReviewScheduleDefinition> IEnumerable<AccessReviewScheduleDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AccessReviewScheduleDefinition> IAsyncEnumerable<AccessReviewScheduleDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AccessReviewScheduleDefinition, AccessReviewScheduleDefinitionData> Construct() { }
    }
}
