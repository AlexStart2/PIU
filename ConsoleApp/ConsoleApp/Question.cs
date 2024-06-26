﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
    public enum difficultyLevel
    {
        Easy = 1,
        Normal = 2,
        Hard = 3,
        Master = 4,
        Expert = 5
    }
    public class Question
    {
        private string question;
        private string[] wrongAnswers;
        private string correctAnswer;
        private difficultyLevel diffLevel;
        private string imagePath;

        public string getQuestion { get { return question; } }
        public string getCorrectAnswer { get { return correctAnswer; } }
        public difficultyLevel getDifficultyLevel { get { return diffLevel; } }
        public string[] getWrongAnswers { get { return wrongAnswers; } }

        public string ImagePath { get { return imagePath; } set { 
                if(value == null || value.Trim().Equals(""))
                {
                    throw new Exception("Image path should not be empty");
                }
                imagePath = value; 
            } }

        public object getDiffLevel()
        {
            return (int)diffLevel;
        }

        public List<string> getPossibleAnswers { get {
                List<string> allAnswers = new List<string>(wrongAnswers);
                allAnswers.Add(correctAnswer);

                Random rng = new Random();
                int n = allAnswers.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    string value = allAnswers[k];
                    allAnswers[k] = allAnswers[n];
                    allAnswers[n] = value;
                }

                return allAnswers;
            } }

        public void setQuestion(string _question, int _difficultyLevel=-1)
        {
            if (_question.Trim().Equals("") || _question.Equals(null))
            {
                throw new Exception("Question should not be empty");
            }
            if(_difficultyLevel<1 || _difficultyLevel>5)
            {
                throw new Exception("Difficulty level should be between 0 and 4");
            }
            diffLevel = (difficultyLevel)_difficultyLevel;
            question = _question.Trim();
        }

        public void setWrongAnswers(string[] _wrongAnswers)
        {
            if(_wrongAnswers.Length <= 1)
            {
                throw new Exception("Must be at least 2 possible answers");
            }
            foreach (string _answer in _wrongAnswers)
            {
                if (string.IsNullOrEmpty(_answer) || _answer.Trim().Equals(""))
                {
                    throw new Exception("Answer should not be empty");
                }
            }
            wrongAnswers = _wrongAnswers;
        }

        public void setAnswer(string _answer)
        {
            if (_answer.Trim().Equals("") || _answer.Equals(null))
            {
                throw new Exception("Answer should not be empty");
            }
            correctAnswer = _answer.Trim();
        }
    }
}
