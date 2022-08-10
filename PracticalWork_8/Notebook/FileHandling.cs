using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Notebook
{
    internal class FileHandling
    {

        /// <summary>
        /// Сериализация записной книжки
        /// </summary>
        /// <param name="ConcretNoteBook">Экземпляр для сериализации</param>
        /// <param name="file">Имя файла</param>
        public static void SerializeNotebook(ref NoteBook ConcretNoteBook, ref string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(NoteBook));

            FileStream fStream = new FileStream(file, FileMode.Append);

            xmlSerializer.Serialize(fStream, ConcretNoteBook);

            fStream.Close();
        }
    }
}
