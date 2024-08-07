using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndEgg
{
  internal class Pigeon : Bird
  {
    public override Egg[] LayEggs(int numberOfEggs) {
      Egg[] eggs = new Egg[numberOfEggs];
      for (int i = 0; i < numberOfEggs; ++i)
      {
        eggs[i] = new Egg(1.0 + 2 * Bird.Randomizer.NextDouble(), "White");
      }
      return eggs;
    }

  }
}
