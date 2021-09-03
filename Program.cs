using System;
using System.Collections.Generic;

namespace Anonymous_school_result
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Since the total number or names of students are not given, i will be generating a random number of students using the .Next()
            method from the Random class, with a range of my choosing.*/
            Random scoreGenerated = new Random();
            //i created a list that would hold all the students score.
            List<int> score = new List<int>();

            /*i created a For loop with a condition to run not more than the number of my generated random
            object, and for each time the loop runs a generated random number from range 1 - 100 will be added
            into my score list object as a students score.*/
            for(int j = 0; j < scoreGenerated.Next(20, 150); j++)
            {
                score.Add(scoreGenerated.Next(1, 100));
            }

            Console.WriteLine();
            Console.WriteLine("Anonymous Exam Roaster Of Class (2020-2021).");
            Console.WriteLine();
            Console.WriteLine("  1) Total Number of students that participated in the Exam => " + score.Count+".");

            int passedStudents = 0;
            int averageStudents = 0;
            int failedStudents = 0;
            /*i created another For loop with each iteration checking inside my list object
            for the three conditions statemented in the if statements.*/
            for(int i = 0; i < score.Count; i++ )
            {
                if(score[i] > 70)
                {
                    passedStudents++;
                }

                if(score[i] >= 50 && score[i] < 70)
                {
                    averageStudents++;
                }

                if(score[i] < 40)
                {
                    failedStudents++;
                }


            }
            Console.WriteLine();
            Console.WriteLine("  2) Total number of students that passed above 70. => " +passedStudents+".");
            Console.WriteLine();
            Console.WriteLine("  3) Total number of students that got an average score. => " +averageStudents+".");
            Console.WriteLine();
            Console.WriteLine("  4) Total number of students that failed. => " +failedStudents+".");
            Console.WriteLine();
            
            Console.WriteLine("SCORES");
            int loopOn = 0;
            foreach(int totalScore in score)
            {
                loopOn++;
                Console.WriteLine(loopOn+") " + totalScore);
            }


        }
    }
}
