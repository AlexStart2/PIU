using System;
using System.Collections.Generic;
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
        public string getName { get { return name; } }
        public int getNrQuestions {  get { return nrQuestions; } }

        public List<Question> getExam { get { return exam; } }
        public void setName(string _name)
        {
            if(_name.Trim().Equals("") || string.IsNullOrEmpty(_name))
            {
                throw new Exception("Name should not be empty");
            }
            name = _name.Trim();
        }

        public void addQuestion(string _question, string[] _wrongAnswers, string _correctAnswer, int _difficultyLevel)
        {
            exam.Add(new Question());
            exam[nrQuestions].setQuestion(_question,_difficultyLevel);
            exam[nrQuestions].setWrongAnswers(_wrongAnswers);
            exam[nrQuestions].setAnswer(_correctAnswer);
            nrQuestions++;
        }
    }
}
