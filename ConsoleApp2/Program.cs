
namespace ejercicio2_1
//ejercicio elavororado por jhon esteban ortiz pascuaza 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("escriba el numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba el numero");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine(b + " el resultado de divisor  " + a);
            }
            else
            {
                if (b % a == 0)
                {
                    Console.WriteLine(a + " el resultado de divisor " + b);
                }
                else
                {
                    Console.WriteLine("los numero digitados no son divisores ");
                }




            }
        }
    }
}