using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Course
    {
        private string name;
        private List<Question> exam = new List<Question>();
        private int nrQuestions = 0;
        public string Name { get { return name; } }
        public int NrQuestions {  get { return nrQuestions; } }

        public List<Question> getQuestions { get { return exam; } }
        public string setName
        {
            set
            {
                name = value; 
            } 
        }

        public void addQuestion(string _question, string[] _wrongAnswers, string _correctAnswer, int _difficultyLevel, string _imagePath = "")
        {
            exam.Add(new Question());
            exam[nrQuestions].setQuestion(_question,_difficultyLevel);
            exam[nrQuestions].setWrongAnswers(_wrongAnswers);
            exam[nrQuestions].setAnswer(_correctAnswer);
            if(_imagePath != "")
            {
                exam[nrQuestions].ImagePath = _imagePath;
            }
            nrQuestions++;
        }

        public void addQuestion(Question q)
        {
            exam.Add(q);
            nrQuestions++;
        }

        public void removeQuestion(int index)
        {
            if (index > exam.Count || index < 0)
            {
                throw new Exception("Invalid index");
            }
            nrQuestions--;

            if (exam[index].ImagePath != "" && exam[index].ImagePath != "Images/" && exam[index].ImagePath!=null)
            {
                System.IO.File.Delete(exam[index].ImagePath);
            }
            exam.RemoveAt(index);
        }


        public void editQuestion(int index, string _question, string[] _wrongAnswers, 
            string _correctAnswer, int _difficultyLevel, string ImagePath)
        {
            if (index > exam.Count || index < 0)
            {
                throw new Exception("Invalid index");
            }
            exam[index].setQuestion(_question, _difficultyLevel);
            exam[index].setWrongAnswers(_wrongAnswers);
            exam[index].setAnswer(_correctAnswer);
            exam[index].ImagePath = ImagePath;
        }

        public List<Question> findQuestions(string _question)
        {
            List<Question> found = new List<Question>();
            foreach (Question q in exam)
            {
                if (q.getQuestion.ToLower().Contains(_question.ToLower()))
                {
                    found.Add(q);
                }
            }
            return found;
        }
    }
}
