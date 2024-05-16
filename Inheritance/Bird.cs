using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int TailLength {get; set;}
        public string BeakColor { get; set; }
        public bool IsPredatory {get; set;}
        public string FeatherColor{ get; set; }
        public string Name { get; set; }

    }

}
