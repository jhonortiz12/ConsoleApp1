using System;
namespace ejercicio1_2
{
    //ejercicio eleavorado por jhon esteban ortiz pascuaza 

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el dia el mes y el año ");
            int dia, mes, año;
            Console.WriteLine("escriba  el dia");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba el mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba el año");
            año = int.Parse(Console.ReadLine());
            if (dia > 32)
            {
                dia = 31;
                mes = mes + 1;
                Console.WriteLine("la fecha es: " + dia + ":" + mes + ":" + año);
                if (mes > 13)
                {
                    mes = 12;
                    año = año + 1;
                    Console.WriteLine(" la fecha es : " + dia + ":" + mes + ":" + año);
                }
            }
            else
            {
                dia = dia + 1;
                Console.WriteLine("la fecha es : " + dia + ":" + mes + ":" + año);
            }


            if (mes > 13)
            {
                mes = 12;
                año = año + 1;
                Console.WriteLine("la fecha es : " + dia + ":" + mes + ":" + año);
            }




        }
    }
}