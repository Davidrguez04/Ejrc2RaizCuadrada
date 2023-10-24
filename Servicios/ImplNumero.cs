using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejrc2RaizCuadrada.Servicios
{
    /// <summary>
    /// iMPLEMENTACION DE LAS ACCIONES DEL MENU
    /// 241023 - David RA
    /// </summary>
    internal class ImplNumero:InterfazNumero
    {
        //método para pedir numero
        public int pedirNumero()
        {
            int num1;

            Console.WriteLine("Introduzca un número entero por consola: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            return num1;
        }
    }
}
