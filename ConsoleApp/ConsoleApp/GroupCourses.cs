using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class GroupCourses
    {
        private List<Course> courses = new List<Course>();
        private int nrCourse = 0;
        private string fileName = ConfigurationManager.AppSettings.Get("NumeFisier");

        public int getNrCourse {  get { return nrCourse; } }
        public List<Course> getCourses { get { return courses; } }

        public GroupCourses()
        {
            Stream streamFisierText = File.Open(fileName, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public Course GetCourse(int index) {
            if(index <= 0 || index > courses.Count)
            {
                throw new Exception("Invalid index");
            }
            return courses[--index]; 
        }

        public void addCourse(string name)
        {
            courses.Add(new Course());
            courses[nrCourse].setName(name);
            nrCourse++;
        }

        public void removeCourse()
        {
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > courses.Count || index <= 0)
            {
                throw new Exception("Invalid index");
            }
            nrCourse--;
            courses.RemoveAt(--index);
        }

        public List<Course> findByName()
        {
            List<Course> found = new List<Course>();
            string name = Console.ReadLine();
            foreach(Course materie in courses)
            {
                if(materie.getName.ToLower().Contains(name.ToLower()))
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
    }
}
