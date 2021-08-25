using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public int Begin { get => begin; set => begin = value; }
        [Required]
        public int End { get => end; set => end = value; }
        [Required]
        public int Rate { get => rate; set => rate = value; }
    }
}
