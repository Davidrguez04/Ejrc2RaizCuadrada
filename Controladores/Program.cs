using Ejrc2RaizCuadrada.Servicios;

namespace Ejrc2RaizCuadrada.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 241023 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>



        static void Main(string[] args)
        {

            /*Escriba un programa que solicite un número entero, lo recoja de la consola e indique si el número 
             * se puede expresar como el cuadrado de otro número entero, es decir:

            numeroEntero = numeroEntero2 * numeroEntero 2.

            El método que solicite el número deberá estar definido en un servicio. El método mostrará el mensaje 
            de petición 
            de número, recogerá el número escrito en la consola y lo devolverá al método main.
            El resto de la lógica podrá ir en el método main.*/

            //Llamada al método que imprime el mensaje por consola
            InterfazNumero ni =new ImplNumero();

            int num=ni.pedirNumero();
            
            //calculo de raiz cuadrada de un numero pedidopor pantalla
            double raiz = Math.Sqrt(num);

            //if para saber si el numero al hacerle la raiz da entero o no
            if (raiz*raiz==num)
            {
                Console.WriteLine("El numero "+num+" si se le hace la raiz cuadrada  da un entero");
            }
            else
            {
                Console.WriteLine("El numero " + num + " si se le hace la raiz cuadrada no da un entero");
            }




        }
    }
}
