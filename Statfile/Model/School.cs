using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    class School
    {
        private string edge;
        private float pos;
        private int beginAge;
        private int endAge;
        private int capacity;
        private int opening;
        private int closing;

        public School(string edge, float pos, int beginAge, int endAge, int capacity, int opening, int closing)
        {
            Edge = edge;
            Pos = pos;
            BeginAge = beginAge;
            EndAge = endAge;
            Capacity = capacity;
            Opening = opening;
            Closing = closing;
        }
        [Required]
        public string Edge { get => edge; set => edge = value; }
        [Required]
        public float Pos { get => pos; set => pos = value; }
        [Required]
        public int BeginAge { get => beginAge; set => beginAge = value; }
        [Required]
        public int EndAge { get => endAge; set => endAge = value; }
        [Required]
        public int Capacity { get => capacity; set => capacity = value; }
        [Required]
        public int Opening { get => opening; set => opening = value; }
        [Required]
        public int Closing { get => closing; set => closing = value; }
    }
}
