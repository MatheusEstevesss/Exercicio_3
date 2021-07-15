using Exercicio_3.Entities;
using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o número de carros vendido por esse vendedor: ");
            int soldCars = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor total das vendas deste vendedor: ");
            double valueSales = double.Parse(Console.ReadLine());

            Console.Write("Escreva o valor do salário fixo deste vendedor: ");
            double fixedSalary = double.Parse(Console.ReadLine());

            Console.Write("Escreva o valor que o vendedor ganha por carro vendido: ");
            double comissionPerCar = double.Parse(Console.ReadLine());

            Sale sale = new Sale(fixedSalary, comissionPerCar, valueSales, soldCars);

            Console.WriteLine();
            Console.WriteLine($"O valor a ser pago a este vendedor é: {sale.TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
