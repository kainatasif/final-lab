using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public interface HourlyEmploye : Employee
    {

        String EmployeeId {
            get; }
        String EmployeeName { get; set; }
        string EmployeeType { get; set; }
        int CalHourlyPay();
        public interface SalaryEmploye
        {
            int EmployeeID { get; set; }
            String Employeename { get; set; }
            int Employeetype { get; set; }
            Employee Employee { get; set; }

            int Calculatepay();
            String GenerateReport();
        }
    {
Calculate_salary()
        {
            if (hoursWorked > BASE_Hours)
            {
                basepay = houlyPayate * BASE_HOUS;
                overtimeHours = HoursWorked - BASE_HOUS;
                overtimePay = overtimHours * houlyPayRat * OVERTIME_RAE;
                unitPay = 3 * unit pouc;
                Gosspay = basePay + overtimePay + unitPay
                    }
        }

    }

    int CalNoOfUnit();
    }
}