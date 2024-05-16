// Create a Dictionary to store student grades
Dictionary<string, int> grades = new Dictionary<string, int>();

// Add elements to the Dictionary
grades["Alice"] = 85;
grades["Bob"] = 90;
grades["Charlie"] = 75;

// Check if a key exists in the Dictionary
Console.WriteLine("ContainsKey('Bob'): " + grades.ContainsKey("Bob")); // Output: True
Console.WriteLine("ContainsKey('David'): " + grades.ContainsKey("David")); // Output: False

// Access a value by key
Console.WriteLine("Grade for Alice: " + grades["Alice"]); // Output: 85

// Update a value by key
grades["Charlie"] = 80;

// Remove an element from the Dictionary
grades.Remove("Bob");

// Print all key-value pairs in the Dictionary
Console.WriteLine("Dictionary elements:");
foreach (KeyValuePair<string, int> kvp in grades)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Get the count of key-value pairs in the Dictionary
Console.WriteLine("Count: " + grades.Count); // Output: 2

// Clear all elements from the Dictionary
grades.Clear();

// Check if the Dictionary is empty
Console.WriteLine("Is Empty: " + (grades.Count == 0)); // Output: True