using System;

namespace HomeWork_I56
{
    class Program
    {

        //I5.6. Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства:
        //«валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
        //Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.).
        //По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.
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
