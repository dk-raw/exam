using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam e1 = new Exam("Lower");
            
            Console.WriteLine($"INPUT THE GRADE FOR THE {e1.Title} EXAM");

            Console.WriteLine($"THE BASE SCORE IS {e1.Base}/100");

            int userscore = Convert.ToInt32(Console.ReadLine());

            if (userscore >= e1.Base)
            {
                Console.WriteLine($"RESULT: PASS GRADE: {userscore} POINTS");
            }
            else
            {
                Console.WriteLine($"RESULT: FAIL GRADE: {userscore} POINTS");

                Console.WriteLine("you can always buy the diploma from our e-shop");
            }

        }
    }

    class Exam
    {
        public string Title;

        public int Base { get; } = 65;

        public Exam(string title)
        {
            Title = title;
        }
    }
}
