// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerEditionCapability
    {
        internal static PostgreSqlFlexibleServerEditionCapability DeserializePostgreSqlFlexibleServerEditionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> defaultSkuName = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerStorageEditionCapability>> supportedStorageEditions = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerSkuCapability>> supportedServerSkus = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultSkuName"u8))
                {
                    defaultSkuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerStorageEditionCapability> array = new List<PostgreSqlFlexibleServerStorageEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerStorageEditionCapability.DeserializePostgreSqlFlexibleServerStorageEditionCapability(item));
                    }
                    supportedStorageEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerSkus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerSkuCapability> array = new List<PostgreSqlFlexibleServerSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerSkuCapability.DeserializePostgreSqlFlexibleServerSkuCapability(item));
                    }
                    supportedServerSkus = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerEditionCapability(Optional.ToNullable(status), reason.Value, name.Value, defaultSkuName.Value, Optional.ToList(supportedStorageEditions), Optional.ToList(supportedServerSkus));
        }
    }
}
