using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3.Entities
{
    class Employee
    {
        public double FixedSalary { get; set; }
        public double ComissionPerCar { get; set; }

        public Employee()
        {

        }

        public Employee(double fixedSalary, double comissionPerCar)
        {
            FixedSalary = fixedSalary;
            ComissionPerCar = comissionPerCar;
        }
    }
}
