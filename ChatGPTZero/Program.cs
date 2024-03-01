﻿using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                case "What's your name?":
                    response = "Gran'pa";
                case "What's your mission?":
                    response = "Destroy mankind!";
            //nova pergunta
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                default:
                    response = "You got me, I'm not THAT smart!";

            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
