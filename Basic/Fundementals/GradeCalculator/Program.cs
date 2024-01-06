// my code:
int currentAssignments = 5;

int sophia1 = 93, sophia2 = 87, sophia3 = 98, sophia4 = 95, sophia5 = 100;
int nicolas1 = 80, nicolas2 = 83, nicolas3 = 82, nicolas4 = 88, nicolas5 = 85;
int zahirah1 = 84, zahirah2 = 96, zahirah3 = 73, zahirah4 = 85, zahirah5 = 79;
int jeong1 = 90, jeong2 = 92, jeong3 = 98, jeong4 = 100, jeong5 = 97;

// Initialize sums to 0 for each student
int sophiaSum = 0, nicolasSum = 0, zahirahSum = 0, jeongSum = 0;

// Accumulate scores for each student
sophiaSum += sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolasSum += nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zahirahSum += zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeongSum += jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// Calculate average scores for each student
decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

// Print the results
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

