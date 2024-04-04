namespace desafiosSEM7
{
    public class Calculadora
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {

        }

        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Raiz(double a)
        {
            return Math.Sqrt(a);
        }

        public double Modulo(double a, double b)
        {
            return a % b;
        }

        public double Logaritmo(double a, double newBase)
        {
            return Math.Log(a, newBase);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadoraNormal = new Calculadora("Casio", "123");
            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica("Texas Instruments", "456");

            // Ejemplo de uso de la calculadora básica
            double resultadoSuma = calculadoraNormal.Sumar(5, 3);
            Console.WriteLine("Suma: " + resultadoSuma);

            // Ejemplo de uso de la calculadora científica
            double resultadoPotencia = calculadoraCientifica.Potencia(2, 3);
            Console.WriteLine("Potencia: " + resultadoPotencia);
        }
    }
}
