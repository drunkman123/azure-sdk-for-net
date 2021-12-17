// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class AccessReviewInstanceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartDateTime))
            {
                writer.WritePropertyName("startDateTime");
                writer.WriteStringValue(StartDateTime.Value, "O");
            }
            if (Optional.IsDefined(EndDateTime))
            {
                writer.WritePropertyName("endDateTime");
                writer.WriteStringValue(EndDateTime.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AccessReviewInstanceData DeserializeAccessReviewInstanceData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<AccessReviewInstanceStatus> status = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> endDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new AccessReviewInstanceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AccessReviewInstanceData(id, name, type, Optional.ToNullable(status), Optional.ToNullable(startDateTime), Optional.ToNullable(endDateTime));
        }
    }
}
