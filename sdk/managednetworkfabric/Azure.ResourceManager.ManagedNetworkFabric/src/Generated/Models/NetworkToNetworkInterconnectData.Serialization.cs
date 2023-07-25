// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkToNetworkInterconnectData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NniType))
            {
                writer.WritePropertyName("nniType"u8);
                writer.WriteStringValue(NniType.Value.ToString());
            }
            if (Optional.IsDefined(IsManagementType))
            {
                writer.WritePropertyName("isManagementType"u8);
                writer.WriteStringValue(IsManagementType.Value.ToString());
            }
            if (Optional.IsDefined(UseOptionB))
            {
                writer.WritePropertyName("useOptionB"u8);
                writer.WriteStringValue(UseOptionB.Value.ToString());
            }
            if (Optional.IsDefined(Layer2Configuration))
            {
                writer.WritePropertyName("layer2Configuration"u8);
                writer.WriteObjectValue(Layer2Configuration);
            }
            if (Optional.IsDefined(Layer3Configuration))
            {
                writer.WritePropertyName("layer3Configuration"u8);
                writer.WriteObjectValue(Layer3Configuration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkToNetworkInterconnectData DeserializeNetworkToNetworkInterconnectData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NniType> nniType = default;
            Optional<EnabledDisabledState> administrativeState = default;
            Optional<BooleanEnumProperty> isManagementType = default;
            Optional<BooleanEnumProperty> useOptionB = default;
            Optional<Layer2Configuration> layer2Configuration = default;
            Optional<Layer3Configuration> layer3Configuration = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nniType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nniType = new NniType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new EnabledDisabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isManagementType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isManagementType = new BooleanEnumProperty(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("useOptionB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useOptionB = new BooleanEnumProperty(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("layer2Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            layer2Configuration = Layer2Configuration.DeserializeLayer2Configuration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("layer3Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            layer3Configuration = Layer3Configuration.DeserializeLayer3Configuration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkToNetworkInterconnectData(id, name, type, systemData.Value, Optional.ToNullable(nniType), Optional.ToNullable(administrativeState), Optional.ToNullable(isManagementType), Optional.ToNullable(useOptionB), layer2Configuration.Value, layer3Configuration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
