using System;

namespace Jardel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jardel Mario Nolio, Matheus de Rossi Cardoso

            Loop();
            if(Console.ReadLine() == "")
            {
                Loop();
            }

            
        }
        static void Loop() 
        {
            string continuar;

            Console.WriteLine("Para Iniciar o Quiz aperte a tecla ENTER");
            continuar = Console.ReadLine();

            if (continuar == "Start")
            {
                Console.WriteLine("Iniciando Quiz");
            }

            else
            {
                Console.WriteLine("Bem-Vindo ao Quiz");
                Console.WriteLine();
            }

            string resposta;

            Console.WriteLine("Pergunta 1");
            Console.WriteLine("Em que ano foi lançado Valorant?");
            Console.WriteLine("A-2019 B-2020 C-2021");
            Console.WriteLine();
            resposta = Console.ReadLine();


            int numeroAcertos = 0;
            int numeroErros = 0;
            if (resposta == "2020")

            {
                Console.WriteLine("Resposta Correta");
                numeroAcertos++;

            }

            else

            {
                Console.WriteLine("Resposta Incorreta");
                numeroErros++;
            }


            Console.WriteLine("Pergunta 2");
            Console.WriteLine("Em que ano foi lançado Gta San Andreas?");
            Console.WriteLine("A-2002 B-2003 C-2004");
            Console.WriteLine();
            resposta = Console.ReadLine();


            if (resposta == "2004")

            {
                Console.WriteLine("Resposta Correta");
                numeroAcertos++;
            }

            else

            {
                Console.WriteLine("Resposta Incorreta");
                numeroErros++;
            }

            Console.WriteLine("Pergunta 3");
            Console.WriteLine("Em que ano foi lançado League of Legends?");
            Console.WriteLine("A-2009 B-2010 C-2011");
            Console.WriteLine();
            resposta = Console.ReadLine();


            if (resposta == "2009")

            {
                Console.WriteLine("Resposta Correta");
                numeroAcertos++;

            }

            else

            {
                Console.WriteLine("Resposta Incorreta");
                numeroErros++;
            }

            Console.WriteLine("Pergunta 4");
            Console.WriteLine("Em que ano foi lançado Fortnite?");
            Console.WriteLine("A-2016 B-2017 C-2018");
            Console.WriteLine();
            resposta = Console.ReadLine();


            if (resposta == "2017")

            {
                Console.WriteLine("Resposta Correta");
                numeroAcertos++;
            }

            else

            {
                Console.WriteLine("Resposta Incorreta");
                numeroErros++;
            }

            Console.WriteLine("Pergunta 5");
            Console.WriteLine("Em que ano foi lançado Pubg?");
            Console.WriteLine("A-2017 B-2018 C-2019");
            Console.WriteLine();
            resposta = Console.ReadLine();


            if (resposta == "2017")

            {
                Console.WriteLine("Resposta Correta");
                numeroAcertos++;
            }

            else

            {
                Console.WriteLine("Resposta Incorreta");
                numeroErros++;
            }

            Console.WriteLine("Parabens Voce Acertou " + numeroAcertos);
            Console.WriteLine("Caso queira jogar novamente, aperte Enter");
        }
    }
}
