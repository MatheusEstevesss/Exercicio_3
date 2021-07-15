using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_3.Entities
{
    class Sale : Employee
    {
        public double ValueSales { get; set; }
        public int SoldCars { get; set; }

        public Sale()
        {

        }

        public Sale(double fixedSalary, double comissionPerCar, double valueSales, int soldCars) : base(fixedSalary, comissionPerCar)
        {
            ValueSales = valueSales;
            SoldCars = soldCars;
        }

        public double TotalPayment()
        {
            double totalPerCar = ComissionPerCar * SoldCars;
            double totalPerSales = ValueSales * 0.05;
            return totalPerCar + totalPerSales + FixedSalary;
        }
    }
}