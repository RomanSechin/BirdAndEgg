using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndEgg
{
    internal class BrokenEgg : Egg
    {
        public BrokenEgg(double size, string color) : base(size, color){
            
        }
        public override string Description {
            get { return "A bird laid a broken egg"; }
        }
    }
}
