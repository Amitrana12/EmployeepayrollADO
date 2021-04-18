using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeManagment;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeManagment.Tests
{
    [TestClass()]
    public class SalaryTests
    {
        [TestMethod()]
        public void GivenSalaryDataAbleToUpdateSalaryDetails()
        {
            Salary salary = new Salary();
            SalaryUpdateModel updateModel = new SalaryUpdateModel()
            {
                salaryId = 2,
                Month = "Jan",
                EmployeeSalary = 1300,
                EmployeeId = 5
            };

            int EmpSalary = salary.UpdateEmployeeSalary(updateModel);

            Assert.AreEqual(updateModel.EmployeeSalary, EmpSalary);
        }

    }
}