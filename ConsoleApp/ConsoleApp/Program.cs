using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        
        static void Main()
        {
            ClassMaterii test = new ClassMaterii();
            string option = "";
            while (!option.Equals("X")){
                Console.WriteLine("A. Lista materii");
                Console.WriteLine("B. Adauga materie");
                Console.WriteLine("C. Sterge materie");
                Console.WriteLine("F. Gaseste dupa nume");
                Console.WriteLine("F. Gaseste dupa index");
                Console.WriteLine("L. Incarca din fisier date");
                Console.WriteLine("W. Scrie datele in fisier");
                Console.WriteLine("X. Exit");

                option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "A": // Afiseaza lista de cursuri
                        displayCourses(test.list());
                        break;
                    case "B": // Adauga un curs
                        Console.Write("Introduceti numele cursului: ");
                        test.addCourse();
                        break;
                    case "C":
                        Console.Write("Introduceti ce curs doriti sa eliminati: ");
                        test.removeCourse();
                        break;
                    case "F":
                        Console.Write("Introduceti numele cursului cautat: ");
                        displayCourses(test.findByName());
                        break;
                    case "I":
                        Console.Write("Introduceti indexul cursului cautat: ");
                        Console.WriteLine(test.GetCourse().getName);
                        break;
                    case "X": 
                        Console.WriteLine("Terminare Program");
                        break;
                    default:
                        Console.WriteLine("Optiune gresita");
                        break;
                }
            }
        }

        static void displayCourses(List<Materie> a)
        {
            if (a.Count == 0)
            {
                Console.WriteLine("Nu exista cursuri");
                return;
            }
            int count = 0;
            foreach (Materie materie in a)
            {
                count++;
                Console.WriteLine(count + ". " + materie.getName);
            }
        }
    }
}
