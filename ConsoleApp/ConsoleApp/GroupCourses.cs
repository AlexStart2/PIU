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
        private List<Course> courses = new List<Course>();
        private int nrCourse = 0;
        private readonly string fileName = ConfigurationManager.AppSettings.Get("NumeFisier");

        public int getNrCourse { get { return nrCourse; } }
        public List<Course> getCourses { get { return courses; } }

        public GroupCourses()
        {
            Stream streamFisierText = File.Open(fileName, FileMode.OpenOrCreate);
            streamFisierText.Close();
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
            courses[nrCourse].setName(name);
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
                if(materie.getName.ToLower().Contains(name.ToLower().Trim()))
                {
                    found.Add(materie);
                }
            }
            return found;
        }

        public void updateCourse(int index, string name)
        {
            Course toUpdate = GetCourse(index);
            toUpdate.setName(name);
        }

        public void writeDataInFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName,false))
            {
                streamWriter.Write(ConvertToSaveDateInFile());
            }
        }

        public void readDataFromFile() // trebuie de facut sa nu se dubleze datele
                                       // (de luat si indexul de comparat cu ce exista si de suprascris dupa caz)
        {
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string lineFile;

                while ((lineFile = streamReader.ReadLine()) != null)
                {
                    string[] course = lineFile.Split('.');
                    courses.Add(new Course());
                    courses[nrCourse].setName(course[1].Trim());
                    nrCourse++;
                }
            }
        }

        string ConvertToSaveDateInFile()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < courses.Count; i++)
            {
                sb.AppendLine((i+1)+".\t"+courses[i].getName);
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
            return courses[--index].getExam;
        }
    }
}
