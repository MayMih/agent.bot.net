using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Agent.Bot.Types;
using Agent.Bot.Types.Enums;

namespace Agent.Bot.Converters
{
    internal class InputMediaConverter : InputFileConverter
    {
        public override bool CanConvert(Type objectType) => typeof(InputMedia) == objectType;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var inputMediaType = (InputMedia)value;
            switch (inputMediaType.FileType)
            {
                case FileType.Id:
                case FileType.Stream:
                    writer.WriteValue($"attach://{inputMediaType.FileName}");
                    break;
                default:
                    throw new NotSupportedException("File Type not supported");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = JToken.ReadFrom(reader).Value<string>();
            return value?.StartsWith("attach://") == true
                    ? new InputMedia(Stream.Null, value.Substring(9))
                    : new InputMedia(value);
        }
    }
}
