using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ClassMaterii
    {
        public List<Materie> obiecte = new List<Materie>();
        int currentCourse = 0;
        public List<Materie> list()
        {
            return obiecte;
        }

        public Materie GetCourse() {
            int index = Convert.ToInt32(Console.ReadLine());
            if(index <= 0 || index > obiecte.Count)
            {
                throw new Exception("Invalid index");
            }
            return obiecte[--index]; 
        }

        public void addCourse()
        {
            obiecte.Add(new Materie());
            string name = Console.ReadLine();
            obiecte[currentCourse].setName(name);
            currentCourse++;
        }

        public void removeCourse()
        {
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > obiecte.Count || index < 0)
            {
                throw new Exception("Invalid index");
            }
            obiecte.RemoveAt(index);
        }

        public List<Materie> findByName()
        {
            List<Materie> found = new List<Materie>();
            string name = Console.ReadLine();
            foreach(Materie materie in obiecte)
            {
                if(materie.getName.ToLower().Contains(name.ToLower()))
                {
                    found.Add(materie);
                }
            }
            return found;
        }
    }
}
