using System;

class Employee
{
    private string name;
    private string designation;
    private int noofexperience;
    private double basicSalary;
    private double hra;
    private double ta;
    private double grosspay;
    private double insuranceAmount;

    
    
    public Employee(string name, string designation, int noofexperience, double basicSalary, double insuranceAmount)
    {
        this.name = name;
        this.designation = designation;
        this.noofexperience = noofexperience;
        this.basicSalary = basicSalary;
        this.insuranceAmount = insuranceAmount;

        
        hra = 0.1 * basicSalary;
        ta = 0.2 * basicSalary;
        grosspay = 0.15 * basicSalary;
    }

    
    public double CalculateSalary()
    {
        return basicSalary + hra + ta + insuranceAmount - grosspay;
    }

    
    public void Display()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee Designation: " + designation);
        Console.WriteLine("Employee No of Experience: " + noofexperience);
        Console.WriteLine("Employee Basic Salary: " + basicSalary);
        Console.WriteLine("Employee Insurance Amount: " + insuranceAmount);
        Console.WriteLine("Employee HRA: " + hra);
        Console.WriteLine("Employee TA: " + ta);
        Console.WriteLine("Employee GROSSPAY: " + grosspay);
        Console.WriteLine("Employee Salary: " + CalculateSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Nisha", "Doctor", 5,100000, 5000);
        emp1.Display();
        Employee emp2 = new Employee("Ayaz", "Engineer",300000, 7, 20000);
        emp2.Display();
    }
}