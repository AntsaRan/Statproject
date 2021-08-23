using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    class Street
    {
        private string edge;
        private float population;
        private float workPosition;

        public Street( string edge, float population, float workPosition)
        {
            WorkPosition = workPosition;
            Edge = edge;
            Population = population;
        }

        [Required]
        public float WorkPosition { get => workPosition; set => workPosition = value; }
        [Required]
        public string Edge { get => edge; set => edge = value; }
        [Required]
        public float Population { get => population; set => population = value; }


    }
}
