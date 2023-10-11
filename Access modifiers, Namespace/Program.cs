
//TASK 1
//using System;

//class Employee 
//{
//    public string Name { get; set; }
//    public bool IsSuccessful { get; set; }
//    public decimal Salary { get; set; }

//    public Employee(string name, bool isSuccessful, decimal salary)
//    {
//        Name = name;
//        IsSuccessful = isSuccessful;
//        Salary = salary;
//    }
//}

//class Assistant : Manager
//{
//    public Assistant(string name, bool isSuccessful, decimal salary)
//        : base(name, isSuccessful, salary)
//    {

//    }

//    public void GetFeedback(Employee employee)
//    {
//        if (employee.IsSuccessful)
//        {
//            Console.WriteLine($"{employee.Name} is successful. Promoting...");
//            GetPromotion(employee); 
//        }
//        else
//        {
//            Console.WriteLine($"{employee.Name} is not successful. No promotion.");
//        }
//    }
//}

//class Manager : Employee
//{
//    public Manager(string name, bool isSuccessful, decimal salary)
//        : base(name, isSuccessful, salary)
//    {

//    }

//    protected Employee GetPromotion(Employee employee)
//    {
//        Console.WriteLine($"{Name} is getting a promotion.");
//        Salary += 100;
//        return this;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Manager manager = new Manager("Murad", true, 1000);
//        Assistant assistant = new Assistant("Emil", false, 800);

//        assistant.GetFeedback(manager);
//        Console.WriteLine($"New Salary of {manager.Name}: {manager.Salary}");
//    }
//}

//TASK 2


//using System.Text.RegularExpressions;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student();


//        Console.Write("Please input name (first letter should large , digit shouldn't be , space shouldn't be): ");
//        student.Name = Console.ReadLine();

//        Console.Write("Input age (should be more than 0): ");
//        student.Age = byte.Parse(Console.ReadLine());

//        Console.Write("Please input grade (between 0 and 100): ");
//        student.Grade = byte.Parse(Console.ReadLine());
//    }
//}

//class Student
//{
//    private string name;
//    private byte age;
//    private byte grade;

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            while (!Regex.IsMatch(value, namepattern))
//            {
//                Console.WriteLine("Name wrong input. Please try again.");
//                value = Console.ReadLine();
//            }
//            name = value;
//        }
//    }

//    public byte Age
//    {
//        get { return age; }
//        set
//        {
//            while (value <= 0 || value >= 150)
//            {
//                Console.WriteLine("Age wrong input. Please try again.");
//                value = byte.Parse(Console.ReadLine());
//            }
//            age = value;
//        }
//    }

//    public byte Grade
//    {
//        get { return grade; }
//        set
//        {
//            while (value < 0 || value > 100)
//            {
//                Console.WriteLine("Grade wrong input.Please try again");
//                value = byte.Parse(Console.ReadLine());
//            }
//            grade = value;
//        }
//    }





//    string namepattern = ("^[A-Z][A-Za-z\\s]*$");
}