using CarlElias.Common.JsonConverters;
using System.Text.Json.Serialization;

namespace CarlElias.Common.Types
{
    [JsonConverter(typeof(NullBoolConverter))]
    public readonly struct NullBool(bool value)
    {
        public bool Value { get; } = value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator bool(NullBool nullBool) => nullBool.Value;
        public static implicit operator NullBool(bool value) => new(value);
    }
}
