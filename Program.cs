using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим имя
            Console.Write("Hi, enter your name: ");
            string name = Console.ReadLine();
            //Дёргаем рандомную букву из введённого имени
            Console.WriteLine("Random letter from your name: {0}", name?[new Random().Next(name.Length)]);
        }
    }
}