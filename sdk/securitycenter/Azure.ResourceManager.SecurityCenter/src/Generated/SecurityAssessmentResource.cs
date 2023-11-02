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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecurityAssessment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SecurityAssessmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSecurityAssessmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetSecurityAssessment method.
    /// </summary>
    public partial class SecurityAssessmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityAssessmentResource"/> instance. </summary>
        /// <param name="resourceId"> The resourceId. </param>
        /// <param name="assessmentName"> The assessmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceId, string assessmentName)
        {
            var resourceId0 = $"{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _securityAssessmentAssessmentsClientDiagnostics;
        private readonly AssessmentsRestOperations _securityAssessmentAssessmentsRestClient;
        private readonly SecurityAssessmentData _data;

        /// <summary> Initializes a new instance of the <see cref="SecurityAssessmentResource"/> class for mocking. </summary>
        protected SecurityAssessmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SecurityAssessmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityAssessmentResource(ArmClient client, SecurityAssessmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityAssessmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityAssessmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityAssessmentAssessmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityAssessmentAssessmentsApiVersion);
            _securityAssessmentAssessmentsRestClient = new AssessmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityAssessmentAssessmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/assessments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityAssessmentData Data
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

        /// <summary> Gets a collection of SecuritySubAssessmentResources in the SecurityAssessment. </summary>
        /// <returns> An object representing collection of SecuritySubAssessmentResources and their operations over a SecuritySubAssessmentResource. </returns>
        public virtual SecuritySubAssessmentCollection GetSecuritySubAssessments()
        {
            return GetCachedClient(Client => new SecuritySubAssessmentCollection(Client, Id));
        }

        /// <summary>
        /// Get a security sub-assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecuritySubAssessmentResource>> GetSecuritySubAssessmentAsync(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            return await GetSecuritySubAssessments().GetAsync(subAssessmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a security sub-assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecuritySubAssessmentResource> GetSecuritySubAssessment(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            return GetSecuritySubAssessments().Get(subAssessmentName, cancellationToken);
        }

        /// <summary> Gets a collection of GovernanceAssignmentResources in the SecurityAssessment. </summary>
        /// <returns> An object representing collection of GovernanceAssignmentResources and their operations over a GovernanceAssignmentResource. </returns>
        public virtual GovernanceAssignmentCollection GetGovernanceAssignments()
        {
            return GetCachedClient(Client => new GovernanceAssignmentCollection(Client, Id));
        }

        /// <summary>
        /// Get a specific governanceAssignment for the requested scope by AssignmentKey
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/governanceAssignments/{assignmentKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentKey"> The governance assignment key - the assessment key of the required governance assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentKey"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<GovernanceAssignmentResource>> GetGovernanceAssignmentAsync(string assignmentKey, CancellationToken cancellationToken = default)
        {
            return await GetGovernanceAssignments().GetAsync(assignmentKey, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific governanceAssignment for the requested scope by AssignmentKey
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/governanceAssignments/{assignmentKey}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GovernanceAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentKey"> The governance assignment key - the assessment key of the required governance assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentKey"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentKey"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<GovernanceAssignmentResource> GetGovernanceAssignment(string assignmentKey, CancellationToken cancellationToken = default)
        {
            return GetGovernanceAssignments().Get(assignmentKey, cancellationToken);
        }

        /// <summary>
        /// Get a security assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityAssessmentResource>> GetAsync(SecurityAssessmentODataExpand? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _securityAssessmentAssessmentsClientDiagnostics.CreateScope("SecurityAssessmentResource.Get");
            scope.Start();
            try
            {
                var response = await _securityAssessmentAssessmentsRestClient.GetAsync(Id.Parent, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a security assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assessments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityAssessmentResource> Get(SecurityAssessmentODataExpand? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _securityAssessmentAssessmentsClientDiagnostics.CreateScope("SecurityAssessmentResource.Get");
            scope.Start();
            try
            {
                var response = _securityAssessmentAssessmentsRestClient.Get(Id.Parent, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assessments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityAssessmentAssessmentsClientDiagnostics.CreateScope("SecurityAssessmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _securityAssessmentAssessmentsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Delete a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assessments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityAssessmentAssessmentsClientDiagnostics.CreateScope("SecurityAssessmentResource.Delete");
            scope.Start();
            try
            {
                var response = _securityAssessmentAssessmentsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
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
        /// Create a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assessments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Calculated assessment on a pre-defined assessment metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityAssessmentResource>> UpdateAsync(WaitUntil waitUntil, SecurityAssessmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _securityAssessmentAssessmentsClientDiagnostics.CreateScope("SecurityAssessmentResource.Update");
            scope.Start();
            try
            {
                var response = await _securityAssessmentAssessmentsRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityAssessmentResource>(Response.FromValue(new SecurityAssessmentResource(Client, response), response.GetRawResponse()));
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
        /// Create a security assessment on your resource. An assessment metadata that describes this assessment must be predefined with the same name before inserting the assessment result
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/assessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assessments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Calculated assessment on a pre-defined assessment metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SecurityAssessmentResource> Update(WaitUntil waitUntil, SecurityAssessmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _securityAssessmentAssessmentsClientDiagnostics.CreateScope("SecurityAssessmentResource.Update");
            scope.Start();
            try
            {
                var response = _securityAssessmentAssessmentsRestClient.CreateOrUpdate(Id.Parent, Id.Name, content, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityAssessmentResource>(Response.FromValue(new SecurityAssessmentResource(Client, response), response.GetRawResponse()));
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
