using CarlElias.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarlElias.Common.JsonConverters
{
    public class NullBoolConverter : JsonConverter<NullBool>
    {
        public override NullBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return new NullBool(true);
            }

            if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
            {
                return new NullBool(reader.GetBoolean());
            }

            if (reader.TokenType == JsonTokenType.StartObject || reader.TokenType == JsonTokenType.None)
            {
                // If the property is missing, set to false by default
                return new NullBool(false);
            }

            throw new JsonException($"Unexpected token type: {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, NullBool value, JsonSerializerOptions options)
        {
            if (value.Value)
            {
                // True value is null
                // Otherwise do not write the property
                writer.WriteNullValue();
            }
        }
    }
}
