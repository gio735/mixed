using System;
using System.Collections.Generic;
using System.Text;

namespace hc
{
    public class Alergy
    {
        public string Name { get; private set; }
        public int Point { get; private set; }

        public Alergy(string name, int point)
        {
            Name = name;
            Point = point;
        }
    }
}
