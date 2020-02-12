using System;
using System.Collections.Generic;
using System.Globalization;
using Polimorfismo.Entities;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uma empresa possui funcionários próprios e terceirizados.
                Para cada funcionário, deseja-se registrar nome, horas
                trabalhadas e valor por hora. Funcionários terceirizados
                possuem ainda uma despesa adicional.
                O pagamento dos funcionários corresponde ao valor da hora
                multiplicado pelas horas trabalhadas, sendo que os
                funcionários terceirizados ainda recebem um bônus
                correspondente a 110% de sua despesa adicional.
                Fazer um programa para ler os dados de N funcionários (N
                fornecido pelo usuário) e armazená-los em uma lista. Depois
                de ler todos os dados, mostrar nome e pagamento de cada
                funcionário na mesma ordem em que foram digitados. */
            List<Employee> lista = new List<Employee>();

            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n;i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced(y / n) ?");
                char l = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                if (l == 'n')
                {
                    lista.Add(new Employee(name,hours,valuePerHour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
            }
            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in lista)
            {
                 Console.WriteLine(e.ToString());
            }
            
            
        }
    }
}
