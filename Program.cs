namespace InformationExpertGrasp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creamos una instancia de cada empleado con sus datos.
            var juan = new Empleado("Juan Pérez", 50000.00M, 10.00M, 0.15M);
            var ana = new Empleado("Ana Gómez", 65000.00M, 5.00M, 0.20M);

            // Le pedimos a cada empleado que muestre sus propios detalles de salario.
            // La clase Program no necesita saber la lógica del cálculo.
            juan.MostrarDetallesSalario();
            ana.MostrarDetallesSalario();
        }
    }
}
