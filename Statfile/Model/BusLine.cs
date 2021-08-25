using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{

    public class BusLine
    {
        private string id;
        private int maxTripDuration;
        private List<BusStation> stations;
        private List<BusStation> revStations;
        private List<Frequency> frequencies;

        public BusLine(string id, int maxTripDuration, List<BusStation> stations, List<BusStation> revStations, List<Frequency> frequencies)
        {
            Id = id;
            MaxTripDuration = maxTripDuration;
            Stations = stations;
            RevStations = revStations;
            Frequencies = frequencies;
        }
        public BusLine(string id, int maxTripDuration)
        {
            Id = id;
            MaxTripDuration = maxTripDuration;
        }
        public BusLine(string id, int maxTripDuration, List<BusStation> stations, List<BusStation> revStations)
        {
            Id = id;
            MaxTripDuration = maxTripDuration;
            Stations = stations;
            RevStations = revStations;

        }
        public BusLine(List<Frequency> frequencies)
        {
            Frequencies = frequencies;

        }
        public string Id { get => id; set => id = value; }
        public int MaxTripDuration { get => maxTripDuration; set => maxTripDuration = value; }
        public List<BusStation> Stations { get => stations; set => stations = value; }
        public List<BusStation> RevStations { get => revStations; set => revStations = value; }
        public List<Frequency> Frequencies { get => frequencies; set => frequencies = value; }


    }
}
