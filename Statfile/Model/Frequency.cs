using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{

    public class Frequency
    {
        private int begin;
        private int end;
        private int rate;

        public Frequency(int begin, int end, int rate)
        {
            Begin = begin;
            End = end;
            Rate = rate;
        }

        public int Begin { get => begin; set => begin = value; }
        public int End { get => end; set => end = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}
