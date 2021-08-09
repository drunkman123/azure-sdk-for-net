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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryApplicationVersion and their operations over a GalleryApplication. </summary>
    public partial class GalleryApplicationVersionContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="GalleryApplicationVersionContainer"/> class for mocking. </summary>
        protected GalleryApplicationVersionContainer()
        {
        }

        /// <summary> Initializes a new instance of GalleryApplicationVersionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryApplicationVersionContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private GalleryApplicationVersionsRestOperations _restClient => new GalleryApplicationVersionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => GalleryApplicationOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> or <paramref name="galleryApplicationVersion"/> is null. </exception>
        public virtual Response<GalleryApplicationVersion> CreateOrUpdate(string galleryApplicationVersionName, GalleryApplicationVersionData galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(galleryApplicationVersionName, galleryApplicationVersion, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> or <paramref name="galleryApplicationVersion"/> is null. </exception>
        public async virtual Task<Response<GalleryApplicationVersion>> CreateOrUpdateAsync(string galleryApplicationVersionName, GalleryApplicationVersionData galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(galleryApplicationVersionName, galleryApplicationVersion, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> or <paramref name="galleryApplicationVersion"/> is null. </exception>
        public virtual GalleryApplicationVersionCreateOrUpdateOperation StartCreateOrUpdate(string galleryApplicationVersionName, GalleryApplicationVersionData galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, galleryApplicationVersion, cancellationToken);
                return new GalleryApplicationVersionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, galleryApplicationVersion).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryApplicationVersionName"/> or <paramref name="galleryApplicationVersion"/> is null. </exception>
        public async virtual Task<GalleryApplicationVersionCreateOrUpdateOperation> StartCreateOrUpdateAsync(string galleryApplicationVersionName, GalleryApplicationVersionData galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, galleryApplicationVersion, cancellationToken).ConfigureAwait(false);
                return new GalleryApplicationVersionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, galleryApplicationVersion).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryApplicationVersion> Get(string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.Get");
            scope.Start();
            try
            {
                if (galleryApplicationVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationVersionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryApplicationVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryApplicationVersion>> GetAsync(string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.Get");
            scope.Start();
            try
            {
                if (galleryApplicationVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationVersionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GalleryApplicationVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryApplicationVersion> GetIfExists(string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationVersionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GalleryApplicationVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryApplicationVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryApplicationVersion>> GetIfExistsAsync(string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationVersionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryApplicationVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GalleryApplicationVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryApplicationVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationVersionName));
                }

                var response = GetIfExists(galleryApplicationVersionName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryApplicationVersionName == null)
                {
                    throw new ArgumentNullException(nameof(galleryApplicationVersionName));
                }

                var response = await GetIfExistsAsync(galleryApplicationVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryApplicationVersion" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<GalleryApplicationVersion> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryApplicationVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByGalleryApplication(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryApplicationVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByGalleryApplicationNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryApplicationVersion" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GalleryApplicationVersion> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryApplicationVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByGalleryApplicationAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryApplicationVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByGalleryApplicationNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryApplicationVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="GalleryApplicationVersion" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryApplicationVersionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="GalleryApplicationVersion" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryApplicationVersionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryApplicationVersionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, GalleryApplicationVersion, GalleryApplicationVersionData> Construct() { }
    }
}
