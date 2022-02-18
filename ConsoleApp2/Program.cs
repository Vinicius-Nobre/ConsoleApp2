using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
          

            Console.WriteLine("digite seu nome, e saberá onde nasceu");
            nome = Console.ReadLine();

            if (nome == "Thiago")

            {
                Console.WriteLine("Você é mineiro");

            }
            else if

                (nome == "Vinicius")
            {

                Console.WriteLine("Você é cearense");
            }




            else if

                    (nome == "Luiz")
            {
                Console.WriteLine("Você é baianão");
            }

            else if
            (nome == "Taian")
            {
                Console.WriteLine("Você Paraiba");
            }

           else if 
                ( nome == "Daniel")
            {
                Console.WriteLine("Você nem gente é");

            }

            else

                Console.WriteLine("Você digitou o nome incorreto");


        }
    }
}
