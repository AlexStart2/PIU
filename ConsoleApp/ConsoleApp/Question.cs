using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
    internal class Question
    {
        private string question;
        private string[] possibleAnswers;
        private string answer;

        public string getQuestion { get { return question; } }
        public string getAnswer { get { return answer; } }
        public string[] getPossibleAnswers { get { return possibleAnswers; } }

        public void setQuestion(string _question)
        {
            if (_question.Trim().Equals("") || _question.Equals(null))
            {
                throw new Exception("Question should not be empty");
            }
            question = _question.Trim();
        }

        public void setPossibleQuestions(string[] _possibleQuestions)
        {
            if(_possibleQuestions.Length <= 1)
            {
                throw new Exception("Must be at least 2 possible questions");
            }
            foreach (string _question in _possibleQuestions)
            {
                if(_question.Trim().Equals("") || string.IsNullOrEmpty(_question))
                {
                    throw new Exception("Questions should not be empty");
                }
            }
            possibleAnswers = _possibleQuestions;
        }

        public void setAnswer(string _answer)
        {
            if (_answer.Trim().Equals("") || _answer.Equals(null))
            {
                throw new Exception("Question should not be empty");
            }
            question = _answer.Trim();
        }
    }
}
