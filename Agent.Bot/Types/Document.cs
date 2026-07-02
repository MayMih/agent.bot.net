namespace Agent.Bot.Types
{
    /// <summary>
    /// Класс, представляющий базовую информацию о файлах вложенных в сообщение
    /// </summary>
    public class Document
    {
        public Document(string caption, string fileId, string fileType)
        {
            this.Caption = caption;
            this.FileId = fileId;
            this.FileType = fileType;
        }

        /// <summary>
        /// Название (подпись к сообщению) 
        /// </summary>
        /// <remarks>
        /// В Андроид-клиенте подпись вообще недоступна при отправке, а через Share Intent доступно только для одиночных файлов.
        /// </remarks>
        public string Caption { get; set; }

        /// <summary>
        /// Уникальный ИД файла 
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// Тип файла 
        /// </summary>
        public string FileType { get; set; }
    }
}