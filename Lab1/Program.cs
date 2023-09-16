using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToConsole writeThis = new ToConsole();

            writeThis.Text = "Hello";
            writeThis.Number = 1;

            ToConsole writeThat = new ToConsole();

            writeThat.Text = "World";
            writeThat.Number = 2;

            writeThis.sendToConsole(writeThis.Text, writeThis.Number);
            writeThat.sendToConsole(writeThat.Text, writeThat.Number);
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