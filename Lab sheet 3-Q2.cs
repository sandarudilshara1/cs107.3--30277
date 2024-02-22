using System;

class Employee
{
    // Properties
    public int EmployeeID { get; }
    public string FullName { get; set; }
    public double Salary { get; private set; }

    // Constructor
    public Employee(int employeeID, string fullName, double salary)
    {
        EmployeeID = employeeID;
        FullName = fullName;
        Salary = salary;
    }

    // Method to display employee information
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Employee class
        Employee employee = new Employee(101, "John Doe", 50000);

        // Access and display employee ID
        Console.WriteLine($"Employee ID: {employee.EmployeeID}");

        // Update full name
        employee.FullName = "Jane Smith";

        // Attempt to modify salary directly from external code
        // This will result in a compile-time error because Salary has a private setter
        // employee.Salary = 60000; // Uncommenting this line will cause a compilation error

        // Display employee information
        employee.DisplayEmployeeInfo();
    }
}












