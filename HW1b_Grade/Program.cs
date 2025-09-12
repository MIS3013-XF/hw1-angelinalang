// HW1b Grade

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARE: variables 
            double FinalGrade;
            double HomeworkGrade;   
            double ParticipationGrade;  
            double QuizGrade;   
            double MidtermGrade;    
            double FinalExamGrade;

            string FirstName;
            string LastName;
            string StudentID;   

            // WRITE: input statements
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            StudentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            HomeworkGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            ParticipationGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            QuizGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            MidtermGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            FinalExamGrade = Convert.ToDouble(Console.ReadLine());

            // CALCULATE: final grade
            FinalGrade = ((HomeworkGrade * 0.20) + (ParticipationGrade * 0.20) + (QuizGrade * 0.15) + (MidtermGrade * 0.2) + (FinalExamGrade * 0.25))/100;

            // PRINT: final output statement
            Console.WriteLine(FirstName + " " + LastName + " (" + StudentID + "), your final grade is " + FinalGrade.ToString("P2") +".");
        }
    }
}
