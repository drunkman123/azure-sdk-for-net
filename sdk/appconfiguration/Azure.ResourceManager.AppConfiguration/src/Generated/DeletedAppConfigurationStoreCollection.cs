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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="DeletedAppConfigurationStoreResource"/> and their operations.
    /// Each <see cref="DeletedAppConfigurationStoreResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="DeletedAppConfigurationStoreCollection"/> instance call the GetDeletedAppConfigurationStores method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class DeletedAppConfigurationStoreCollection : ArmCollection, IEnumerable<DeletedAppConfigurationStoreResource>, IAsyncEnumerable<DeletedAppConfigurationStoreResource>
    {
        private readonly ClientDiagnostics _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _deletedAppConfigurationStoreConfigurationStoresRestClient;
        private readonly ClientDiagnostics _configurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _configurationStoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedAppConfigurationStoreCollection"/> class for mocking. </summary>
        protected DeletedAppConfigurationStoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedAppConfigurationStoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedAppConfigurationStoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", DeletedAppConfigurationStoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeletedAppConfigurationStoreResource.ResourceType, out string deletedAppConfigurationStoreConfigurationStoresApiVersion);
            _deletedAppConfigurationStoreConfigurationStoresRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedAppConfigurationStoreConfigurationStoresApiVersion);
            _configurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _configurationStoresRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<DeletedAppConfigurationStoreResource>> GetAsync(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAppConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<DeletedAppConfigurationStoreResource> Get(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAppConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the deleted configuration stores in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/deletedConfigurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_ListDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAppConfigurationStoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedAppConfigurationStoreResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _configurationStoresRestClient.CreateListDeletedRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _configurationStoresRestClient.CreateListDeletedNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeletedAppConfigurationStoreResource(Client, DeletedAppConfigurationStoreData.DeserializeDeletedAppConfigurationStoreData(e)), _configurationStoresClientDiagnostics, Pipeline, "DeletedAppConfigurationStoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the deleted configuration stores in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/deletedConfigurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_ListDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAppConfigurationStoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedAppConfigurationStoreResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _configurationStoresRestClient.CreateListDeletedRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _configurationStoresRestClient.CreateListDeletedNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeletedAppConfigurationStoreResource(Client, DeletedAppConfigurationStoreData.DeserializeDeletedAppConfigurationStoreData(e)), _configurationStoresClientDiagnostics, Pipeline, "DeletedAppConfigurationStoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<NullableResponse<DeletedAppConfigurationStoreResource>> GetIfExistsAsync(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeletedAppConfigurationStoreResource>(response.GetRawResponse());
                return Response.FromValue(new DeletedAppConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual NullableResponse<DeletedAppConfigurationStoreResource> GetIfExists(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeletedAppConfigurationStoreResource>(response.GetRawResponse());
                return Response.FromValue(new DeletedAppConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedAppConfigurationStoreResource> IEnumerable<DeletedAppConfigurationStoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedAppConfigurationStoreResource> IAsyncEnumerable<DeletedAppConfigurationStoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
