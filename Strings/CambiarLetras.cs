using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class CambiarLetras
    {
        public static string frase { get; set; }
        static void Main(string[] args)
        {
            frase = "Hola Soy Una Frase";
            if (esLetra(frase))
            {
                cambiar(frase);
            }
        }
        public static void cambiar(String frase)
        {
            //string varInput1 = Console.ReadLine();
            string varInput1 = frase;
            if (varInput1.Equals(""))
            {
                Console.WriteLine("ingrese el texto correcto por favor");
            }
            else
            {
                Console.WriteLine(frase);
                Console.WriteLine("Menu:");
                Console.WriteLine("1. mostrar texto en mayuscula");
                Console.WriteLine("2. mostrar texto en minuscula");
                Console.WriteLine("3. contar caracteres:");
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\n" + varInput1.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\n" + varInput1.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\n" + varInput1.Length);
                }
                else
                {
                    Console.WriteLine("\n" + "No ha ingresado una opcion valida");
                }
                Console.ReadLine();
            }

        }
        public static Boolean esLetra(object obj)
        {
            try
            {
                Int32.Parse(obj.ToString());
                Console.Write(obj);
                return false;
            }
            catch (Exception e)
            {
                return true;
                Console.Write(obj);
            }
        } }
}
