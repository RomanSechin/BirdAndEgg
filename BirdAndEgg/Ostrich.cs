using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndEgg
{
  internal class Ostrich : Bird
  {
    public override Egg[] LayEggs(int numberOfEggs)
    {
      Egg[] eggs = new Egg[numberOfEggs];
      for (int i = 0; i < numberOfEggs; ++i)
      {
        eggs[i] = new Egg(12.0 + Bird.Randomizer.NextDouble(), "speckled");
      }
      return eggs;
    }
  }
}
