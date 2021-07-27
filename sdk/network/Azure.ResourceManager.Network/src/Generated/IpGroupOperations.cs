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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific IpGroup. </summary>
    public partial class IpGroupOperations : ResourceOperationsBase<IpGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private IpGroupsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="IpGroupOperations"/> class for mocking. </summary>
        protected IpGroupOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IpGroupOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal IpGroupOperations(OperationsBase options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new IpGroupsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/ipGroups";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<IpGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<IpGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified ipGroups. </summary>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IpGroup>> GetAsync(string expand, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified ipGroups. </summary>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IpGroup> Get(string expand, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                return Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
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
        public async virtual Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified ipGroups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ipGroups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ipGroups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<IpGroupsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new IpGroupsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ipGroups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual IpGroupsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new IpGroupsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates tags of an IpGroups resource. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IpGroup>> UpdateGroupsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.UpdateGroups");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateGroupsAsync(Id.ResourceGroupName, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates tags of an IpGroups resource. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IpGroup> UpdateGroups(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupOperations.UpdateGroups");
            scope.Start();
            try
            {
                var response = _restClient.UpdateGroups(Id.ResourceGroupName, Id.Name, tags, cancellationToken);
                return Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
