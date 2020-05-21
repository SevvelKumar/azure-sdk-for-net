// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class AutocompleteItem
    {
        internal static AutocompleteItem DeserializeAutocompleteItem(JsonElement element)
        {
            string text = default;
            string queryPlusText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryPlusText"))
                {
                    queryPlusText = property.Value.GetString();
                    continue;
                }
            }
            return new AutocompleteItem(text, queryPlusText);
        }
    }
}