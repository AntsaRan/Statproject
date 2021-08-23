using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statfile.Model
{
    class General
    {
    
        private int inhabitants;    
        private int households;
        private int childrenAgeLimit;
        private int retirementAgeLimit;
        private double carRate;
        private double unemploymentRate;
        private double footDistanceLimit;
        private int incomingTraffic;
        private int outgoingTraffic;
        [Required]
        public int Inhabitants { get => inhabitants; set => inhabitants = value; }
        [Required]
        public int Households { get => households; set => households = value; }
        [Required]
        public int ChildrenAgeLimit { get => childrenAgeLimit; set => childrenAgeLimit = value; }
        [Required]
        public int RetirementAgeLimit { get => retirementAgeLimit; set => retirementAgeLimit = value; }
        [Required]
        [Range(0.0, 1.0)]
        public double CarRate { get => carRate; set => carRate = value; }
        [Required]
        [Range(0.0, 1.0)]
        public double UnemploymentRate { get => unemploymentRate; set => unemploymentRate = value; }
        [Required]
        public double FootDistanceLimit { get => footDistanceLimit; set => footDistanceLimit = value; }
        [Required]
        public int IncomingTraffic { get => incomingTraffic; set => incomingTraffic = value; }

        public int OutgoingTraffic
        {
            get { return outgoingTraffic; }
            set
            {
                if (outgoingTraffic < 0 || outgoingTraffic > inhabitants)
                {
                    MessageBox.Show(" Le traffic sortant doit être compris entre 0 et le nombre total d'habitant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                outgoingTraffic = value;

            }
        }
       

        public General(int households, int childrenAgeLimit, int retirementAgeLimit, double carRate, double unemploymentRate, double footDistanceLimit, int incomingTraffic, int outgoingTraffic, int inhabitants)
        {
            Households = households;
            ChildrenAgeLimit = childrenAgeLimit;
            RetirementAgeLimit = retirementAgeLimit;
            CarRate = carRate;
            UnemploymentRate = unemploymentRate;
            FootDistanceLimit = footDistanceLimit;
            IncomingTraffic = incomingTraffic;
            OutgoingTraffic = outgoingTraffic;
            Inhabitants = inhabitants;
        }

        public General()
        {
        }
    }
}
