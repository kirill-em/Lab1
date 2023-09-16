using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class ToConsole
    {
        public string Text;
        public int Number;

        public void sendToConsole(string text, int number)
        {
            Console.WriteLine("Your string: {0}\nYour number: {1}", text, number);
        }
    }
}