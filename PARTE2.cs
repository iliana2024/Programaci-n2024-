namespace Desafios
{
    class Program
    {
        // Variables globales para almacenar la puntuación más alta y el jugador récord
        static int puntuacionMaxima = 0;
        static string jugadorRecord = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de puntajes.");

            // Simulación de puntaje obtenido por el jugador (puedes modificarlo según tus necesidades)
            int puntajeObtenido = 120;
            string nombreJugador = "Juan";

            // Llamada al método para verificar el puntaje
            VerificarPuntaje(puntajeObtenido, nombreJugador);
        }

        // Método para verificar el puntaje
        static void VerificarPuntaje(int puntaje, string nombre)
        {
            if (puntaje > puntuacionMaxima)
            {
                // Si el puntaje es mayor que la puntuación más alta, actualizamos los valores globales
                puntuacionMaxima = puntaje;
                jugadorRecord = nombre;

                Console.WriteLine($"La nueva puntuación más alta es {puntuacionMaxima}.");
                Console.WriteLine($"La puntuación más alta fue lograda por {jugadorRecord}.");
            }
            else
            {
                Console.WriteLine($"La puntuación más alta de {puntuacionMaxima} no se ha podido superar, y aún está en manos de {jugadorRecord}.");
            }
        }
    }
}