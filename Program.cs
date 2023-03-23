using SalaryProcessingClassLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        /*
        // Hard coding of the employee details
        var salarydetails = new SalaryProcessing
        {
            EmployeeCode = 5,
            EmployeeName = "Nathaniel Mensah",
            EmployeeSalary = 3200,
            EmployeeRank = "Constable of the Police Service"        
        };
        Console.WriteLine("Name of Worker: " + salarydetails.EmployeeName);
        Console.WriteLine("Rank of Worker: " + salarydetails.EmployeeRank);
        Console.WriteLine("Gross Salary of Worker: " + salarydetails.EmployeeSalary);
        Console.WriteLine("Social Security Contribution: " + salarydetails.ssf_contribution());
        Console.WriteLine("Tax of Worker: " + salarydetails.Tax());
        Console.WriteLine("Net Salary of Worker: " + salarydetails.NetSalary()); */

        
        //console provision of employee details
        var salarydetails2 = new SalaryProcessing();
        Console.WriteLine("Please Enter Employee Name");
        salarydetails2.EmployeeName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Please Enter Employee Salary");
        salarydetails2.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Name of Employee: " + salarydetails2.EmployeeName);
        Console.WriteLine("Gross Salary of Employee: " + salarydetails2.EmployeeSalary);
        Console.WriteLine("Social Security Fund Contribution: " + salarydetails2.SSFContribution());
        Console.WriteLine("Tax of Employee: " + salarydetails2.Tax());
        Console.WriteLine("Net Salary of Employee: " + salarydetails2.NetSalary());
        

        /*
        // Hard coding
        var studentinfo = new Student();
        studentinfo.StudentID = 1055;
        studentinfo.StudentName = "Nathaniel Kwodwo Mensah";
        studentinfo.StudentScores = new List<double> { 80, 90, 60, 77 };
    
        Console.WriteLine("ID: " + studentinfo.StudentID);
        Console.WriteLine("Name: " + studentinfo.StudentName);
        Console.WriteLine("Scores: " + string.Join(", ", studentinfo.StudentScores));
        Console.WriteLine("Average: " + studentinfo.average());
        Console.WriteLine("Grade: " + studentinfo.Grade());
        Console.ReadLine();   
        */

        /*
        //User friendly code
        var studentinfo2 = new Student();
        Console.WriteLine("Enter student ID:");
        studentinfo2.StudentID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student name:");
        studentinfo2.StudentName = Console.ReadLine();

        Console.WriteLine("Enter student scores (separated by space):");
        studentinfo2.StudentScores = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        Console.WriteLine("Student ID: " + studentinfo2.StudentID);
        Console.WriteLine("Student Name: " + studentinfo2.StudentName);
        Console.WriteLine("Student Scores: " + string.Join(", ", studentinfo2.StudentScores));
        Console.WriteLine("Average Score: " + studentinfo2.average());
        Console.WriteLine("Grade: " + studentinfo2.Grade());
        Console.ReadLine();
        */

    }


}


public class Student
{
    private int ID;
    private string name;
    private List<double> scores;

    public int StudentID { get { return ID; } set { ID = value; } }
    public string StudentName { get { return name; } set { name = value; } }
    public List<double> StudentScores { get { return scores; } set { scores = value; } }

    
    public double average()
    {
        double sum = 0;
        foreach (double score in scores)
        {
            sum += score;
        }
        return sum / scores.Count;
    }

    public double average(List<double> scores)
    {
        double sum = 0;
        foreach (double score in scores)
        {
            sum += score;
        }
        return sum / scores.Count;
    }

    public string Grade()
    {
        double average1 = average();
        if (average1 >= 80 && average1 <= 100)
        {
            return "Grade A";
        }
        else if (average1 >= 60 && average1 < 80)
        {
            return "Grade B";
        }
        else if (average1 >= 40 && average1 < 60)
        {
            return "Grade C";
        }
        else if (average1 >= 0 && average1 < 40)
        {
            return "Grade F";
        }
        else
        {
            return "Grade Z";
        }
    }
}





