// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SyncGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SyncGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSyncGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseResource"/> using the GetSyncGroup method.
    /// </summary>
    public partial class SyncGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SyncGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="syncGroupName"> The syncGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string syncGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _syncGroupClientDiagnostics;
        private readonly SyncGroupsRestOperations _syncGroupRestClient;
        private readonly SyncGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="SyncGroupResource"/> class for mocking. </summary>
        protected SyncGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SyncGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SyncGroupResource(ArmClient client, SyncGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SyncGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SyncGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string syncGroupApiVersion);
            _syncGroupRestClient = new SyncGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, syncGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/syncGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SyncGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SyncMemberResources in the SyncGroup. </summary>
        /// <returns> An object representing collection of SyncMemberResources and their operations over a SyncMemberResource. </returns>
        public virtual SyncMemberCollection GetSyncMembers()
        {
            return GetCachedClient(client => new SyncMemberCollection(client, Id));
        }

        /// <summary>
        /// Gets a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SyncMemberResource>> GetSyncMemberAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            return await GetSyncMembers().GetAsync(syncMemberName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SyncMemberResource> GetSyncMember(string syncMemberName, CancellationToken cancellationToken = default)
        {
            return GetSyncMembers().Get(syncMemberName, cancellationToken);
        }

        /// <summary>
        /// Gets a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SyncGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SyncGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.Get");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SyncGroupResource>> UpdateAsync(WaitUntil waitUntil, SyncGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncGroupResource>(new SyncGroupOperationSource(Client), _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested sync group resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SyncGroupResource> Update(WaitUntil waitUntil, SyncGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.Update");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<SyncGroupResource>(new SyncGroupOperationSource(Client), _syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Refreshes a hub database schema.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/refreshHubSchema</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_RefreshHubSchema</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> RefreshHubSchemaAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.RefreshHubSchema");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.RefreshHubSchemaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateRefreshHubSchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refreshes a hub database schema.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/refreshHubSchema</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_RefreshHubSchema</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation RefreshHubSchema(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.RefreshHubSchema");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.RefreshHubSchema(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_syncGroupClientDiagnostics, Pipeline, _syncGroupRestClient.CreateRefreshHubSchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a collection of hub database schemas.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/hubSchemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_ListHubSchemas</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncFullSchemaProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncFullSchemaProperties> GetHubSchemasAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncGroupRestClient.CreateListHubSchemasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncGroupRestClient.CreateListHubSchemasNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SyncFullSchemaProperties.DeserializeSyncFullSchemaProperties, _syncGroupClientDiagnostics, Pipeline, "SyncGroupResource.GetHubSchemas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a collection of hub database schemas.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/hubSchemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_ListHubSchemas</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncFullSchemaProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncFullSchemaProperties> GetHubSchemas(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncGroupRestClient.CreateListHubSchemasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncGroupRestClient.CreateListHubSchemasNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SyncFullSchemaProperties.DeserializeSyncFullSchemaProperties, _syncGroupClientDiagnostics, Pipeline, "SyncGroupResource.GetHubSchemas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a collection of sync group logs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/logs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_ListLogs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startTime"> Get logs generated after this time. </param>
        /// <param name="endTime"> Get logs generated before this time. </param>
        /// <param name="type"> The types of logs to retrieve. </param>
        /// <param name="continuationToken"> The continuation token for this operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startTime"/> or <paramref name="endTime"/> is null. </exception>
        /// <returns> An async collection of <see cref="SyncGroupLogProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncGroupLogProperties> GetLogsAsync(string startTime, string endTime, SyncGroupLogType type, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(startTime, nameof(startTime));
            Argument.AssertNotNull(endTime, nameof(endTime));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncGroupRestClient.CreateListLogsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncGroupRestClient.CreateListLogsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SyncGroupLogProperties.DeserializeSyncGroupLogProperties, _syncGroupClientDiagnostics, Pipeline, "SyncGroupResource.GetLogs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a collection of sync group logs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/logs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_ListLogs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startTime"> Get logs generated after this time. </param>
        /// <param name="endTime"> Get logs generated before this time. </param>
        /// <param name="type"> The types of logs to retrieve. </param>
        /// <param name="continuationToken"> The continuation token for this operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startTime"/> or <paramref name="endTime"/> is null. </exception>
        /// <returns> A collection of <see cref="SyncGroupLogProperties"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncGroupLogProperties> GetLogs(string startTime, string endTime, SyncGroupLogType type, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(startTime, nameof(startTime));
            Argument.AssertNotNull(endTime, nameof(endTime));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncGroupRestClient.CreateListLogsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncGroupRestClient.CreateListLogsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, type, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SyncGroupLogProperties.DeserializeSyncGroupLogProperties, _syncGroupClientDiagnostics, Pipeline, "SyncGroupResource.GetLogs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Cancels a sync group synchronization.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/cancelSync</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_CancelSync</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelSyncAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.CancelSync");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.CancelSyncAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a sync group synchronization.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/cancelSync</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_CancelSync</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelSync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.CancelSync");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.CancelSync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Triggers a sync group synchronization.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/triggerSync</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_TriggerSync</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> TriggerSyncAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.TriggerSync");
            scope.Start();
            try
            {
                var response = await _syncGroupRestClient.TriggerSyncAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Triggers a sync group synchronization.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/triggerSync</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncGroups_TriggerSync</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response TriggerSync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncGroupClientDiagnostics.CreateScope("SyncGroupResource.TriggerSync");
            scope.Start();
            try
            {
                var response = _syncGroupRestClient.TriggerSync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
