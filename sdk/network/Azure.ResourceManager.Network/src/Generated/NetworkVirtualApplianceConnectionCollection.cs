// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkVirtualApplianceConnectionResource"/> and their operations.
    /// Each <see cref="NetworkVirtualApplianceConnectionResource"/> in the collection will belong to the same instance of <see cref="NetworkVirtualApplianceResource"/>.
    /// To get a <see cref="NetworkVirtualApplianceConnectionCollection"/> instance call the GetNetworkVirtualApplianceConnections method from an instance of <see cref="NetworkVirtualApplianceResource"/>.
    /// </summary>
    public partial class NetworkVirtualApplianceConnectionCollection : ArmCollection, IEnumerable<NetworkVirtualApplianceConnectionResource>, IAsyncEnumerable<NetworkVirtualApplianceConnectionResource>
    {
        private readonly ClientDiagnostics _networkVirtualApplianceConnectionClientDiagnostics;
        private readonly NetworkVirtualApplianceConnectionsRestOperations _networkVirtualApplianceConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceConnectionCollection"/> class for mocking. </summary>
        protected NetworkVirtualApplianceConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkVirtualApplianceConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkVirtualApplianceConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkVirtualApplianceConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkVirtualApplianceConnectionResource.ResourceType, out string networkVirtualApplianceConnectionApiVersion);
            _networkVirtualApplianceConnectionRestClient = new NetworkVirtualApplianceConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkVirtualApplianceConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkVirtualApplianceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkVirtualApplianceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a connection to Network Virtual Appliance, if it doesn't exist else updates the existing NVA connection'
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="data"> Parameters supplied in an NetworkVirtualApplianceConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkVirtualApplianceConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, NetworkVirtualApplianceConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkVirtualApplianceConnectionResource>(new NetworkVirtualApplianceConnectionOperationSource(Client), _networkVirtualApplianceConnectionClientDiagnostics, Pipeline, _networkVirtualApplianceConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a connection to Network Virtual Appliance, if it doesn't exist else updates the existing NVA connection'
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="data"> Parameters supplied in an NetworkVirtualApplianceConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkVirtualApplianceConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, NetworkVirtualApplianceConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkVirtualApplianceConnectionResource>(new NetworkVirtualApplianceConnectionOperationSource(Client), _networkVirtualApplianceConnectionClientDiagnostics, Pipeline, _networkVirtualApplianceConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of specified NVA connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<NetworkVirtualApplianceConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of specified NVA connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<NetworkVirtualApplianceConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists NetworkVirtualApplianceConnections under the NVA.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkVirtualApplianceConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkVirtualApplianceConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkVirtualApplianceConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkVirtualApplianceConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkVirtualApplianceConnectionResource(Client, NetworkVirtualApplianceConnectionData.DeserializeNetworkVirtualApplianceConnectionData(e)), _networkVirtualApplianceConnectionClientDiagnostics, Pipeline, "NetworkVirtualApplianceConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists NetworkVirtualApplianceConnections under the NVA.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkVirtualApplianceConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkVirtualApplianceConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkVirtualApplianceConnectionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkVirtualApplianceConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkVirtualApplianceConnectionResource(Client, NetworkVirtualApplianceConnectionData.DeserializeNetworkVirtualApplianceConnectionData(e)), _networkVirtualApplianceConnectionClientDiagnostics, Pipeline, "NetworkVirtualApplianceConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkVirtualApplianceConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkVirtualApplianceConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkVirtualApplianceConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkVirtualAppliances/{networkVirtualApplianceName}/networkVirtualApplianceConnections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkVirtualApplianceConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the NVA connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual NullableResponse<NetworkVirtualApplianceConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _networkVirtualApplianceConnectionClientDiagnostics.CreateScope("NetworkVirtualApplianceConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkVirtualApplianceConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkVirtualApplianceConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkVirtualApplianceConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkVirtualApplianceConnectionResource> IEnumerable<NetworkVirtualApplianceConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkVirtualApplianceConnectionResource> IAsyncEnumerable<NetworkVirtualApplianceConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
