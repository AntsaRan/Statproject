using Statfile.Model;
using System;
using System.Collections;
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
    public partial class populationform : UserControl
    {
        public EventHandler precedent;
        public EventHandler suivantform;
        private List<PopulationBracket> pop;
        public populationform()
        {
            InitializeComponent();
            pop = new List<PopulationBracket>();
        }

        internal List<PopulationBracket> Pop { get => pop; set => pop = value; }

        private void populationform_Load(object sender, EventArgs e)
        {
            populationBracketBindingSource.DataSource = pop;
            popDatagridView.RowTemplate.Height = 25;
        }

        private void precpop_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);

        }

        private void popDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (popDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                   populationBracketBindingSource.RemoveCurrent();
                   
                }
            }
        }

        private void addline_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(beginAge.Text)
                || String.IsNullOrEmpty(endAge.Text)
                || String.IsNullOrEmpty(peopleNbr.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                if (int.Parse(endAge.Text)> int.Parse(beginAge.Text))
                {
                  
                    PopulationBracket popu = new PopulationBracket(int.Parse(beginAge.Text), int.Parse(endAge.Text), int.Parse(peopleNbr.Text));
                    ValidationContext context = new ValidationContext(popu, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(popu, context, errors, true))
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
                        populationBracketBindingSource.Add(popu);
                    }
                }
                else
                {
                    MessageBox.Show(" L'âge fin doit être supérieure à l'âge de début.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
        }

        private void nextpop_Click(object sender, EventArgs e)
        {
            if (pop.Count > 0)
            {
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void beginAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void endAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void peopleNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

