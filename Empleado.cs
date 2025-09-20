using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExpertGrasp
{
    internal class Empleado
    {

        private string nombre;
        private decimal salarioBase;
        private decimal horasExtras;
        private decimal tasaDeImpuestos;

        // Constructor para inicializar los datos del empleado.
        public Empleado(string nombre, decimal salarioBase, decimal horasExtras, decimal tasaDeImpuestos)
        {
            this.nombre = nombre;
            this.salarioBase = salarioBase;
            this.horasExtras = horasExtras;
            this.tasaDeImpuestos = tasaDeImpuestos;
        }

        // Este método aplica el principio Experto en Información.
        // La responsabilidad de calcular el salario se delega a la clase
        // que es dueña de los datos.
        public decimal CalcularSalarioNeto()
        {
            // El factor de pago por hora extra se podría gestionar aquí mismo
            // o ser pasado como parámetro si fuera variable.
            decimal pagoPorHoraExtra = 25.00M;
            decimal salarioBruto = this.salarioBase + (this.horasExtras * pagoPorHoraExtra);

            // Cálculo de los impuestos
            decimal impuestos = salarioBruto * this.tasaDeImpuestos;

            return salarioBruto - impuestos;
        }

        public void MostrarDetallesSalario()
        {
            Console.WriteLine("--- Detalles de Salario de " + this.nombre + " ---");
            Console.WriteLine($"Salario Base: ${this.salarioBase:N2}");
            Console.WriteLine($"Horas Extras: {this.horasExtras}");
            Console.WriteLine($"Salario Neto: ${this.CalcularSalarioNeto():N2}");
            Console.WriteLine("------------------------------------");
        }








    }
}
