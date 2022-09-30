namespace ejercicio4_10

//ejercicio elavorado por jhon esteban ortiz pascuaza 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba un numero para saber si esta entre 100 y 10 ");
            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 <= 10)
            {
                Console.WriteLine("El numero dijitado  ese encuentra  dentro de los 10 primeros numeros");
            }
            else
            {
                Console.WriteLine("El numero dijitado no  ese encuentra dentro de los 10 primeros");
            }

            if (num1 <= 100)
            {
                Console.WriteLine("El numero dijitado  ese encuentra dentro de los 100 primeros numeros");
            }
            else
            {
                Console.WriteLine("El numero dijitado  ese encuentra dentro de los 100 primeros numeros");
            }



        }
    }
}

