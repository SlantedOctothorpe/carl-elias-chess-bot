using CarlElias.Common.Types;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace CarlElias.Common.JsonConverters
{
    public class SnowflakeConverter : JsonConverter<Snowflake>
    {
        public override Snowflake Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (ulong.TryParse(reader.GetString(), out var value))
                {
                    return new Snowflake(value);
                }

                throw new JsonException("Invalid Snowflake format.");
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetUInt64(out var value))
                {
                    return new Snowflake(value);
                }

                throw new JsonException("Invalid Snowflake format.");
            }

            throw new JsonException("Unexpected token type.");
        }

        public override void Write(Utf8JsonWriter writer, Snowflake value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value.ToString());
        }
    }
}
