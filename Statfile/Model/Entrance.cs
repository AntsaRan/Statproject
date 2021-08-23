using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    class Entrance
    {
        private string edge;
        private float pos;
        private float incoming;
        private float outgoing;

        public Entrance(string edge, float pos, float incoming, float outgoing)
        {
            Edge = edge;
            Pos = pos;
            Incoming = incoming;
            Outgoing = outgoing;
        }
        [Required]
        public string Edge { get => edge; set => edge = value; }
        [Required]
        public float Pos { get => pos; set => pos = value; }
        [Required]
        public float Incoming { get => incoming; set => incoming = value; }
        [Required]
        public float Outgoing { get => outgoing; set => outgoing = value; }
    }
}
