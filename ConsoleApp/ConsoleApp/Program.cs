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
                Console.WriteLine("L. Incarca din fisier date");  // trebuie de facut sa citeasca intrebarile din fisier
                Console.WriteLine("W. Scrie datele in fisier");   // trebuie de facut sa scrie intrebarile in fisier
                Console.WriteLine("M. Adauga o intrebare");
                Console.WriteLine("N. Raspunde la intrebarile de la un curs");
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
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduceti numele nou pentru matrie: ");
                        name = Console.ReadLine();
                        test.updateCourse(index, name);
                        Console.WriteLine("Numele a fost modificat");
                        break;
                    case "F": // Gaseste cursuri dupa nume
                        Console.Write("Introduceti numele cursului cautat: ");
                        name = Console.ReadLine();
                        displayCourses(test.findByName(name));
                        break;
                    case "I": // Gaseste un curs dupa index
                        Console.Write("Introduceti indexul cursului cautat: ");
                        Console.WriteLine(test.GetCourse(Convert.ToInt32(Console.ReadLine())).getName);
                        break;
                    case "W": // scriere date in fisier
                        test.writeDataInFile();
                        Console.WriteLine("Datele au fost scrise in fisier");
                        break;
                    case "L": // Citeste date din fisier
                        test.readDataFromFile();
                        Console.WriteLine("Datele au fost citite din fisier");
                        break;
                    case "M": // Adauga o intrebare la un anumit curs, setul de intrebari va forma un examen (un set de intrebari)
                              // la care se va putea raspunde ulterior
                        Console.Clear();
                        Console.WriteLine("Introduceti indexul cursului: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduceti intrebarea: ");
                        string question = Console.ReadLine();
                        Console.WriteLine("1 - Easy");
                        Console.WriteLine("2 - Normal");
                        Console.WriteLine("3 - Hard");
                        Console.WriteLine("4 - Master");
                        Console.WriteLine("5 - Expert");
                        Console.Write("Introduceti nivelul de dificultate: ");
                        string difLevel = Console.ReadLine();
                        int level;
                        if(!int.TryParse(difLevel,out level))
                        {
                            throw new Exception("Nivelul de dificultate trebuie sa fie un numar");
                        }
                        Console.WriteLine("Introduceti numarul de raspunsuri (trebuie sa fie cel putin 2): ");
                        string nrAns = Console.ReadLine();
                        int nrAnswers;
                        if (!int.TryParse(nrAns, out nrAnswers))
                        {
                            throw new Exception("Numarul de intrebari trebuie sa fie un numar trebuie sa fie un numar");
                        }
                        Console.WriteLine("Introduceti raspunsul corect: ");
                        string answer = Console.ReadLine();

                        Console.WriteLine("Introduceti raspunsurile gresite: ");
                        string[] wrongAnswers = new string[nrAnswers-1];
                        for(int i = 0; i<nrAnswers-1; i++)
                        {
                            Console.Write((i + 1) + ". ");
                            wrongAnswers[i] = Console.ReadLine();
                        }

                        test.addQuestionToCourse(index, question, wrongAnswers, answer, level);
                        Console.WriteLine("Intrebarea a fost adaugata");
                        break;

                    case "N":
                        Console.Write("Selectati indexul cursului la care se va raspunde la intrebari: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        List<Question> exam = test.getQuestions(index);
                        displayExam(exam);
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

        static void displayExam(List<Question> a)
        {
            if (a.Count == 0)
            {
                Console.WriteLine("Nu exista intrebari");
                return;
            }
            int count = 0;
            foreach (Question question in a)
            {
                count++;
                Console.WriteLine("Nivelul de dificultate: " + question.getDiffLevel().ToString());
                Console.WriteLine(count + ". " + question.getQuestion);
                List<string> answers = question.getPossibleAnswers;
                displayAnswerBlock(answers);
                Console.Write("Raspuns: ");
                int answerIndex = Convert.ToInt32(Console.ReadLine());
                if (answers[--answerIndex].Equals(question.getCorrectAnswer))
                {
                    Console.WriteLine("Raspuns corect");
                }else
                {
                    Console.WriteLine("Raspuns gresit");
                }
                Console.ReadKey();
            }
        }

        static void displayAnswerBlock(List<string> possibleAnswers)
        {
            for(int i = 0; i < possibleAnswers.Count; i++)
            {
                Console.WriteLine((i+1)+". "+possibleAnswers[i]);
            }
        }
    }
}
