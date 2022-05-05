using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Agent.Bot.Types;
using Agent.Bot.Types.Enums;
using Agent.Bot.Types.InputFiles;

namespace Agent.Bot.Converters
{
    internal class InputFileConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType.GetTypeInfo().IsSubclassOf(typeof(InputFileStream));

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var input = (IInputFile)value;
            switch (input.FileType)
            {
                case FileType.Stream:
                    writer.WriteValue(null as object);
                    break;
                case FileType.Id when value is InputICQFile file:
                    writer.WriteValue(file.FileId);
                    break;
                default:
                    throw new NotSupportedException("File Type is not supported");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = JToken.ReadFrom(reader).Value<string>();
            if (value == null)
            {
                return new InputFileStream(Stream.Null);
            }
            else
            {
                return new InputICQFile(value);
            }
        }
    }
}
