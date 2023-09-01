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

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="AppConfigurationPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="AppConfigurationPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="AppConfigurationStoreResource" />.
    /// To get an <see cref="AppConfigurationPrivateEndpointConnectionCollection" /> instance call the GetAppConfigurationPrivateEndpointConnections method from an instance of <see cref="AppConfigurationStoreResource" />.
    /// </summary>
    public partial class AppConfigurationPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<AppConfigurationPrivateEndpointConnectionResource>, IAsyncEnumerable<AppConfigurationPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected AppConfigurationPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppConfigurationPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", AppConfigurationPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppConfigurationPrivateEndpointConnectionResource.ResourceType, out string appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppConfigurationStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppConfigurationStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update the state of the specified private endpoint connection associated with the configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppConfigurationPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, AppConfigurationPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("AppConfigurationPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<AppConfigurationPrivateEndpointConnectionResource>(new AppConfigurationPrivateEndpointConnectionOperationSource(Client), _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the state of the specified private endpoint connection associated with the configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="data"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppConfigurationPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, AppConfigurationPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("AppConfigurationPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken);
                var operation = new AppConfigurationArmOperation<AppConfigurationPrivateEndpointConnectionResource>(new AppConfigurationPrivateEndpointConnectionOperationSource(Client), _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the specified private endpoint connection associated with the configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<AppConfigurationPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("AppConfigurationPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection associated with the configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<AppConfigurationPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("AppConfigurationPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all private endpoint connections for a configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByConfigurationStore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppConfigurationPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationPrivateEndpointConnectionResource(Client, AppConfigurationPrivateEndpointConnectionData.DeserializeAppConfigurationPrivateEndpointConnectionData(e)), _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "AppConfigurationPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all private endpoint connections for a configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByConfigurationStore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppConfigurationPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationPrivateEndpointConnectionResource(Client, AppConfigurationPrivateEndpointConnectionData.DeserializeAppConfigurationPrivateEndpointConnectionData(e)), _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "AppConfigurationPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("AppConfigurationPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("AppConfigurationPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _appConfigurationPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppConfigurationPrivateEndpointConnectionResource> IEnumerable<AppConfigurationPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppConfigurationPrivateEndpointConnectionResource> IAsyncEnumerable<AppConfigurationPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
