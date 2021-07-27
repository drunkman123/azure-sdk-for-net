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
    /// <summary> A class representing collection of ApplicationGateway and their operations over a ResourceGroup. </summary>
    public partial class ApplicationGatewayContainer : ResourceContainerBase<ApplicationGateway, ApplicationGatewayData>
    {
        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayContainer"/> class for mocking. </summary>
        protected ApplicationGatewayContainer()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ApplicationGatewayContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ApplicationGatewaysRestOperations _restClient => new ApplicationGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the specified application gateway. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update application gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<ApplicationGateway> CreateOrUpdate(string applicationGatewayName, ApplicationGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(applicationGatewayName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified application gateway. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update application gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ApplicationGateway>> CreateOrUpdateAsync(string applicationGatewayName, ApplicationGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(applicationGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified application gateway. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update application gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ApplicationGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string applicationGatewayName, ApplicationGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, applicationGatewayName, parameters, cancellationToken);
                return new ApplicationGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, applicationGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified application gateway. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update application gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ApplicationGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string applicationGatewayName, ApplicationGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationGatewayName == null)
            {
                throw new ArgumentNullException(nameof(applicationGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, applicationGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, applicationGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ApplicationGateway> Get(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.Get");
            scope.Start();
            try
            {
                if (applicationGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(applicationGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, applicationGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(new ApplicationGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ApplicationGateway>> GetAsync(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.Get");
            scope.Start();
            try
            {
                if (applicationGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(applicationGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, applicationGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual ApplicationGateway TryGet(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.TryGet");
            scope.Start();
            try
            {
                if (applicationGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(applicationGatewayName));
                }

                return Get(applicationGatewayName, cancellationToken: cancellationToken).Value;
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
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<ApplicationGateway> TryGetAsync(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.TryGet");
            scope.Start();
            try
            {
                if (applicationGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(applicationGatewayName));
                }

                return await GetAsync(applicationGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.DoesExist");
            scope.Start();
            try
            {
                if (applicationGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(applicationGatewayName));
                }

                return TryGet(applicationGatewayName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationGatewayName"> The name of the application gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string applicationGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.DoesExist");
            scope.Start();
            try
            {
                if (applicationGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(applicationGatewayName));
                }

                return await TryGetAsync(applicationGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all application gateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGateway" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ApplicationGateway> List(CancellationToken cancellationToken = default)
        {
            Page<ApplicationGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all application gateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGateway" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ApplicationGateway> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ApplicationGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ApplicationGatewayOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ApplicationGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationGatewayContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ApplicationGatewayOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, ApplicationGateway, ApplicationGatewayData> Construct() { }
    }
}
