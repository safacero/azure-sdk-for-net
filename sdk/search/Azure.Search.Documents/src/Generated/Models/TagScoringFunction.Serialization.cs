// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class TagScoringFunction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tag");
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("fieldName");
            writer.WriteStringValue(FieldName);
            writer.WritePropertyName("boost");
            writer.WriteNumberValue(Boost);
            if (Interpolation != null)
            {
                writer.WritePropertyName("interpolation");
                writer.WriteStringValue(Interpolation.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static TagScoringFunction DeserializeTagScoringFunction(JsonElement element)
        {
            TagScoringParameters tag = default;
            string type = default;
            string fieldName = default;
            double boost = default;
            ScoringFunctionInterpolation? interpolation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tag"))
                {
                    tag = TagScoringParameters.DeserializeTagScoringParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldName"))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boost"))
                {
                    boost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("interpolation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interpolation = property.Value.GetString().ToScoringFunctionInterpolation();
                    continue;
                }
            }
            return new TagScoringFunction(type, fieldName, boost, interpolation, tag);
        }
    }
}
