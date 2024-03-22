using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosSemana7
{
    internal class desafio3
    
    {
        static ArrayList lista = new ArrayList();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Mostrar elementos");
                Console.WriteLine("2. Agregar elemento");
                Console.WriteLine("3. Eliminar elemento");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese su opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarElementos();
                        break;
                    case "2":
                        AgregarElemento();
                        break;
                    case "3":
                        EliminarElemento();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void MostrarElementos()
        {
            Console.WriteLine("Elementos en la lista:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        static void AgregarElemento()
        {
            Console.Write("Ingrese el elemento a agregar: ");
            string elemento = Console.ReadLine();
            lista.Add(elemento);
            Console.WriteLine("Elemento agregado correctamente.");
        }

        static void EliminarElemento()
        {
            Console.Write("Ingrese el índice del elemento a eliminar: ");
            int indice;
            if (int.TryParse(Console.ReadLine(), out indice) && indice >= 0 && indice < lista.Count)
            {
                lista.RemoveAt(indice);
                Console.WriteLine("Elemento eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido. Por favor, ingrese un índice válido.");
            }
        }
    }
}
