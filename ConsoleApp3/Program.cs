namespace ejercicio3_1
//ejercicio elavorado por jhon esteban ortiz pascuaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("resta o suma ");
            Console.WriteLine("escriba el primer dato ");
            double num1, num2;
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el primer dato");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 1(suma) o 2(resta) para mirar el resultado");
            int opcion;

            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                double suma;
                suma = num1 + num2;
                Console.WriteLine("el total de la sumatoria es de : " + suma);
            }
            if (opcion == 2)
            {
                double resta;
                resta = num1 - num2;
                Console.WriteLine("el total de la resta es des: " + resta);

            }
            
        }
    }
}
