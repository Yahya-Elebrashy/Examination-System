using System.Diagnostics;

namespace Examination_Systemm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C#");
            subject.CreateExam();


            string Input;
            do
            {
                Console.Write("Do U want To Start Exam (y|n): ");
                Input = Console.ReadLine().ToLower();
            } while (Input != "y" && Input != "n");


            Console.Clear();


            if (Input == "y")
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject.Exam?.ShowExam();
                Console.WriteLine($"The Elapsed Time: {SW.Elapsed} ");
                if (SW.Elapsed.Minutes > subject.Exam?.TimeOfExam)
                {
                    Console.WriteLine("You Exceed The Time Of Exam");
                }
            }
        }
    }
}