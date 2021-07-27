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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of PublicIPPrefix and their operations over a ResourceGroup. </summary>
    public partial class PublicIPPrefixContainer : ResourceContainerBase<PublicIPPrefix, PublicIPPrefixData>
    {
        /// <summary> Initializes a new instance of the <see cref="PublicIPPrefixContainer"/> class for mocking. </summary>
        protected PublicIPPrefixContainer()
        {
        }

        /// <summary> Initializes a new instance of PublicIPPrefixContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PublicIPPrefixContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PublicIPPrefixesRestOperations _restClient => new PublicIPPrefixesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a static or dynamic public IP prefix. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<PublicIPPrefix> CreateOrUpdate(string publicIpPrefixName, PublicIPPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(publicIpPrefixName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a static or dynamic public IP prefix. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<PublicIPPrefix>> CreateOrUpdateAsync(string publicIpPrefixName, PublicIPPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(publicIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a static or dynamic public IP prefix. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PublicIPPrefixesCreateOrUpdateOperation StartCreateOrUpdate(string publicIpPrefixName, PublicIPPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, publicIpPrefixName, parameters, cancellationToken);
                return new PublicIPPrefixesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, publicIpPrefixName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a static or dynamic public IP prefix. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP prefix operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpPrefixName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PublicIPPrefixesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string publicIpPrefixName, PublicIPPrefixData parameters, CancellationToken cancellationToken = default)
        {
            if (publicIpPrefixName == null)
            {
                throw new ArgumentNullException(nameof(publicIpPrefixName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, publicIpPrefixName, parameters, cancellationToken).ConfigureAwait(false);
                return new PublicIPPrefixesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, publicIpPrefixName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PublicIPPrefix> Get(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.Get");
            scope.Start();
            try
            {
                if (publicIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(publicIpPrefixName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, publicIpPrefixName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new PublicIPPrefix(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PublicIPPrefix>> GetAsync(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.Get");
            scope.Start();
            try
            {
                if (publicIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(publicIpPrefixName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, publicIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PublicIPPrefix(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual PublicIPPrefix TryGet(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.TryGet");
            scope.Start();
            try
            {
                if (publicIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(publicIpPrefixName));
                }

                return Get(publicIpPrefixName, expand, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<PublicIPPrefix> TryGetAsync(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.TryGet");
            scope.Start();
            try
            {
                if (publicIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(publicIpPrefixName));
                }

                return await GetAsync(publicIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.DoesExist");
            scope.Start();
            try
            {
                if (publicIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(publicIpPrefixName));
                }

                return TryGet(publicIpPrefixName, expand, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpPrefixName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string publicIpPrefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.DoesExist");
            scope.Start();
            try
            {
                if (publicIpPrefixName == null)
                {
                    throw new ArgumentNullException(nameof(publicIpPrefixName));
                }

                return await TryGetAsync(publicIpPrefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all public IP prefixes in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublicIPPrefix" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PublicIPPrefix> List(CancellationToken cancellationToken = default)
        {
            Page<PublicIPPrefix> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPPrefix> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all public IP prefixes in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublicIPPrefix" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PublicIPPrefix> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PublicIPPrefix>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPPrefix>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPPrefix(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PublicIPPrefix" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PublicIPPrefixOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PublicIPPrefix" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPPrefixContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PublicIPPrefixOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, PublicIPPrefix, PublicIPPrefixData> Construct() { }
    }
}
