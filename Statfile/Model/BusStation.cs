using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    [Serializable]
    public class BusStation 
    {
        private int id;
        private string edge;
        private int pos;
        public BusStation(int id, string edge, int pos)
        {
            Id = id;
            Edge = edge;
            Pos = pos;
        }
        
        [Required]
        public int Id { get => id; set => id = value; }
        [Required]
        public string Edge { get => edge; set => edge = value; }
        [Required]
        public int Pos { get => pos; set => pos = value; }

    }
}
