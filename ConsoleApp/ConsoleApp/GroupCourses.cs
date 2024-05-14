using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class GroupCourses
    {
        private const string SeparatorCursuri = "$end$";
        private const char SeparatorRaspunsuri = '@';
        private List<Course> courses = new List<Course>();
        private int nrCourse = 0;
        private readonly string fileName = ConfigurationManager.AppSettings.Get("NumeFisier");

        public int getNrCourse { get { return nrCourse; } }
        public List<Course> getCourses { get { return courses; } }

        public GroupCourses()
        {
            Stream streamFisierText = File.Open(fileName, FileMode.OpenOrCreate);
            streamFisierText.Close();
            readDataFromFile();
        }

        public GroupCourses(List<Course> list)
        {
            courses = list;
        }

        public Course GetCourse(int index) {
            if(index < 0 || index > courses.Count)
            {
                throw new Exception("Invalid index");
            }
            return courses[index]; 
        }

        public void addCourse(string name)
        {
            courses.Add(new Course());
            courses[nrCourse].setName =name;
            nrCourse++;
        }

        public void removeCourse(int index)
        {
            if (index > courses.Count || index < 0)
            {
                throw new Exception("Invalid index");
            }
            nrCourse--;
            courses.RemoveAt(index);
        }

        public List<Course> findByName(string name)
        {
            List<Course> found = new List<Course>();
            foreach(Course materie in courses)
            {
                if(materie.Name.ToLower().Contains(name.ToLower().Trim()))
                {
                    found.Add(materie);
                }
            }
            return found;
        }

        public void updateCourse(int index, string name)
        {
            Course toUpdate = GetCourse(index);
            toUpdate.setName = name;
        }

        public void writeDataInFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName,false))
            {
                streamWriter.Write(ConvertToSaveDataInFile());
            }
        }

        public void readDataFromFile()
        {
            using(StreamReader streamReader = new StreamReader(fileName))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    courses.Add(new Course());
                    courses[nrCourse].setName = line.Split('.')[1].Trim();

                    while ((line = streamReader.ReadLine()) != SeparatorCursuri && line != null)
                    {
                        string question = line;
                        string correctAnswer = streamReader.ReadLine();
                        int difficultyLevel = int.Parse(streamReader.ReadLine());
                        string[] wrongAnswers = streamReader.ReadLine().Split(SeparatorRaspunsuri);
                        courses[nrCourse].addQuestion(question, wrongAnswers, correctAnswer, difficultyLevel);
                    }
                    nrCourse++;
                }
            }

        }

        string ConvertToSaveDataInFile()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < courses.Count; i++)
            {
                sb.AppendLine((i+1)+".\t"+courses[i].Name);
                for(int j = 0; j < courses[i].NrQuestions; j++)
                {
                    sb.AppendLine(courses[i].getQuestions[j].getQuestion);
                    sb.AppendLine(courses[i].getQuestions[j].getCorrectAnswer);
                    sb.AppendLine(courses[i].getQuestions[j].getDiffLevel().ToString());

                    string wrongAnswers = "";
                    foreach (string answer in courses[i].getQuestions[j].getWrongAnswers)
                    {
                        wrongAnswers += answer + SeparatorRaspunsuri;
                    }
                    wrongAnswers = wrongAnswers.Remove(wrongAnswers.Length - 1);
                    sb.AppendLine(wrongAnswers);
                }
                sb.AppendLine(SeparatorCursuri);
            }
            return sb.ToString();
        }

        public void addQuestionToCourse(int index, string _question, string[] _wrongAnswers, string _correctAnswer, int _difficultyLevel)
        {
            if (index > courses.Count || index <= 0)
            {
                throw new Exception("Invalid index");
            }
            courses[--index].addQuestion(_question, _wrongAnswers, _correctAnswer, _difficultyLevel);
        }

        public List<Question> getQuestions(int index)
        {
            if (index > courses.Count || index <= 0)
            {
                throw new Exception("Invalid index");
            }
            return courses[--index].getQuestions;
        }

    }
}
