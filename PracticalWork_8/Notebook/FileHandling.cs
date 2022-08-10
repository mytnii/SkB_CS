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
        public static void SerializeNotebook(List<NoteBook> ConcretNoteBook, ref string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<NoteBook>));

            if(File.Exists(file))
            {
                File.Delete(file);
            }

            FileStream fStream = new FileStream(file, FileMode.Create);

            xmlSerializer.Serialize(fStream, ConcretNoteBook);

            fStream.Close();
        }

        /// <summary>
        /// Десериализация записной книги
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <returns></returns>
        public static List<NoteBook> DeserializeNoteBook(ref string file)
        {
            List<NoteBook> noteBook = new List<NoteBook>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<NoteBook>));

            FileStream fStream = new FileStream(file, FileMode.Open);

            noteBook = xmlSerializer.Deserialize(fStream) as List<NoteBook>;

            fStream.Close();

            return noteBook;
        }
    }
}
