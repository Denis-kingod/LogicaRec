using System;
using System.Collections.Generic;

namespace projetoLogicaRec
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ParticipantesDoEvento = new List<string>();
            do
            {
                 Console.WriteLine("Coloque o seu nome");
                string Nome = Console.ReadLine();

                Console.WriteLine($"coloque a sua idade");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 16)
                {
                    Console.WriteLine($"Você possui a idade necessaria para participar do evento");
                    ParticipantesDoEvento.Add(Nome);
                }
                else
                {
                    Console.WriteLine($"você não tem idade suficiente para o evento, está acompanhado com alguém mais de 18 anos, sim/não?");
                    string resposta = Console.ReadLine();

                    switch (resposta)
                    {
                        case "sim":
                        Console.WriteLine($"você pode participar com acompanhante");
                        ParticipantesDoEvento.Add(Nome);
                            break;

                            case "não":
                            Console.WriteLine($"Que pena você não podera participar!");
                            
                            break;

                        default:
                        Console.WriteLine($"COLOQUE UMA RESPOSTA VALIDA!!");

                            break;
                    }
                    Console.WriteLine("Desejar cadastrar mais alguém?");
                    

                    Console.WriteLine("Lista de Participantes");
                    Nome = Console.ReadLine().ToLower();

                    
                }
            } while (true);
            {

            }
        }
    }
}
