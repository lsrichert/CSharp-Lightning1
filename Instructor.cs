using System;
using System.Collections.Generic;

namespace lightning1 {

// Create an `Instructor` class with the following properties and fields

// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of instructor
// 3. Constructor that accepts first name and last name

public class Instructor {
    private string _firstName { get; set; }
    private string _lastName { get; set; }

    public string Name { get => $"{_firstName} {_lastName}";}

    public Instructor(string firstName, string lastName) {
        _firstName = firstName;
        _lastName = lastName;
    }
// 2. Write a method on the `Instructor` class that will allow you 
    // to assign an individual exercise to an individual student
    public void AssignExercise(Student student, Exercise exercise)
    {
                student.AssignedExercises.Add(exercise);
    }

}
}