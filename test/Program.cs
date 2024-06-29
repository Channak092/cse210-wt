public class Employee  
{  
    // Private field to store employee's salary  
    private decimal _salary;  
  
    // Public property to get and set employee's salary  
    public decimal Salary  
    {  
        get { return _salary; }  
        set  
        {  
            if (value &lt; 0)  
            {  
                throw new ArgumentException("Salary cannot be negative");  
            }  
            _salary = value;  
        }  
    }  
  
    // Public method to increase salary by a certain percentage  
    public void IncreaseSalary(decimal percentage)  
    {  
        _salary += (_salary * (percentage / 100));  
    }  
  
    // Public method to display employee's salary  
    public void DisplaySalary()  
    {  
        Console.WriteLine("Employee's salary is: " + _salary);  
    }  
}  
  
class Program  
{  
    static void Main(string[] args)  
    {  
        Employee emp = new Employee();  
        emp.Salary = 50000; // Set salary through public property  
        emp.IncreaseSalary(10); // Increase salary by 10%  
        emp.DisplaySalary(); // Display updated salary  
    }  
}  
