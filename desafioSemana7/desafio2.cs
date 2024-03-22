using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosSemana7
{
    internal class desafio2
    {
        static void CalcularDescuentos(double[,] compras)
        {
            // Definir los descuentos según las reglas
            double[] descuentos = { 0.05, 0.1, 0.15, 0.2, 0.25 };

            // Calcular el total de compras de cada cliente y otorgar descuentos
            for (int cliente = 0; cliente < compras.GetLength(0); cliente++)
            {
                double totalCompra = 0;

                // Calcular el total de compras del cliente
                for (int compra = 0; compra < compras.GetLength(1); compra++)
                {
                    totalCompra += compras[cliente, compra];
                }

                // Aplicar descuento según el total de compras
                if (totalCompra >= 500)
                {
                    totalCompra -= totalCompra * descuentos[4];
                }
                else if (totalCompra >= 400)
                {
                    totalCompra -= totalCompra * descuentos[3];
                }
                else if (totalCompra >= 300)
                {
                    totalCompra -= totalCompra * descuentos[2];
                }
                else if (totalCompra >= 200)
                {
                    totalCompra -= totalCompra * descuentos[1];
                }
                else if (totalCompra >= 100)
                {
                    totalCompra -= totalCompra * descuentos[0];
                }

                Console.WriteLine("Cliente " + (cliente + 1) + ": Total de compras = " + totalCompra.ToString("C"));
            }
        }

        static void Main(string[] args)
        {
            // Ejemplo de arreglo bidimensional con los montos de las últimas 5 compras de 5 clientes
            double[,] compras = {
            { 50, 100, 150, 200, 250 },
            { 300, 400, 500, 600, 700 },
            { 200, 300, 400, 500, 600 },
            { 100, 150, 200, 250, 300 },
            { 350, 450, 550, 650, 750 }
        };

            CalcularDescuentos(compras);
        }
    }
}
