namespace SalaryProcessingClassLibrary
{
    public class SalaryProcessing
    {
            private int code;
            private string name;
            private double salary;
            private string rank;

            public int EmployeeCode { get { return code; } set { code = value; } }
            public string EmployeeName { get { return name; } set { name = value; } }
            public double EmployeeSalary { get { return salary; } set { salary = value; } }
            public string EmployeeRank { get { return rank; } set { rank = value; } }


            public double SSFContribution()
            {
                double ssfcont;
                return ssfcont = EmployeeSalary * 0.055;
            }

            public double Tax()
            {
                double newsalary = EmployeeSalary;
                double ssf_contribution = newsalary * 0.055;
                double taxable_income = newsalary - ssf_contribution;
                double tax;
                if (taxable_income <= 100)
                {
                    tax = 0;
                }
                else if (taxable_income <= 135)
                {
                    tax = (taxable_income - 100) * 0.05;
                }
                else if (taxable_income <= 227)
                {
                    tax = (35 * 0.05) + ((taxable_income - 135) * 0.1);
                }
                else if (taxable_income <= 2160)
                {
                    tax = (35 * 0.05) + (92 * 0.1) + ((taxable_income - 227) * 0.175);
                }
                else
                {
                    tax = (35 * 0.05) + (92 * 0.1) + (1933 * 0.175) + ((taxable_income - 2160) * 0.25);
                }
                return tax;
            }
            public double NetSalary()
            {
                return EmployeeSalary - Tax() -  SSFContribution();
            }
        

    }
}