using System;

namespace HomeWork_I56
{
    class Program
    {
        static void Main(string[] args)
        {
            string card;
            Console.Write("\nEnter value to search for the card: ");
            int value = Int32.Parse(Console.ReadLine());
            new Values(value, out card);
            Console.WriteLine(card);
            Console.ReadKey();
        }
    }
    public class Values
    {
        private string[] Cards = { "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        public Values(int value, out string card)
        {
            int searchIndex = value - 6;
            card = Cards[searchIndex];
            return;
        }
    }
}
