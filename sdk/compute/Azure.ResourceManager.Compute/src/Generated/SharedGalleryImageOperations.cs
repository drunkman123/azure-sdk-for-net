// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the operations that can be performed over a specific SharedGalleryImage. </summary>
    public partial class SharedGalleryImageOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private SharedGalleryImagesRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageOperations"/> class for mocking. </summary>
        protected SharedGalleryImageOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal SharedGalleryImageOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SharedGalleryImagesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries/images";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Get a shared gallery image by subscription id or tenant id. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SharedGalleryImage>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SharedGalleryImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a shared gallery image by subscription id or tenant id. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SharedGalleryImage> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SharedGalleryImageOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedGalleryImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Gets a list of SharedGalleryImageVersions in the SharedGalleryImage. </summary>
        /// <returns> An object representing collection of SharedGalleryImageVersions and their operations over a SharedGalleryImage. </returns>
        public SharedGalleryImageVersionContainer GetSharedGalleryImageVersions()
        {
            return new SharedGalleryImageVersionContainer(this);
        }
    }
}
