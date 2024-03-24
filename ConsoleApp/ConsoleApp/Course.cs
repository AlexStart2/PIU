using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Course
    {
        private string name;
        private List<Question> exam;
        private int nrQuestions = 0;
        public string getName { get { return name; } }
        public int getNrQuestions {  get { return nrQuestions; } }
        public void setName(string _name)
        {
            if(_name.Trim().Equals("") || string.IsNullOrEmpty(_name))
            {
                throw new Exception("Name should not be empty");
            }
            name = _name.Trim();
        }

        // public void addQuestion() { }
    }
}
