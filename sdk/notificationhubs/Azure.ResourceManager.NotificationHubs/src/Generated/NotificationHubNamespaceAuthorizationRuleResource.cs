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
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary>
    /// A Class representing a NotificationHubNamespaceAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NotificationHubNamespaceAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNotificationHubNamespaceAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="NotificationHubNamespaceResource" /> using the GetNotificationHubNamespaceAuthorizationRule method.
    /// </summary>
    public partial class NotificationHubNamespaceAuthorizationRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NotificationHubNamespaceAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _notificationHubNamespaceAuthorizationRuleNamespacesRestClient;
        private readonly NotificationHubAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="NotificationHubNamespaceAuthorizationRuleResource"/> class for mocking. </summary>
        protected NotificationHubNamespaceAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NotificationHubNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NotificationHubNamespaceAuthorizationRuleResource(ArmClient client, NotificationHubAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NotificationHubNamespaceAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NotificationHubNamespaceAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NotificationHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string notificationHubNamespaceAuthorizationRuleNamespacesApiVersion);
            _notificationHubNamespaceAuthorizationRuleNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationHubNamespaceAuthorizationRuleNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NotificationHubs/namespaces/AuthorizationRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NotificationHubAuthorizationRuleData Data
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
        /// Gets an authorization rule for a namespace by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NotificationHubNamespaceAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationHubNamespaceAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_GetAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NotificationHubNamespaceAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationHubNamespaceAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a namespace authorization rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_DeleteAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.DeleteAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NotificationHubsArmOperation(response);
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
        /// Deletes a namespace authorization rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_DeleteAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.DeleteAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NotificationHubsArmOperation(response);
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
        /// Creates an authorization rule for a namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<NotificationHubNamespaceAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new NotificationHubsArmOperation<NotificationHubNamespaceAuthorizationRuleResource>(Response.FromValue(new NotificationHubNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization rule for a namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CreateOrUpdateAuthorizationRule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<NotificationHubNamespaceAuthorizationRuleResource> Update(WaitUntil waitUntil, SharedAccessAuthorizationRuleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new NotificationHubsArmOperation<NotificationHubNamespaceAuthorizationRuleResource>(Response.FromValue(new NotificationHubNamespaceAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the Primary and Secondary ConnectionStrings to the namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListKeys</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NotificationHubResourceKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Primary and Secondary ConnectionStrings to the namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/listKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_ListKeys</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NotificationHubResourceKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the Primary/Secondary Keys to the Namespace Authorization Rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/regenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_RegenerateKeys</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the Namespace Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        public virtual async Task<Response<NotificationHubResourceKeys>> RegenerateKeysAsync(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(notificationHubPolicyKey, nameof(notificationHubPolicyKey));

            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, notificationHubPolicyKey, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the Primary/Secondary Keys to the Namespace Authorization Rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}/regenerateKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_RegenerateKeys</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationHubPolicyKey"> Parameters supplied to regenerate the Namespace Authorization Rule Key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubPolicyKey"/> is null. </exception>
        public virtual Response<NotificationHubResourceKeys> RegenerateKeys(NotificationHubPolicyKey notificationHubPolicyKey, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(notificationHubPolicyKey, nameof(notificationHubPolicyKey));

            using var scope = _notificationHubNamespaceAuthorizationRuleNamespacesClientDiagnostics.CreateScope("NotificationHubNamespaceAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _notificationHubNamespaceAuthorizationRuleNamespacesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, notificationHubPolicyKey, cancellationToken);
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
