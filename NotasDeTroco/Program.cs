using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int venda = 0, pago = 0, troco = 0, ncem = 0, ncinq = 0, nvinte = 0, ndez = 0, ncinco = 0, ndois = 0;

        Console.WriteLine("Digite o valor da venda: ");
        venda = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do pagamento");
        pago = int.Parse(Console.ReadLine());

        troco = pago - venda;

        Console.WriteLine("O valor do troco é: " + troco);
        while (troco > 1)
        {
            if (troco >= 100)
            {
                ncem++;
                troco -= 100;
            }
            else
            {
                if(troco >= 50)
                {
                    ncinq++;
                    troco -= 50;
                }
                else
                {
                    if(troco >= 20)
                    {
                        nvinte++;
                        troco -= 20;
                    }
                    else
                    {
                        if(troco >= 10)
                        {
                            ndez++;
                            troco -= 10;
                        }
                        else
                        {
                            if(troco >= 5)
                            {
                                ncinco++;
                                troco -= 5;
                            }
                            else
                            {
                                ndois++;
                                troco -= 2;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("Número de notas de 100: " + ncem);
        Console.WriteLine("Número de notas de 50: " + ncinq);
        Console.WriteLine("Número de notas de 20: " + nvinte);
        Console.WriteLine("Número de notas de 10: " + ndez);
        Console.WriteLine("Número de notas de 5: " + ncinco);
        Console.WriteLine("Número de notas de 2: " + ndois);
        if(troco == 1)
            Console.WriteLine("Mais uma moeda de 1 real");

    }
}