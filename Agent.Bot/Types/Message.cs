using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Agent.Bot.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Message
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MsgId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Chat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime Timestamp { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Название (подпись к сообщению) последнего файла в группе (или единственного файла)
        /// </summary>
        /// <remarks>
        /// В Андроид-клиенте подпись вообще недоступна при отправке, а через Share Intent доступно только для одиночных файлов.
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }

        /// <summary>
        /// ИД последнего файла в группе (или единственного файла)
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// Тип последнего файла в группе (или единственного файла)
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileType { get; set; }
        
        /// <summary>
        /// Список файлов либо Null, если файл только один
        /// </summary>
        public ICollection<Document> Documents { get; set; }

        // @idan-rubin
        // remove 'parts' from Message model schema since it has various types in case of 'mention'
        //[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public IEnumerable<MessagePart> Parts { get; set; }
    }
}
