using System;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cedula: ");
            string cedula = Console.ReadLine();

            Console.Write("Digite el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Digite el tipo de empleado (1-Operario, 2-Tecnico, 3-Profesional): ");
            int tipo = Int32.Parse(Console.ReadLine());

            Console.Write("Digite la cantidad de horas: ");
            double horas = Double.Parse(Console.ReadLine());

            Console.Write("Digite el precio por hora: ");
            double precioHora = Double.Parse(Console.ReadLine());

            double salarioOrdinario = horas * precioHora;
            double aumento = 0;
            string tipoEmpleado = "";

            if (tipo == 1)
            {
                aumento = salarioOrdinario * 0.15;
                tipoEmpleado = "Operario";
            }
            else if (tipo == 2)
            {
                aumento = salarioOrdinario * 0.10;
                tipoEmpleado = "Tecnico";
            }
            else if (tipo == 3)
            {
                aumento = salarioOrdinario * 0.05;
                tipoEmpleado = "Profesional";
            }

            double salarioBruto = salarioOrdinario + aumento;
            double deduccion = salarioBruto * 0.0917;
            double salarioNeto = salarioBruto - deduccion;

            Console.WriteLine("\n--- Datos del empleado ---");
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Nombre empleado: " + nombre);
            Console.WriteLine("Tipo empleado: " + tipoEmpleado);
            Console.WriteLine("Salario por hora: " + precioHora.ToString("N2"));
            Console.WriteLine("Cantidad de horas: " + horas);
            Console.WriteLine("Salario ordinario: " + salarioOrdinario.ToString("N2"));
            Console.WriteLine("Aumento: " + aumento.ToString("N2"));
            Console.WriteLine("Salario bruto: " + salarioBruto.ToString("N2"));
            Console.WriteLine("Deduccion CCSS: " + deduccion.ToString("N2"));
            Console.WriteLine("Salario neto: " + salarioNeto.ToString("N2"));

            Console.ReadKey();
        }
    }
}