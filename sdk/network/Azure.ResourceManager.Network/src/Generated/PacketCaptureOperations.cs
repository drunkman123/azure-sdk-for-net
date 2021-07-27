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
    /// <summary> A class representing the operations that can be performed over a specific PacketCapture. </summary>
    public partial class PacketCaptureOperations : ResourceOperationsBase<PacketCapture>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private PacketCapturesRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureOperations"/> class for mocking. </summary>
        protected PacketCaptureOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PacketCaptureOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal PacketCaptureOperations(OperationsBase options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PacketCapturesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkWatchers/packetCaptures";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<PacketCapture>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<PacketCapture> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new PacketCapture(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.Delete");
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

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.Delete");
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

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PacketCapturesDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new PacketCapturesDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.Stop");
            scope.Start();
            try
            {
                var operation = await StartStopAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.Stop");
            scope.Start();
            try
            {
                var operation = StartStop(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PacketCapturesStopOperation> StartStopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.StartStop");
            scope.Start();
            try
            {
                var response = await _restClient.StopAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesStopOperation StartStop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.StartStop");
            scope.Start();
            try
            {
                var response = _restClient.Stop(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new PacketCapturesStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PacketCaptureQueryStatusResult>> GetStatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.GetStatus");
            scope.Start();
            try
            {
                var operation = await StartGetStatusAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PacketCaptureQueryStatusResult> GetStatus(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.GetStatus");
            scope.Start();
            try
            {
                var operation = StartGetStatus(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PacketCapturesGetStatusOperation> StartGetStatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.StartGetStatus");
            scope.Start();
            try
            {
                var response = await _restClient.GetStatusAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PacketCapturesGetStatusOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetStatusRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PacketCapturesGetStatusOperation StartGetStatus(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PacketCaptureOperations.StartGetStatus");
            scope.Start();
            try
            {
                var response = _restClient.GetStatus(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new PacketCapturesGetStatusOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetStatusRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
