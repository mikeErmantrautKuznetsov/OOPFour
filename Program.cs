namespace OOPFourth
{
    //Колода карт
    //Есть колода с картами.Игрок достает карты, пока не решит, что ему хватит карт
    //(может быть как выбор пользователя, так и количество сколько карт надо взять).
    //После выводиться вся информация о вытянутых картах.
    //Возможные классы: Карта, Колода, Игрок.

    public class Player
    {
        Player player = new Player();
    }

    public class Card
    {
        public List<int> cardDelet = new List<int>();
    }

    public class Deck
    {
        public List<int> deckAdd = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13 };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.deckAdd.Add(1);
            deck.deckAdd.Add(2);
            for (int i = 0; i < deck.deckAdd.Count; i++)
            {
                deck.deckAdd[i] = i;
                Console.WriteLine(i);
            }
        }
    }
}