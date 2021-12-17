// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Authorization;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Creates a role eligibility schedule request. </summary>
    public partial class RoleEligibilityScheduleRequestCreateOperation : Operation<RoleEligibilityScheduleRequest>
    {
        private readonly OperationOrResponseInternals<RoleEligibilityScheduleRequest> _operation;

        /// <summary> Initializes a new instance of RoleEligibilityScheduleRequestCreateOperation for mocking. </summary>
        protected RoleEligibilityScheduleRequestCreateOperation()
        {
        }

        internal RoleEligibilityScheduleRequestCreateOperation(ArmResource operationsBase, Response<RoleEligibilityScheduleRequestData> response)
        {
            _operation = new OperationOrResponseInternals<RoleEligibilityScheduleRequest>(Response.FromValue(new RoleEligibilityScheduleRequest(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override RoleEligibilityScheduleRequest Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RoleEligibilityScheduleRequest>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RoleEligibilityScheduleRequest>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
