using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndEgg
{
  internal class Bird
  {
    public static Random Randomizer = new Random();
    public virtual Egg[] LayEggs(int numberOfEggs) {
      Console.Error.WriteLine("Bird.LayEggs should never been called");
      return new Egg[0];
    }
  }
}
