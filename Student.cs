using System;
using System.Collections.Generic;

namespace lightning1 {
// Create a `Student` class with the following properties and fields

// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of student
// 3. Constructor that accepts first name and last name
// 4. A public list of exercises

public class Student {

    // step 1. Private fields for first name and last name
    private string _firstName { get; set; }
    private string _lastName { get; set; }

    // step 2. Public calculated property that returns "FirstName LastName" of student
    public string Name  { get => $"{_firstName} {_lastName}";}

    // step 4. A public list of exercises
public List<Exercise> AssignedExercises { get; } = new List<Exercise>();

    // step 3. Constructor that accepts first name and last name
    public Student(string firstName, string lastName) {
        // _firstName stands for the 'field' firstName is the value you're 
        // assigning to the field of _firstName
        _firstName = firstName;
        _lastName = lastName; 
    }
}
}