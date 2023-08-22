using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
             // PARTE I. Declaración y asignación de valores
             Console.WriteLine("Inicio");
            string? departamento, municipio, ciudad;
            Console.Write("Ingrese el nombre del departamento: ");
            departamento = Console.ReadLine();
            Console.Write("Ingrese el nombre del municipio: ");
            municipio = Console.ReadLine();
            Console.Write("Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();

            string colonia = "Miramonte ";
            string colorCasa = "Blanca";

            int aniosResidencia, edadActual;
            Console.Write("Ingrese los años de vivir en su residencia actual: ");
            aniosResidencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su edad actual: ");
            edadActual = Convert.ToInt32(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(1992, 5, 3); 
            DateTime fechaActual = DateTime.Now;

            // PARTE II. Asignación de funciones
            // Funciones para cadenas de texto
            Console.WriteLine("\nFunciones para cadenas de textos:");
            Console.WriteLine($"Comparación de cadenas: {string.Compare(colonia, colorCasa)}");
            Console.WriteLine($"Concatenación de texto: {string.Concat(colonia, colorCasa)}");
            Console.WriteLine($"Mayúsculas: {colonia.ToUpper()}");
            Console.WriteLine($"Limpiado de cadena: {colonia.Trim()}");
            Console.WriteLine($"Longitud de cadena (colonia): {colonia.Length}");
            Console.WriteLine($"Longitud de cadena (colorCasa): {colorCasa.Length}");

            // Funciones para fechas
            Console.WriteLine("\nFunciones con Fechas:");
            Console.WriteLine($"Fecha de nacimiento formateada: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            DateTime fechaNacimientoMas2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);
            Console.WriteLine($"Fecha de nacimiento + 2 semanas: {fechaNacimientoMas2Semanas.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Fecha actual + 2 semanas: {fechaActualMas2Semanas.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Comparación de fechas: fechaNacimiento > fechaActual: {fechaNacimiento > fechaActual}, fechaNacimiento < fechaActual: {fechaNacimiento < fechaActual}");

            // PARTE III. Impresión de valores en consola
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine($"Departamento: {departamento}");
            Console.WriteLine($"Municipio: {municipio}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Colonia: {colonia}");
            Console.WriteLine($"Color de casa: {colorCasa}");
            Console.WriteLine($"Años de residencia: {aniosResidencia}");
            Console.WriteLine($"Edad actual: {edadActual}");
            Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento}");
            Console.WriteLine($"Fecha actual: {fechaActual}");
            //Auto evaluacion NOTA:10.
        }
    }
}