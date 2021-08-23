using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Model
{
    class Parameters
    {
        private double carPreference;
        private int meanTimePerKmInCity;
        private double freeTimeActivityRate;
        private double uniformRandomTraffic;
        private double departureVariation;
        [Required]
        [Range(0.0, 1.0)]
        public double CarPreference { get => carPreference; set => carPreference = value; }
        [Required]
        public int MeanTimePerKmInCity { get => meanTimePerKmInCity; set => meanTimePerKmInCity = value; }
        [Required]
        [Range(0.0, 1.0)]
        public double FreeTimeActivityRate { get => freeTimeActivityRate; set => freeTimeActivityRate = value; }
        [Required]
        [Range(0.0, 0.999)]
        public double UniformRandomTraffic { get => uniformRandomTraffic; set => uniformRandomTraffic = value; }
        [Required]
        public double DepartureVariation { get => departureVariation; set => departureVariation = value; }

        public Parameters(double carPreference, int meanTimePerKmInCity, double freeTimeActivityRate, double uniformRandomTraffic, double departureVariation)
        {
            CarPreference = carPreference;
            MeanTimePerKmInCity = meanTimePerKmInCity;
            FreeTimeActivityRate = freeTimeActivityRate;
            UniformRandomTraffic = uniformRandomTraffic;
            DepartureVariation = departureVariation;
        }

        public Parameters()
        {

        }
    }
}
