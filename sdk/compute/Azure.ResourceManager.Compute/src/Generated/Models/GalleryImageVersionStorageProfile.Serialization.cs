// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Source != null)
            {
                writer.WritePropertyName("source");
                writer.WriteObjectValue(Source);
            }
            if (OsDiskImage != null)
            {
                writer.WritePropertyName("osDiskImage");
                writer.WriteObjectValue(OsDiskImage);
            }
            if (DataDiskImages != null)
            {
                writer.WritePropertyName("dataDiskImages");
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GalleryImageVersionStorageProfile DeserializeGalleryImageVersionStorageProfile(JsonElement element)
        {
            GalleryArtifactVersionSource source = default;
            GalleryDiskImage osDiskImage = default;
            IList<GalleryDataDiskImage> dataDiskImages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = GalleryArtifactVersionSource.DeserializeGalleryArtifactVersionSource(property.Value);
                    continue;
                }
                if (property.NameEquals("osDiskImage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDiskImage = GalleryDiskImage.DeserializeGalleryDiskImage(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDiskImages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryDataDiskImage> array = new List<GalleryDataDiskImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(GalleryDataDiskImage.DeserializeGalleryDataDiskImage(item));
                        }
                    }
                    dataDiskImages = array;
                    continue;
                }
            }
            return new GalleryImageVersionStorageProfile(source, osDiskImage, dataDiskImages);
        }
    }
}