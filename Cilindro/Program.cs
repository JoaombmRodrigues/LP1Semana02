using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for height
            Console.Write("Insira uma altura para um cilindro: ");
            string altura = Console.ReadLine();
            //ask user for radius
            Console.Write("Insira um raio para um cilindro: ");
            string raio = Console.ReadLine();
            //convert the variables to floats
            float a = float.Parse(altura);
            float r = float.Parse(raio);
            //calculate volume and surface area
            float V = MathF.PI*MathF.Pow(r,2)*a;
            float Sa = 2*MathF.PI*r*(r+a);
            //print volume and surface area
            Console.WriteLine($"Volume: {V}");
            Console.WriteLine($"Área de superfície: {Sa}");
        }
    }
}
