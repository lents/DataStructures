// Create a hash table to store student grades
using System.Collections;

Hashtable grades = new Hashtable();

// Add student grades to the hash table
grades["Alice"] = 85;
grades["Bob"] = 90;
grades["Charlie"] = 75;

// Retrieve and print grades
Console.WriteLine("Alice's grade: " + grades["Alice"]);
Console.WriteLine("Bob's grade: " + grades["Bob"]);
Console.WriteLine("Charlie's grade: " + grades["Charlie"]);

// Update a student's grade
grades["Charlie"] = 80;
Console.WriteLine("Charlie's updated grade: " + grades["Charlie"]);

// Check if a student's grade exists
string student = "Dave";
if (grades.ContainsKey(student))
{
    Console.WriteLine(student + "'s grade: " + grades[student]);
}
else
{
    Console.WriteLine(student + " is not found in the grade list.");
}