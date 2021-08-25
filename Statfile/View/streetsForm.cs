using Statfile.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statfile.View
{
    public partial class streetsForm : UserControl
    {
        public EventHandler precedent;
        public EventHandler suivantform;
        private List<Street> streets;

        internal List<Street> Streets { get => streets; set => streets = value; }

        public streetsForm()
        {
            InitializeComponent();
            Streets = new List<Street>();
        }



        private void peopleNbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string msg = "Vous pourrez trouver l'identifiant de la rue en ouvrant le fichier de network sur NetEdit. Pour plus d'informations, veuillez consulter le site officiel , dans la rebrique aide.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string msg = "Nombre de personnes par mètre de rue. Valeur relative (normalisée avec le nombre total d'habitants)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string msg = "Nombre de postes de travail par mètre de rue. Valeur relative (normalisée avec le nombre total de demandes de travail de la ville)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void precrue_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);

        }

        private void nextrue_Click(object sender, EventArgs e)
        {
            if (Streets.Count > 0)
            {
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void streetsForm_Load(object sender, EventArgs e)
        {
            streetBindingSource.DataSource = Streets;
            streetDatagridView.RowTemplate.Height = 25;
        }

        private void addline_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edge.Text)
                || String.IsNullOrEmpty(pop.Text)
                || String.IsNullOrEmpty(workpos.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                try
                {
                    Street str = new Street(edge.Text, float.Parse(pop.Text, CultureInfo.InvariantCulture), float.Parse(workpos.Text, CultureInfo.InvariantCulture));
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
                        streetBindingSource.Add(str);
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void streetDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (streetDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    streetBindingSource.RemoveCurrent();

                }
            }
        }

        private void pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void workpos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pop_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void workpos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
