using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statfile.Model
{
    class PopulationBracket
    {

        private int beginAge;
        private int endAge;
        private int peopleNbr;
        [Required]
        public int BeginAge { get => beginAge; set => beginAge = value; }
        [Required]
        public int PeopleNbr { get => peopleNbr; set => peopleNbr = value; }
        [Required]
        public int EndAge
        {
            get { return endAge; }
            set
            {
               
                if (value <= BeginAge )
                {
                    System.Diagnostics.Debug.WriteLine(endAge);
                    MessageBox.Show(" erreur âge de fin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    endAge = value;
                }
            }
        }

        public PopulationBracket(int beginAge, int endAge, int peopleNbr)
        {
            BeginAge = beginAge;
            EndAge = endAge;
            PeopleNbr = peopleNbr;
        }

      
    }
}
