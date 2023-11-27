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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a CustomAssessmentAutomation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CustomAssessmentAutomationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCustomAssessmentAutomationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetCustomAssessmentAutomation method.
    /// </summary>
    public partial class CustomAssessmentAutomationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CustomAssessmentAutomationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="customAssessmentAutomationName"> The customAssessmentAutomationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string customAssessmentAutomationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _customAssessmentAutomationClientDiagnostics;
        private readonly CustomAssessmentAutomationsRestOperations _customAssessmentAutomationRestClient;
        private readonly CustomAssessmentAutomationData _data;

        /// <summary> Initializes a new instance of the <see cref="CustomAssessmentAutomationResource"/> class for mocking. </summary>
        protected CustomAssessmentAutomationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomAssessmentAutomationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CustomAssessmentAutomationResource(ArmClient client, CustomAssessmentAutomationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CustomAssessmentAutomationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CustomAssessmentAutomationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customAssessmentAutomationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string customAssessmentAutomationApiVersion);
            _customAssessmentAutomationRestClient = new CustomAssessmentAutomationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customAssessmentAutomationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/customAssessmentAutomations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CustomAssessmentAutomationData Data
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
        /// Gets a single custom assessment automation by name for the provided subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CustomAssessmentAutomationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationResource.Get");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomAssessmentAutomationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a single custom assessment automation by name for the provided subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CustomAssessmentAutomationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationResource.Get");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomAssessmentAutomationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a custom assessment automation by name for a provided subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationResource.Delete");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Deletes a custom assessment automation by name for a provided subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationResource.Delete");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Creates or updates a custom assessment automation for the provided subscription. Please note that providing an existing custom assessment automation will replace the existing record.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Custom Assessment Automation body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CustomAssessmentAutomationResource>> UpdateAsync(WaitUntil waitUntil, CustomAssessmentAutomationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationResource.Update");
            scope.Start();
            try
            {
                var response = await _customAssessmentAutomationRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<CustomAssessmentAutomationResource>(Response.FromValue(new CustomAssessmentAutomationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a custom assessment automation for the provided subscription. Please note that providing an existing custom assessment automation will replace the existing record.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customAssessmentAutomations/{customAssessmentAutomationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomAssessmentAutomations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Custom Assessment Automation body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CustomAssessmentAutomationResource> Update(WaitUntil waitUntil, CustomAssessmentAutomationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _customAssessmentAutomationClientDiagnostics.CreateScope("CustomAssessmentAutomationResource.Update");
            scope.Start();
            try
            {
                var response = _customAssessmentAutomationRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, content, cancellationToken);
                var operation = new SecurityCenterArmOperation<CustomAssessmentAutomationResource>(Response.FromValue(new CustomAssessmentAutomationResource(Client, response), response.GetRawResponse()));
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
    }
}
