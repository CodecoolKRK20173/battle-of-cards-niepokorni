namespace CardGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Game graMirek = new Game("Mirka Gra", 2, 20);
            graMirek.PlayingTable.CompareValuesOnPlayersCarts(graMirek);
        }
    }
}