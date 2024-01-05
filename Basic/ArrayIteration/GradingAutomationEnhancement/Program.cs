using System;
// the number of exam assignment for each student 
int examAssignments = 5;

// Array of student name
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Arrays to store scores for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Array to store current student exam scores (assuming a student up to 10 exam scores)
int[] studentScores = new int[10];


string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tGrade\n");

/* Foreach Statement Usage - outer:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")   
                studentScores = andrewScores;

    else if (currentStudent == "Andrew")   
                studentScores = andrewScores; 

   else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

   // Variables for calculating the average grade
   int sumAssignmentScores = 0;
   decimal currentStudentGrade = 0;
   int gradedAssignments = 0;

     /* The inner foreach loop sums assignment scores.
     Extra credit assignments are worth 10% of an exam score.
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        // check if the assignment is extra credit
        if ( gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
        sumAssignmentScores += score / 10; // Apply 10% weight for extra credit
   
    }

    // calculate the average grade
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    // Determine the letter grade based on the numeric grade.
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    
    // Display the score report information
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}
// Required for running in VS Code (keeps the Output window open to view results)
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();