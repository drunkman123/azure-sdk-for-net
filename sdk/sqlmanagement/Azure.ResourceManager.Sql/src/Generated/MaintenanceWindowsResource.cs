// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a MaintenanceWindows along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MaintenanceWindowsResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMaintenanceWindowsResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseResource" /> using the GetMaintenanceWindows method.
    /// </summary>
    public partial class MaintenanceWindowsResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MaintenanceWindowsResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindows/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _maintenanceWindowsMaintenanceWindowsClientDiagnostics;
        private readonly MaintenanceWindowsRestOperations _maintenanceWindowsMaintenanceWindowsRestClient;
        private readonly MaintenanceWindowsData _data;

        /// <summary> Initializes a new instance of the <see cref="MaintenanceWindowsResource"/> class for mocking. </summary>
        protected MaintenanceWindowsResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MaintenanceWindowsResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MaintenanceWindowsResource(ArmClient client, MaintenanceWindowsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MaintenanceWindowsResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MaintenanceWindowsResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _maintenanceWindowsMaintenanceWindowsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string maintenanceWindowsMaintenanceWindowsApiVersion);
            _maintenanceWindowsMaintenanceWindowsRestClient = new MaintenanceWindowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, maintenanceWindowsMaintenanceWindowsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/maintenanceWindows";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MaintenanceWindowsData Data
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

        /// <summary>
        /// Gets maintenance windows settings for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceWindows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> is null. </exception>
        public virtual async Task<Response<MaintenanceWindowsResource>> GetAsync(string maintenanceWindowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));

            using var scope = _maintenanceWindowsMaintenanceWindowsClientDiagnostics.CreateScope("MaintenanceWindowsResource.Get");
            scope.Start();
            try
            {
                var response = await _maintenanceWindowsMaintenanceWindowsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceWindowsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets maintenance windows settings for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceWindows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> is null. </exception>
        public virtual Response<MaintenanceWindowsResource> Get(string maintenanceWindowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));

            using var scope = _maintenanceWindowsMaintenanceWindowsClientDiagnostics.CreateScope("MaintenanceWindowsResource.Get");
            scope.Start();
            try
            {
                var response = _maintenanceWindowsMaintenanceWindowsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceWindowsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets maintenance windows settings for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceWindows_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="data"> The MaintenanceWindows to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string maintenanceWindowName, MaintenanceWindowsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _maintenanceWindowsMaintenanceWindowsClientDiagnostics.CreateScope("MaintenanceWindowsResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _maintenanceWindowsMaintenanceWindowsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(response);
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
        /// Sets maintenance windows settings for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindows/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceWindows_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="maintenanceWindowName"> Maintenance window name. </param>
        /// <param name="data"> The MaintenanceWindows to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string maintenanceWindowName, MaintenanceWindowsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowName, nameof(maintenanceWindowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _maintenanceWindowsMaintenanceWindowsClientDiagnostics.CreateScope("MaintenanceWindowsResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _maintenanceWindowsMaintenanceWindowsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowName, data, cancellationToken);
                var operation = new SqlArmOperation(response);
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
    }
}
