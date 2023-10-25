using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaEnteroMayor.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de la aplicación
    /// </summary>
    internal class SumaEnteroImplementacion : SumaEnteroInterfaz
    {
        public void NumeroEntero()
        {
            int NumeroEscrito = NumeroPedido();
            int i = 0;
            for(int k = 1; k <= NumeroEscrito; k++)
            {
                i = i + k;
                if (k == NumeroEscrito)
                {
                    Console.Write(k + "=" + i );
                }
                else
                {
                    Console.Write(k + "+");
                }

            }
        }    
        /// <summary>
        /// Método para pedir un número al usuario
        /// </summary>
        /// <returns></returns>
         private int NumeroPedido()
            {
                int numero;
                Console.WriteLine("Introduzca un número entero y positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                return numero;
            }
        }

    }

