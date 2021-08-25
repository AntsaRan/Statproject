using Statfile.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statfile.View
{
    public partial class AjoutFrequences : Form
    {
        public EventHandler validerF;
        private List<Frequency> freq;
        private BusLine bus;
        private int index;

        public BusLine Bus { get => bus; set => bus = value; }
        public int Index { get => index; set => index = value; }
        public AjoutFrequences()
        {
            InitializeComponent();
        }
        public void init(BusLine bus, int indexb)
        {
            freq = new List<Frequency>();
            if (bus.Frequencies != null && bus.Frequencies.Count > 0)
            {
                freq = bus.Frequencies;
            }
            Bus = bus;
            Index = indexb;          
        }


        private void ajouter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(begin.Text)
             || String.IsNullOrEmpty(end.Text)
             || String.IsNullOrEmpty(rate.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés, renseignez les stations des lignes de bus");
            }
            else
            {
                try
                {
                  
                    Frequency str = new Frequency(int.Parse(begin.Text), int.Parse(end.Text), int.Parse(rate.Text));
                    ValidationContext context = new ValidationContext(str, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(str, context, errors, true))
                    {

                        foreach (ValidationResult result in errors)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        return;
                    }
                    else
                    {
                        frequencyBindingSource.Add(str);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void AjoutFrequences_Load(object sender, EventArgs e)
        {
            frequencyBindingSource.DataSource = freq;
        }

        private void valider_Click(object sender, EventArgs e)
        {
            Bus.Frequencies = freq;
            validerF?.Invoke(sender, e);
            this.Close();
        }

        private void begin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void end_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void posinfo_Click(object sender, EventArgs e)
        {
            string msg = "Heure du début d'une nouvelle fréquence";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edgeinfo_Click(object sender, EventArgs e)
        {
            string msg = "Heure de fin de la fréquence";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string msg = "Temps entre deux bus, c'est l'inverse de la fréquence mathématique. Ce débit de bus est effectué entre les valeurs de début et de fin décrites ci-dessus";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void freqgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (freqgrid.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    frequencyBindingSource.RemoveCurrent();

                }
            }
        }
    }
}
