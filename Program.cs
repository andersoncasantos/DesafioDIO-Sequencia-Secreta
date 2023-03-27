using System;
class Program

{
    public static void Main()

    {
        int tamanhoSequencia = Convert.ToInt32(Console.ReadLine());
        int quantidadeNumerosMarcados = 1;
        int ultimoNumeroLido = Convert.ToInt32(Console.ReadLine());
        int vi = 0;

        for (int i = 1; i < tamanhoSequencia; i++)
        {
            vi = Convert.ToInt32(Console.ReadLine());
            if (vi != ultimoNumeroLido)
            {
                quantidadeNumerosMarcados++;
            }
            ultimoNumeroLido = vi;
        }
        Console.WriteLine(quantidadeNumerosMarcados);
    }
}