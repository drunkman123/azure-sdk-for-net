// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkRackSkuData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("roleName"u8);
            writer.WriteStringValue(RoleName.ToString());
            if (Optional.IsDefined(MaximumServerCount))
            {
                writer.WritePropertyName("maximumServerCount"u8);
                writer.WriteNumberValue(MaximumServerCount.Value);
            }
            if (Optional.IsDefined(MaximumStorageCount))
            {
                writer.WritePropertyName("maximumStorageCount"u8);
                writer.WriteNumberValue(MaximumStorageCount.Value);
            }
            if (Optional.IsDefined(MaximumUplinks))
            {
                writer.WritePropertyName("maximumUplinks"u8);
                writer.WriteNumberValue(MaximumUplinks.Value);
            }
            if (Optional.IsCollectionDefined(NetworkDevices))
            {
                writer.WritePropertyName("networkDevices"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkDevices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkRackSkuData DeserializeNetworkRackSkuData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            NetworkRackRoleName roleName = default;
            Optional<int> maximumServerCount = default;
            Optional<int> maximumStorageCount = default;
            Optional<int> maximumUplinks = default;
            Optional<IList<NetworkDeviceRoleProperties>> networkDevices = default;
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
                        if (property0.NameEquals("roleName"u8))
                        {
                            roleName = new NetworkRackRoleName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maximumServerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumServerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maximumStorageCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumStorageCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maximumUplinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumUplinks = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("networkDevices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkDeviceRoleProperties> array = new List<NetworkDeviceRoleProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkDeviceRoleProperties.DeserializeNetworkDeviceRoleProperties(item));
                            }
                            networkDevices = array;
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
            return new NetworkRackSkuData(id, name, type, systemData.Value, roleName, Optional.ToNullable(maximumServerCount), Optional.ToNullable(maximumStorageCount), Optional.ToNullable(maximumUplinks), Optional.ToList(networkDevices), Optional.ToNullable(provisioningState));
        }
    }
}
