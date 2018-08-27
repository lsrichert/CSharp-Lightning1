using System;

namespace lightning1
{
    // Create some cohorts, students, and instructors in your `Program.cs` and assign 
    // the students and instructors to the cohort

    // Next:
    // 1. Create some exercises
    // 2. Write a method on the `Instructor` class that will allow you 
    // to assign an individual exercise to an individual student

    class Program
    {
        static void Main(string[] args)
        {
            // Create cohorts, students and instructors here; cohort does not
            // need a constructor but instructor and student do.
            Cohort cohort26 = new Cohort(); 
            Instructor steve = new Instructor("Steve", "Brownlee");
            Student jewel = new Student("Jewel", "Ramirez");
            Student lauren = new Student("Lauren", "Richert");

            cohort26.InstructorList.Add(steve);
            cohort26.StudentList.Add(jewel);

            // Creating some exercises here
            Exercise chickenMonkey = new Exercise();
               chickenMonkey.Name = "ChickenMonkey";
               chickenMonkey.GithubURL = "Github URL ChickenMonkey";
               chickenMonkey.Language = "JavaScript";

            Exercise battleBands = new Exercise();
                battleBands.Name = "Battle Bands";
                battleBands.GithubURL = "Github URL BattleBands";
                battleBands.Language = "JavaScript";

                // nameof ="BattleBAnds"

            Console.WriteLine(battleBands.Name);

            steve.AssignExercise(jewel, chickenMonkey);
            steve.AssignExercise(jewel, battleBands);

            // Pick one of the students and write to the Console each exercise 
            // that has been assigned to that student

            foreach (Exercise exercise in jewel.AssignedExercises)
            {
            // this code just lists the exercises that have been assigned
            Console.WriteLine(exercise.Name);
            // this code lists jewel's name and the exercises assigned to her
            Console.WriteLine($"{jewel.Name}; {exercise.Name}");
            }
        }
    }
}
