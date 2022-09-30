namespace ejercicio5_1

//ejercicio elavorado por jhon esteban ortiz pascuaza 
{
    internal class Program
{
    static void Main(string[] args)
    {
        int baces, expo, resultado, contador;
        Console.Write("escriba la base : ");
        baces = Convert.ToInt32(Console.ReadLine());
        Console.Write("escriba el exponente : ");
        contador = expo = Convert.ToInt32(Console.ReadLine());

        resultado = 1;
        while (contador != 0)
        {
            resultado = resultado * baces;
            contador = contador - 1;
        }

        Console.WriteLine("Exponer {0} veces el numero {1} da un resultado de {2}", expo, baces, resultado);

    }


}
}