using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndEgg
{
    internal class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0, color){
            
        }
        public override string Description {
            get { return $"A bird laid a {Color} broken egg"; }
        }
    }
}
