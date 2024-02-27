// See https://aka.ms/new-console-template for more information
using System;

// Create an Employee class with Id, FirstName, and LastName properties
public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to check if two Employee objects are equal based on their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null
        if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            return true;

        // Check if either object is null
        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            return false;

        // Compare the Id properties
        return employee1.Id == employee2.Id;
    }

    // Overload the "!=" operator to check if two Employee objects are not equal based on their Id property
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Use the negation of the equality operator
        return !(employee1 == employee2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using the overloaded operators and display the results
        Console.WriteLine($"Are the employees equal? {employee1 == employee2}"); // Output: False
        Console.WriteLine($"Are the employees not equal? {employee1 != employee2}"); // Output: True

        // Wait for user input to close the console window
        Console.ReadLine();
    }
}

