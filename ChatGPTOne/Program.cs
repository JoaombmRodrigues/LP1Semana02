using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question,response;
            //loop
            do
            {
                //pergunta
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                //respostas
                switch (question)
                {
                    case "What's 9+10?":
                        response = "9+10 is 21.";
                        break;
                    case "What time is it?":
                        response = "Check the clock.";
                        break;
                    case "What's up!":
                        response = "Hey, I'm ChatGPTOne!";
                        break;
                    case "What's the weather like today?":
                        response = "Sunny!!!";
                        break;
                    case "EXIT":
                        response = "Goodbye!";
                        return;
                    default:
                        response = "I didn't understand that.";
                        break;

                }

            // Responder adequadamente
            Console.WriteLine(response);
            } 
            while(true);
        }
    }
}
