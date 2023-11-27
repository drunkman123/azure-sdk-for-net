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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="PredictionResourceFormatResource"/> and their operations.
    /// Each <see cref="PredictionResourceFormatResource"/> in the collection will belong to the same instance of <see cref="HubResource"/>.
    /// To get a <see cref="PredictionResourceFormatCollection"/> instance call the GetPredictionResourceFormats method from an instance of <see cref="HubResource"/>.
    /// </summary>
    public partial class PredictionResourceFormatCollection : ArmCollection, IEnumerable<PredictionResourceFormatResource>, IAsyncEnumerable<PredictionResourceFormatResource>
    {
        private readonly ClientDiagnostics _predictionResourceFormatPredictionsClientDiagnostics;
        private readonly PredictionsRestOperations _predictionResourceFormatPredictionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PredictionResourceFormatCollection"/> class for mocking. </summary>
        protected PredictionResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PredictionResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PredictionResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _predictionResourceFormatPredictionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", PredictionResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PredictionResourceFormatResource.ResourceType, out string predictionResourceFormatPredictionsApiVersion);
            _predictionResourceFormatPredictionsRestClient = new PredictionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, predictionResourceFormatPredictionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Prediction or updates an existing Prediction in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="data"> Parameters supplied to the create/update Prediction operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PredictionResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string predictionName, PredictionResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _predictionResourceFormatPredictionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<PredictionResourceFormatResource>(new PredictionResourceFormatOperationSource(Client), _predictionResourceFormatPredictionsClientDiagnostics, Pipeline, _predictionResourceFormatPredictionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a Prediction or updates an existing Prediction in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="data"> Parameters supplied to the create/update Prediction operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PredictionResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string predictionName, PredictionResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _predictionResourceFormatPredictionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<PredictionResourceFormatResource>(new PredictionResourceFormatOperationSource(Client), _predictionResourceFormatPredictionsClientDiagnostics, Pipeline, _predictionResourceFormatPredictionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a Prediction in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> is null. </exception>
        public virtual async Task<Response<PredictionResourceFormatResource>> GetAsync(string predictionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _predictionResourceFormatPredictionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PredictionResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Prediction in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> is null. </exception>
        public virtual Response<PredictionResourceFormatResource> Get(string predictionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _predictionResourceFormatPredictionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PredictionResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the predictions in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PredictionResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PredictionResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _predictionResourceFormatPredictionsRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _predictionResourceFormatPredictionsRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PredictionResourceFormatResource(Client, PredictionResourceFormatData.DeserializePredictionResourceFormatData(e)), _predictionResourceFormatPredictionsClientDiagnostics, Pipeline, "PredictionResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the predictions in the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_ListByHub</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PredictionResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PredictionResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _predictionResourceFormatPredictionsRestClient.CreateListByHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _predictionResourceFormatPredictionsRestClient.CreateListByHubNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PredictionResourceFormatResource(Client, PredictionResourceFormatData.DeserializePredictionResourceFormatData(e)), _predictionResourceFormatPredictionsClientDiagnostics, Pipeline, "PredictionResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string predictionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _predictionResourceFormatPredictionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> is null. </exception>
        public virtual Response<bool> Exists(string predictionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _predictionResourceFormatPredictionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> is null. </exception>
        public virtual async Task<NullableResponse<PredictionResourceFormatResource>> GetIfExistsAsync(string predictionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _predictionResourceFormatPredictionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PredictionResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new PredictionResourceFormatResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/predictions/{predictionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Predictions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="predictionName"> The name of the Prediction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predictionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predictionName"/> is null. </exception>
        public virtual NullableResponse<PredictionResourceFormatResource> GetIfExists(string predictionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predictionName, nameof(predictionName));

            using var scope = _predictionResourceFormatPredictionsClientDiagnostics.CreateScope("PredictionResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _predictionResourceFormatPredictionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, predictionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PredictionResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new PredictionResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PredictionResourceFormatResource> IEnumerable<PredictionResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PredictionResourceFormatResource> IAsyncEnumerable<PredictionResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
