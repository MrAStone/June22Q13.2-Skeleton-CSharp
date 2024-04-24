namespace June22Q13._2_Skeleton_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] cards = genHand(rnd);
            bool gameWon = false;
         
        }
        static int[] genHand(Random rnd)
        {
            int[] handOfCards = new int[100];
            int[] deck = new int[500];
            int n = 1;
            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = n;
                n++;
                if (n > 250)
                {
                    n = 1;
                }
            }
            for(int i = 0;i< handOfCards.Length; i++)
            {
                int num = rnd.Next(0, 500);
                while (deck[num] == -1)
                {
                    num = rnd.Next(0, 500);
                }
                handOfCards[i] = deck[num];
                deck[num] = -1;
            }
            Array.Sort(handOfCards);
            return handOfCards;
        }
    }
}
