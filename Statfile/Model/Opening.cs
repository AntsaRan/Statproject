using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    class Opening
    {
        private int hour;
        private float proportion;
        [Required]

        public int Hour { get => hour; set => hour = value; }
        [Required]

        public float Proportion { get => proportion; set => proportion = value; }

        public Opening(int hour, float proportion)
        {
            Hour = hour;
            Proportion = proportion;
        }
    }
}
