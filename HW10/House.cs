using System.Collections.Generic;

namespace HW10
{
    public class House
    {
        public Basement Basement { get; set; }
        public List<Wall> Walls { get; set; } = new List<Wall>();
        public Door Door { get; set; }
        public List<Window> Windows { get; set; } = new List<Window>();
        public Roof Roof { get; set; }
    }
}
