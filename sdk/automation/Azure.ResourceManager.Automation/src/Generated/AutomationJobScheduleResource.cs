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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A Class representing an AutomationJobSchedule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutomationJobScheduleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutomationJobScheduleResource method.
    /// Otherwise you can get one from its parent resource <see cref="AutomationAccountResource"/> using the GetAutomationJobSchedule method.
    /// </summary>
    public partial class AutomationJobScheduleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutomationJobScheduleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="automationAccountName"> The automationAccountName. </param>
        /// <param name="jobScheduleId"> The jobScheduleId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string automationAccountName, Guid jobScheduleId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _automationJobScheduleJobScheduleClientDiagnostics;
        private readonly JobScheduleRestOperations _automationJobScheduleJobScheduleRestClient;
        private readonly AutomationJobScheduleData _data;

        /// <summary> Initializes a new instance of the <see cref="AutomationJobScheduleResource"/> class for mocking. </summary>
        protected AutomationJobScheduleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationJobScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutomationJobScheduleResource(ArmClient client, AutomationJobScheduleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationJobScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomationJobScheduleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationJobScheduleJobScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string automationJobScheduleJobScheduleApiVersion);
            _automationJobScheduleJobScheduleRestClient = new JobScheduleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationJobScheduleJobScheduleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Automation/automationAccounts/jobSchedules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutomationJobScheduleData Data
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
        /// Retrieve the job schedule identified by job schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutomationJobScheduleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleResource.Get");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the job schedule identified by job schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutomationJobScheduleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleResource.Get");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationJobScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the job schedule identified by job schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleResource.Delete");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation(response);
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
        /// Delete the job schedule identified by job schedule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleResource.Delete");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                var operation = new AutomationArmOperation(response);
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
        /// Create a job schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters supplied to the create job schedule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationJobScheduleResource>> UpdateAsync(WaitUntil waitUntil, AutomationJobScheduleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleResource.Update");
            scope.Start();
            try
            {
                var response = await _automationJobScheduleJobScheduleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationJobScheduleResource>(Response.FromValue(new AutomationJobScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Create a job schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/jobSchedules/{jobScheduleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobSchedule_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters supplied to the create job schedule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationJobScheduleResource> Update(WaitUntil waitUntil, AutomationJobScheduleCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationJobScheduleJobScheduleClientDiagnostics.CreateScope("AutomationJobScheduleResource.Update");
            scope.Start();
            try
            {
                var response = _automationJobScheduleJobScheduleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationJobScheduleResource>(Response.FromValue(new AutomationJobScheduleResource(Client, response), response.GetRawResponse()));
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
