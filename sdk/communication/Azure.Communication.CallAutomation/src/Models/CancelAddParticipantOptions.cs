// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The Cancel add participants operation options.
    /// </summary>
    public class CancelAddParticipantOptions
    {
        /// <summary>
        /// Creates a new CancelAddParticipantOptions object.
        /// </summary>
        /// <param name="invitationId"></param>
        public CancelAddParticipantOptions(string invitationId)
        {
            InvitationId = invitationId;
        }

        /// <summary>
        /// Invitation ID used to add a participant.
        /// </summary>
        public string InvitationId { get; }

        /// <summary>
        /// The operationContext for this add participants call.
        /// </summary>
        public string OperationContext { get; set; }

        /// <summary>
        /// The callback URI to override the main callback URI.
        /// </summary>
        public string OverrideCallbackUrl { get; set; }
    }
}
