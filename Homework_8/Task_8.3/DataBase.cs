using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task_8._3
{
    class DataBase
    {
        private List<Question> Questions;

        /// <summary>
        /// Имя файла с данными.
        /// </summary>
        public string FileName { get; }

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
        }

        public DataBase(string fileName)
        {
            FileName = fileName;
            Questions = new List<Question>();
            Add("", false);
        }

        /// <summary>
        /// Добавляет вопрос в списчок вопросов.
        /// </summary>
        /// <param name="text">текст вопроса.</param>
        /// <param name="answer">Ответ на вопрос.</param>
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
            Questions.RemoveAt(page);
        }

        /// <summary>
        /// Сохраняет список вопросов в XML формате.
        /// </summary>
        public void Save()
        {
            var json = JsonConvert.SerializeObject(Questions);
            File.WriteAllText(FileName, json);
        }

        /// <summary>
        /// Загружает список вопросов из файла.
        /// </summary>
        public void Load()
        {
            Questions = JsonConvert.DeserializeObject<List<Question>>(File.ReadAllText(FileName));
            
        }
    }
}
