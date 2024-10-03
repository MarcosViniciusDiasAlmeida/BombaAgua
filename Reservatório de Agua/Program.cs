using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int nivelAgua = random.Next(0, 101); 
        bool bombaLigada = false;
        int ciclosBomba = 0;

        Console.WriteLine($"Nível atual da água: {nivelAgua}%");

        if (nivelAgua <= 20)
        {
            Console.WriteLine("Boia A: Reservatório quase vazio. Ligando a bomba...");
            bombaLigada = true;
        }
        else if (nivelAgua >= 80)
        {
            Console.WriteLine("Boia B: Reservatório quase cheio. Não é necessário ligar a bomba.");
            bombaLigada = false;
        }
        else
        {
            Console.WriteLine("Nível de água estável. A bomba não precisa ser acionada.");
        }

        
        bool erroBoias = random.Next(0, 10) < 2; 

        if (erroBoias)
        {
            Console.WriteLine("Erro: As boias indicam informações contraditórias.");
            Console.WriteLine("Manutenção necessária nas boias.");
        }
        else
        {
            Console.WriteLine("As boias estão funcionando corretamente.");
        }

        
        if (!erroBoias)
        {
            Console.WriteLine("\nDeseja ligar ou desligar a bomba manualmente? (1 - Ligar, 2 - Desligar, 3 - Manter estado atual)");
            string input = Console.ReadLine();

            if (input == "1")
            {
                bombaLigada = true;
                Console.WriteLine("Bomba ligada manualmente.");
            }
            else if (input == "2")
            {
                bombaLigada = false;
                Console.WriteLine("Bomba desligada manualmente.");
            }

            if (bombaLigada)
            {
                ciclosBomba++;
                Console.WriteLine($"A bomba está ligada. Ciclos da bomba: {ciclosBomba}");
            }
            else
            {
                Console.WriteLine("A bomba está desligada.");
            }
        }
    }
}
