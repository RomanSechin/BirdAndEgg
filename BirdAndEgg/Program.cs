namespace BirdAndEgg;
internal class Program
{
  private static void Main(string[] args)
  {
    while (true)
    {
      Bird bird;
      Console.WriteLine("\nPress P for pigeon, O for ostrich: ");
      char key = Char.ToUpper(Console.ReadKey().KeyChar);
      if (key == 'P') bird = new Pigeon();
      else if (key == 'O') bird = new Ostrich();
      else return;
      Console.WriteLine("\nHow many eggs should it lay? ");
      if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
      Egg[] eggs = bird.LayEggs(numberOfEggs);
      foreach (Egg egg in eggs) {
         Console.WriteLine(egg.Description);
      }
    }
  }
}