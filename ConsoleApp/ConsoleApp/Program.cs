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
            GroupCourses test = new GroupCourses();
            string option = "";
            string name;
            while (!option.Equals("X")){
                Console.WriteLine("A. Lista materii");
                Console.WriteLine("B. Adauga materie");
                Console.WriteLine("C. Sterge materie");
                Console.WriteLine("U. Modifica materia");
                Console.WriteLine("F. Gaseste dupa nume");
                Console.WriteLine("I. Gaseste dupa index");
                Console.WriteLine("L. Incarca din fisier date");
                Console.WriteLine("W. Scrie datele in fisier");
                Console.WriteLine("X. Exit");

                option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "A": // Afiseaza lista de cursuri
                        Console.Clear();
                        displayCourses(test.getCourses);
                        break;
                    case "B": // Adauga un curs
                        Console.Write("Introduceti numele cursului: ");
                        name = Console.ReadLine();
                        test.addCourse(name);
                        Console.WriteLine("Cursul a fost adaugat");
                        break;
                    case "C": // Sterge un curs
                        Console.Write("Introduceti ce curs doriti sa eliminati: ");
                        test.removeCourse();
                        Console.WriteLine("Cursul a fost sters");
                        break;
                    case "U": // Schimba denumirea cursului
                        Console.Write("Introduceti indexul cursului ce trebuie modificat: ");
                        //Materie toUpdate = test.GetCourse(Convert.ToInt32(Console.ReadLine()));
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduceti numele nou pentru matrie: ");
                        name = Console.ReadLine();
                        test.updateCourse(index, name);
                        Console.WriteLine("Numele a fost modificat");
                        break;
                    case "F": // Gaseste cursuri dupa nume
                        Console.Write("Introduceti numele cursului cautat: ");
                        displayCourses(test.findByName());
                        break;
                    case "I": // Gaseste un curs dupa index
                        Console.Write("Introduceti indexul cursului cautat: ");
                        Console.WriteLine(test.GetCourse(Convert.ToInt32(Console.ReadLine())).getName);
                        break;
                    case "W": // scriere date in fisier
                        test.writeDataInFile();
                        Console.WriteLine("Datele au fost scrise in fisier");
                        break;
                    case "R": // Citeste date din fisier
                        test.readDataFromFile();
                        Console.WriteLine("Datele au fost citite din fisier");
                        break;
                    case "X": // Terminare program
                        Console.WriteLine("Terminare Program");
                        return;
                    default:
                        Console.WriteLine("Optiune gresita");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void displayCourses(List<Course> a)
        {
            if (a.Count == 0)
            {
                Console.WriteLine("Nu exista cursuri");
                return;
            }
            int count = 0;
            foreach (Course materie in a)
            {
                count++;
                Console.WriteLine(count + ". " + materie.getName);
            }
        }
    }
}
