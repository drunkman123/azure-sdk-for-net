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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing collection of AccessReviewInstance and their operations over its parent. </summary>
    public partial class AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection : ArmCollection, IEnumerable<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>, IAsyncEnumerable<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AccessReviewInstancesRestOperations _accessReviewInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection"/> class for mocking. </summary>
        protected AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _accessReviewInstancesRestClient = new AccessReviewInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AccessReviewScheduleDefinition.ResourceType;

        // Collection level operations.

        /// <summary> Get access review instances. </summary>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> Get(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _accessReviewInstancesRestClient.GetById(Id.SubscriptionId, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get access review instances. </summary>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _accessReviewInstancesRestClient.GetByIdAsync(Id.SubscriptionId, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _accessReviewInstancesRestClient.GetById(Id.SubscriptionId, Id.Name, id, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>(null, response.GetRawResponse())
                    : Response.FromValue(new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _accessReviewInstancesRestClient.GetByIdAsync(Id.SubscriptionId, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>(null, response.GetRawResponse())
                    : Response.FromValue(new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> The id of the access review instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get access review instances. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _accessReviewInstancesRestClient.List(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _accessReviewInstancesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get access review instances. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _accessReviewInstancesRestClient.ListAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _accessReviewInstancesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> IEnumerable<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance> IAsyncEnumerable<AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AccessReviewScheduleDefinitionAccessReviewScheduleDefinitionInstance, AccessReviewInstanceData> Construct() { }
    }
}
