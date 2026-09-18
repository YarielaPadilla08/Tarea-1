using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_YARIELA_PADILLA_BADILLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tarea 1 - Programación II
            // Nombre del estudiante: Yariela Padilla
            //Fecha de creacion: 19/02/2026

            //variables de datos
            string numCedula;
            string nombreEmpleado;
            int codigoTipoEmpleado;
            float horasTrabajadas;
            float tarifaPorHora;

            // Solicitar información del usuario
            Console.WriteLine("Digite el número de cédula del empleado:");
            numCedula = Console.ReadLine();

            Console.WriteLine("Digite el nombre completo del empleado:");
            nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Seleccione el tipo de empleado (1 = Operario, 2 = Técnico, 3 = Profesional):");
            codigoTipoEmpleado = int.Parse(Console.ReadLine());

            // Validación del código ingresado (1 a 3)
            if (codigoTipoEmpleado < 1 || codigoTipoEmpleado > 3)
            {
                Console.WriteLine("Error: El tipo de empleado ingresado no existe en el sistema.");
                return;
            }

            Console.WriteLine("Ingrese la cantidad de horas laboradas:");
            horasTrabajadas = float.Parse(Console.ReadLine());

            // Comprobación de valor válido en horas
            if (horasTrabajadas < 0)
            {
                Console.WriteLine("Error: Las horas laboradas no pueden ser un valor negativo.");
                return;
            }

            Console.WriteLine("Ingrese el pago o precio por hora:");
            tarifaPorHora = float.Parse(Console.ReadLine());

            // Comprobación de valor válido en el precio por hora
            if (tarifaPorHora < 0)
            {
                Console.WriteLine("Error: La tarifa por hora no puede ser un valor negativo.");
                return;
            }

            // Cálculo del monto base inicial
            float salarioBase = horasTrabajadas * tarifaPorHora;

            // Variables para almacenar la etiqueta y el porcentaje según el tipo
            string categoriaTexto = "";
            float porcentajeAumento = 0f;

            if (codigoTipoEmpleado == 1)
            {
                porcentajeAumento = 0.15f; // 15% Operario
                categoriaTexto = "Operario";
            }
            else if (codigoTipoEmpleado == 2)
            {
                porcentajeAumento = 0.10f; // 10% Técnico
                categoriaTexto = "Técnico";
            }
            else if (codigoTipoEmpleado == 3)
            {
                porcentajeAumento = 0.05f; // 5% Profesional
                categoriaTexto = "Profesional";
            }

            // Realizar el resto de cálculos financieros obligatorios
            float montoAumento = salarioBase * porcentajeAumento;
            float salarioBruto = salarioBase + montoAumento;
            float deduccionCCSS = salarioBruto * 0.0917f; // Deducción CCSS (9.17%)
            float salarioNeto = salarioBruto - deduccionCCSS;

            // Despliegue del desglose final usando concatenación (+)
            Console.WriteLine("\n==== DESGLOSE DE SALARIO ====");
            Console.WriteLine("Cédula: " + numCedula);
            Console.WriteLine("Nombre Empleado: " + nombreEmpleado);
            Console.WriteLine("Tipo Empleado: " + categoriaTexto);
            Console.WriteLine("Salario por Hora: " + tarifaPorHora);
            Console.WriteLine("Cantidad de Horas: " + horasTrabajadas);
            Console.WriteLine("Salario Ordinario: " + salarioBase);
            Console.WriteLine("Aumento: " + montoAumento);
            Console.WriteLine("Salario Bruto: " + salarioBruto);
            Console.WriteLine("Deducción CCSS: " + deduccionCCSS);
            Console.WriteLine("Salario Neto: " + salarioNeto);
            Console.WriteLine("=====================================================");
        }
    }
}
