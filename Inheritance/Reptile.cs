using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile: Animal
    {
        public string Name { get; set; }         
        public bool HasLegs {  get; set; }
        public int HumanKillsPerYear { get; set; }   
        public bool IsSnake {  get; set; }
        public string IsDangerous { get; set; } 
    }
}
