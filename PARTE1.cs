namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularIngresos();

            // Invocación de los métodos de la calculadora
            int resultadoSuma = Calculadora.Sumar(10, 5);
            int resultadoResta = Calculadora.Restar(10, 5);
            int resultadoMultiplicacion = Calculadora.Multiplicar(10, 5);
            double resultadoDivision = Calculadora.Dividir(10, 5);

            Console.WriteLine($"Resultado de la suma: {resultadoSuma}");
            Console.WriteLine($"Resultado de la resta: {resultadoResta}");
            Console.WriteLine($"Resultado de la multiplicación: {resultadoMultiplicacion}");
            Console.WriteLine($"Resultado de la división: {resultadoDivision}");

            // Método con Try-Catch-Finally para sumar dos valores
            try
            {
                int valor1 = int.Parse(Console.ReadLine());
                int valor2 = int.Parse(Console.ReadLine());
                int suma = valor1 + valor2;
                Console.WriteLine($"La suma es: {suma}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }

        static void CalcularIngresos()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            double suma = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingrese la cantidad del mes {i}: ");
                double ingreso = double.Parse(Console.ReadLine());
                suma += ingreso;
            }

            double promedio = suma / 3;
            Console.WriteLine($"Hola {nombre}, en total ganaste ${suma:F2} y promediaste ${promedio:F2}.");
        }
    }

    class Calculadora
    {
        public static int Sumar(int a, int b) => a + b;
        public static int Restar(int a, int b) => a - b;
        public static int Multiplicar(int a, int b) => a * b;
        public static double Dividir(int a, int b) => (double)a / b;
    }
}
