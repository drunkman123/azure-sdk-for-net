// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class VirtualMachineInstancePropertiesStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference"u8);
                JsonSerializer.Serialize(writer, ImageReference);
            }
            if (Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (Optional.IsDefined(VmConfigStoragePathId))
            {
                writer.WritePropertyName("vmConfigStoragePathId"u8);
                writer.WriteStringValue(VmConfigStoragePathId);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineInstancePropertiesStorageProfile DeserializeVirtualMachineInstancePropertiesStorageProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WritableSubResource>> dataDisks = default;
            Optional<WritableSubResource> imageReference = default;
            Optional<VirtualMachineInstancePropertiesStorageProfileOSDisk> osDisk = default;
            Optional<ResourceIdentifier> vmConfigStoragePathId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = VirtualMachineInstancePropertiesStorageProfileOSDisk.DeserializeVirtualMachineInstancePropertiesStorageProfileOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("vmConfigStoragePathId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmConfigStoragePathId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualMachineInstancePropertiesStorageProfile(Optional.ToList(dataDisks), imageReference, osDisk.Value, vmConfigStoragePathId.Value);
        }
    }
}
