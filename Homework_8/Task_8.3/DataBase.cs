using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_8._3
{
    class DataBase
    {
        string FileName;
        List<Question> Questions;

        /// <summary>
        /// Количество вопросов.
        /// </summary>
        public int Count 
        {
            get { return Questions.Count; } 
        }

        public Question this[int index]
        {
            get { return Questions[index]; }
            set { Questions[index] = value; }
        }

        public DataBase(string fileName)
        {
            FileName = fileName;
            Questions = new List<Question>();
        }

        /// <summary>
        /// Добавляет вопрос в списчок вопросов.
        /// </summary>
        /// <param name="text">текст вопроса.</param>
        /// <param name="answer">Ответ на вопрос.</param>
        /// <param name="page">Страница с вопросом.</param>
        public void Add(string text, bool answer)
        {
            Questions.Add(new Question(text, answer));
        }

        /// <summary>
        /// Удаляет вопрос.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int page)
        {
            Questions.RemoveAt(--page);
        }

        /// <summary>
        /// Сохраняет список вопросов в XML формате.
        /// </summary>
        public void Save()
        {
            using (var fStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                new XmlSerializer(typeof(List<Question>)).Serialize(fStream, Questions);
        }

        /// <summary>
        /// Загружает список вопросов.
        /// </summary>
        public void Load()
        {
            using (var fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                Questions = (List<Question>)new XmlSerializer(typeof(List<Question>)).Deserialize(fStream);
        }
    }
}
