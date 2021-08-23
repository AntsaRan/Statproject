using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    class Closing
    {
        private int hour;
        private float proportion;

        public int Hour { get => hour; set => hour = value; }
        public float Proportion { get => proportion; set => proportion = value; }

        public Closing(int hour, float proportion)
        {
            Hour = hour;
            Proportion = proportion;
        } 
    }
}
