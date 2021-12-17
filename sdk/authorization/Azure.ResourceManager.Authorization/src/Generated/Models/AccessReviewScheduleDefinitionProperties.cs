// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Access Review. </summary>
    public partial class AccessReviewScheduleDefinitionProperties
    {
        /// <summary> Initializes a new instance of AccessReviewScheduleDefinitionProperties. </summary>
        public AccessReviewScheduleDefinitionProperties()
        {
            Reviewers = new ChangeTrackingList<AccessReviewReviewer>();
            Instances = new ChangeTrackingList<AccessReviewInstanceData>();
        }

        /// <summary> The display name for the schedule definition. </summary>
        public string DisplayName { get; set; }
        /// <summary> This read-only field specifies the status of an accessReview. </summary>
        public AccessReviewScheduleDefinitionStatus? Status { get; }
        /// <summary> The description provided by the access review creator and visible to admins. </summary>
        public string DescriptionForAdmins { get; set; }
        /// <summary> The description provided by the access review creator to be shown to reviewers. </summary>
        public string DescriptionForReviewers { get; set; }
        /// <summary> This is the collection of reviewers. </summary>
        public IList<AccessReviewReviewer> Reviewers { get; }
        /// <summary> This field specifies the type of reviewers for a review. Usually for a review, reviewers are explicitly assigned. However, in some cases, the reviewers may not be assigned and instead be chosen dynamically. For example managers review or self review. </summary>
        public AccessReviewScheduleDefinitionReviewersType? ReviewersType { get; }
        /// <summary> This is the collection of instances returned when one does an expand on it. </summary>
        public IList<AccessReviewInstanceData> Instances { get; }
        /// <summary> ResourceId in which this review is getting created. </summary>
        public string ResourceId { get; }
        /// <summary> This is used to indicate the role being reviewed. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The identity type user/servicePrincipal to review. </summary>
        public AccessReviewScopePrincipalType? PrincipalTypeScopePrincipalType { get; }
        /// <summary> Flag to indicate whether sending mails to reviewers and the review creator is enabled. </summary>
        public bool? MailNotificationsEnabled { get; set; }
        /// <summary> Flag to indicate whether sending reminder emails to reviewers are enabled. </summary>
        public bool? ReminderNotificationsEnabled { get; set; }
        /// <summary> Flag to indicate whether reviewers are required to provide a justification when reviewing access. </summary>
        public bool? DefaultDecisionEnabled { get; set; }
        /// <summary> Flag to indicate whether the reviewer is required to pass justification when recording a decision. </summary>
        public bool? JustificationRequiredOnApproval { get; set; }
        /// <summary> This specifies the behavior for the autoReview feature when an access review completes. </summary>
        public DefaultDecisionType? DefaultDecision { get; set; }
        /// <summary> Flag to indicate whether auto-apply capability, to automatically change the target object access resource, is enabled. If not enabled, a user must, after the review completes, apply the access review. </summary>
        public bool? AutoApplyDecisionsEnabled { get; set; }
        /// <summary> Flag to indicate whether showing recommendations to reviewers is enabled. </summary>
        public bool? RecommendationsEnabled { get; set; }
        /// <summary> The duration in days for an instance. </summary>
        public int? InstanceDurationInDays { get; set; }
        /// <summary> The recurrence range type. The possible values are: endDate, noEnd, numbered. </summary>
        public AccessReviewRecurrenceRangeType? TypeSettingsRecurrenceRangeType { get; set; }
        /// <summary> The number of times to repeat the access review. Required and must be positive if type is numbered. </summary>
        public int? NumberOfOccurrences { get; set; }
        /// <summary> The DateTime when the review is scheduled to be start. This could be a date in the future. Required on create. </summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary> The DateTime when the review is scheduled to end. Required if type is endDate. </summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary> The recurrence type : weekly, monthly, etc. </summary>
        public AccessReviewRecurrencePatternType? TypeSettingsRecurrencePatternType { get; set; }
        /// <summary> The interval for recurrence. For a quarterly review, the interval is 3 for type : absoluteMonthly. </summary>
        public int? Interval { get; set; }
        /// <summary> The identity id. </summary>
        public string PrincipalId { get; }
        /// <summary> The identity type : user/servicePrincipal. </summary>
        public AccessReviewActorIdentityType? PrincipalTypeCreatedByPrincipalType { get; }
        /// <summary> The identity display name. </summary>
        public string PrincipalName { get; }
        /// <summary> The user principal name(if valid). </summary>
        public string UserPrincipalName { get; }
    }
}
