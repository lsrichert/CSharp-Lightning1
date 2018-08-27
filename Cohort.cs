using System;
using System.Collections.Generic;

namespace lightning1 {
//     Create a `Cohort` class that 

// 1. Maintains a list of students
// 2. Maintains a list of instructors
// 3. Has a property of the cohort number

public class Cohort {
    // StudentList is a property of Cohort; List is a type of the property; this line
    // is making a new instance of StudentList. Use 'get' and 'set' 
    public List<Student> StudentList { get; set; } = new List<Student>();
    public List<Instructor> InstructorList { get; set; } = new List<Instructor>();
    public int Number; 
}


}