namespace GenericList;

class Employee
{
    public string mName;
    public int mSalary;

    public Employee(string name, int salary)
    {
        mName = name;
        mSalary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // TODO: Create a new empty List for Employee objects
        // TODO: Add some records to the list
        List<Employee> empList = new List<Employee>(10)
        {
            new Employee("John Doe", 50000),
            new Employee("Jane Smith", 60000),
            new Employee("Nick Slick", 55000),
            new Employee("Mildred Mintz", 70000),
        };

        // TODO: Inspect some List properties
        Console.WriteLine($"empList Capacity: {empList.Capacity}");
        Console.WriteLine($"empList Count: {empList.Count}");

        // TODO: Use Exists() and Find()
        if (empList.Exists(HighPay))
        {
            Console.WriteLine("Highly pay employee found!");
        }
        Employee e = empList.Find(x => x.mName.StartsWith("J"));
        if (e != null)
        {
            Console.WriteLine($"Found employee whose name starts with J: {e.mName}");
        }
        // TODO: Use ForEach to iterate over each item
        empList.ForEach(TotalSalaries);
        Console.WriteLine($"Total payroll is: {total}");
        Console.WriteLine("\nPress Enter key to continue...");
        Console.ReadLine();
    }

    // Iterator function for the ForEach method
    static int total = 0;
    static void TotalSalaries(Employee e)
    {
        total += e.mSalary;
    }

    // delegate function to use for the Exists method
    static Boolean HighPay(Employee emp)
    {
        return emp.mSalary >= 65000;
    }
}
