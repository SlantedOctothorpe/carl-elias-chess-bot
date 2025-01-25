using CarlElias.Common.JsonConverters;
using System.Text.Json.Serialization;

namespace CarlElias.Common.Types
{
    [JsonConverter(typeof(SnowflakeConverter))]
    public readonly struct Snowflake(ulong value)
    {
        public ulong Value { get; } = value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator ulong(Snowflake snowflake) => snowflake.Value;
        public static implicit operator Snowflake(ulong value) => new(value);
    }

}
