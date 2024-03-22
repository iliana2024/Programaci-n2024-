namespace DesafiosSemana7
{
    class ToTiTo
    {
        static char[,] tablero = new char[3, 3]; // Tablero 3x3

        static void InicializarTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }
        }

        static void ImprimirTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("-----");
                }
            }
        }

        static bool VerificarGanador(char jugador)
        {
            // Verificar filas y columnas
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador)
                {
                    return true; // Ganador en fila
                }
                if (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador)
                {
                    return true; // Ganador en columna
                }
            }

            // Verificar diagonales
            if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador)
            {
                return true; // Diagonal principal
            }
            if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador)
            {
                return true; // Diagonal inversa
            }

            return false;
        }

        static void JugarToTiTo()
        {
            char jugadorActual = 'X'; // Comienza el jugador X
            bool hayGanador = false;
            InicializarTablero();

            Console.WriteLine("Bienvenido al juego de ToTiTo (Tres en Raya)!");
            ImprimirTablero();

            for (int jugada = 1; jugada <= 9; jugada++)
            {
                Console.WriteLine("Turno del jugador " + jugadorActual);
                Console.Write("Fila (0-2): ");
                int fila = int.Parse(Console.ReadLine());
                Console.Write("Columna (0-2): ");
                int columna = int.Parse(Console.ReadLine());

                if (tablero[fila, columna] != ' ')
                {
                    Console.WriteLine("Esa casilla ya está ocupada. ¡Intenta de nuevo!");
                    jugada--;
                    continue;
                }

                tablero[fila, columna] = jugadorActual;
                ImprimirTablero();

                if (VerificarGanador(jugadorActual))
                {
                    Console.WriteLine("¡Jugador " + jugadorActual + " ha ganado!");
                    hayGanador = true;
                    break;
                }

                jugadorActual = (jugadorActual == 'X') ? 'O' : 'X'; // Cambiar de jugador
            }

            if (!hayGanador)
            {
                Console.WriteLine("¡Empate!");
            }
        }

        static void Main(string[] args)
        {
            JugarToTiTo();
        }
    }
}
