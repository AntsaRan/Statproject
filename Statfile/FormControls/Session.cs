using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.FormControls
{
    class Session
    {
        private static List<BusLine> buses;
        private static List<BusStation> stations;

        public Session()
        {
        }

        public static List<BusLine> Buses { get => buses; set => buses = value; }
        public static List<BusStation> Stations { get => stations; set => stations = value; }
    }
}
