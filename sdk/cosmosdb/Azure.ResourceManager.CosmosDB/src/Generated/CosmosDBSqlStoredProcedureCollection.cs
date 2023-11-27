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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBSqlStoredProcedureResource"/> and their operations.
    /// Each <see cref="CosmosDBSqlStoredProcedureResource"/> in the collection will belong to the same instance of <see cref="CosmosDBSqlContainerResource"/>.
    /// To get a <see cref="CosmosDBSqlStoredProcedureCollection"/> instance call the GetCosmosDBSqlStoredProcedures method from an instance of <see cref="CosmosDBSqlContainerResource"/>.
    /// </summary>
    public partial class CosmosDBSqlStoredProcedureCollection : ArmCollection, IEnumerable<CosmosDBSqlStoredProcedureResource>, IAsyncEnumerable<CosmosDBSqlStoredProcedureResource>
    {
        private readonly ClientDiagnostics _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlStoredProcedureSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlStoredProcedureCollection"/> class for mocking. </summary>
        protected CosmosDBSqlStoredProcedureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlStoredProcedureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBSqlStoredProcedureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBSqlStoredProcedureResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBSqlStoredProcedureResource.ResourceType, out string cosmosDBSqlStoredProcedureSqlResourcesApiVersion);
            _cosmosDBSqlStoredProcedureSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlStoredProcedureSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBSqlContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBSqlContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB SQL storedProcedure
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="content"> The parameters to provide for the current SQL storedProcedure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlStoredProcedureResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storedProcedureName, CosmosDBSqlStoredProcedureCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlStoredProcedureSqlResourcesRestClient.CreateUpdateSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlStoredProcedureResource>(new CosmosDBSqlStoredProcedureOperationSource(Client), _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlStoredProcedureSqlResourcesRestClient.CreateCreateUpdateSqlStoredProcedureRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB SQL storedProcedure
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="content"> The parameters to provide for the current SQL storedProcedure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlStoredProcedureResource> CreateOrUpdate(WaitUntil waitUntil, string storedProcedureName, CosmosDBSqlStoredProcedureCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlStoredProcedureSqlResourcesRestClient.CreateUpdateSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlStoredProcedureResource>(new CosmosDBSqlStoredProcedureOperationSource(Client), _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlStoredProcedureSqlResourcesRestClient.CreateCreateUpdateSqlStoredProcedureRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the SQL storedProcedure under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBSqlStoredProcedureResource>> GetAsync(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlStoredProcedureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SQL storedProcedure under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual Response<CosmosDBSqlStoredProcedureResource> Get(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlStoredProcedureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the SQL storedProcedure under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlStoredProcedures</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBSqlStoredProcedureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBSqlStoredProcedureResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlStoredProcedureSqlResourcesRestClient.CreateListSqlStoredProceduresRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBSqlStoredProcedureResource(Client, CosmosDBSqlStoredProcedureData.DeserializeCosmosDBSqlStoredProcedureData(e)), _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlStoredProcedureCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the SQL storedProcedure under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlStoredProcedures</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBSqlStoredProcedureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBSqlStoredProcedureResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlStoredProcedureSqlResourcesRestClient.CreateListSqlStoredProceduresRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBSqlStoredProcedureResource(Client, CosmosDBSqlStoredProcedureData.DeserializeCosmosDBSqlStoredProcedureData(e)), _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlStoredProcedureCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual Response<bool> Exists(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBSqlStoredProcedureResource>> GetIfExistsAsync(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlStoredProcedureResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlStoredProcedureResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/storedProcedures/{storedProcedureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlStoredProcedure</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBSqlStoredProcedureResource> GetIfExists(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _cosmosDBSqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlStoredProcedureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBSqlStoredProcedureResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlStoredProcedureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBSqlStoredProcedureResource> IEnumerable<CosmosDBSqlStoredProcedureResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBSqlStoredProcedureResource> IAsyncEnumerable<CosmosDBSqlStoredProcedureResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
