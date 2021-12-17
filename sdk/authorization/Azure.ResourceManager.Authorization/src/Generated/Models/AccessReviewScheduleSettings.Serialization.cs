// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class AccessReviewScheduleSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MailNotificationsEnabled))
            {
                writer.WritePropertyName("mailNotificationsEnabled");
                writer.WriteBooleanValue(MailNotificationsEnabled.Value);
            }
            if (Optional.IsDefined(ReminderNotificationsEnabled))
            {
                writer.WritePropertyName("reminderNotificationsEnabled");
                writer.WriteBooleanValue(ReminderNotificationsEnabled.Value);
            }
            if (Optional.IsDefined(DefaultDecisionEnabled))
            {
                writer.WritePropertyName("defaultDecisionEnabled");
                writer.WriteBooleanValue(DefaultDecisionEnabled.Value);
            }
            if (Optional.IsDefined(JustificationRequiredOnApproval))
            {
                writer.WritePropertyName("justificationRequiredOnApproval");
                writer.WriteBooleanValue(JustificationRequiredOnApproval.Value);
            }
            if (Optional.IsDefined(DefaultDecision))
            {
                writer.WritePropertyName("defaultDecision");
                writer.WriteStringValue(DefaultDecision.Value.ToString());
            }
            if (Optional.IsDefined(AutoApplyDecisionsEnabled))
            {
                writer.WritePropertyName("autoApplyDecisionsEnabled");
                writer.WriteBooleanValue(AutoApplyDecisionsEnabled.Value);
            }
            if (Optional.IsDefined(RecommendationsEnabled))
            {
                writer.WritePropertyName("recommendationsEnabled");
                writer.WriteBooleanValue(RecommendationsEnabled.Value);
            }
            if (Optional.IsDefined(InstanceDurationInDays))
            {
                writer.WritePropertyName("instanceDurationInDays");
                writer.WriteNumberValue(InstanceDurationInDays.Value);
            }
            writer.WritePropertyName("recurrence");
            writer.WriteStartObject();
            writer.WritePropertyName("range");
            writer.WriteStartObject();
            if (Optional.IsDefined(TypeRecurrenceRangeType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypeRecurrenceRangeType.Value.ToString());
            }
            if (Optional.IsDefined(NumberOfOccurrences))
            {
                writer.WritePropertyName("numberOfOccurrences");
                writer.WriteNumberValue(NumberOfOccurrences.Value);
            }
            if (Optional.IsDefined(StartDate))
            {
                if (StartDate != null)
                {
                    writer.WritePropertyName("startDate");
                    writer.WriteStringValue(StartDate.Value, "O");
                }
                else
                {
                    writer.WriteNull("startDate");
                }
            }
            if (Optional.IsDefined(EndDate))
            {
                if (EndDate != null)
                {
                    writer.WritePropertyName("endDate");
                    writer.WriteStringValue(EndDate.Value, "O");
                }
                else
                {
                    writer.WriteNull("endDate");
                }
            }
            writer.WriteEndObject();
            writer.WritePropertyName("pattern");
            writer.WriteStartObject();
            if (Optional.IsDefined(TypeRecurrencePatternType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypeRecurrencePatternType.Value.ToString());
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval");
                writer.WriteNumberValue(Interval.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
