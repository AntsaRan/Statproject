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
    public partial class schoolsForm : UserControl
    {
        public EventHandler precedent;
        public EventHandler suivantform;
        private List<School> schools;

        internal List<School> Schools { get => schools; set => schools = value; }

        public schoolsForm()
        {
            InitializeComponent();
            Schools = new List<School>();
        }

        private void schoolsForm_Load(object sender, EventArgs e)
        {

            schoolBindingSource.DataSource = Schools;
            schoolDatagridView.RowTemplate.Height = 25;
        }

        private void popDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (schoolDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    schoolBindingSource.RemoveCurrent();
                }
            }
        }

        private void addline_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(edge.Text)
                || String.IsNullOrEmpty(pos.Text)
                || String.IsNullOrEmpty(BeginAge.Text)
                || String.IsNullOrEmpty(EndAge.Text)
                || String.IsNullOrEmpty(Capacity.Text)
                || String.IsNullOrEmpty(Opening.Text)
                || String.IsNullOrEmpty(Closing.Text))
            {

                MessageBox.Show("Tous les champs doivent être renseignés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(BeginAge.Text) > int.Parse(EndAge.Text))
            {
                MessageBox.Show("L'âge de fin doit être inférieur à l'âge début", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(Opening.Text) > 86400 && int.Parse(Opening.Text) < 0 && int.Parse(Closing.Text) > 86400 && int.Parse(Closing.Text) < 0)
            {
                MessageBox.Show("Les heures ne doivent pas dépasser 86400 soit 00h00 et l'heure doit être un nombre positif", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                School sch = new School((edge.Text), float.Parse(pos.Text, CultureInfo.InvariantCulture), int.Parse(BeginAge.Text), int.Parse(EndAge.Text), int.Parse(Capacity.Text), int.Parse(Opening.Text), int.Parse(Closing.Text));
                ValidationContext context = new ValidationContext(sch, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(sch, context, errors, true))
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
                    schoolBindingSource.Add(sch);
                }
            }
        }

        private void Capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void precpop_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);

        }


        private void edgeinfo_Click(object sender, EventArgs e)
        {
            string msg = "Vous pourrez trouver l'identifiant de la rue en ouvrant le fichier de network sur NetEdit. " +
                "Pour plus d'informations, veuillez consulter le site officiel , dans la rebrique aide.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void posinfo_Click(object sender, EventArgs e)
        {
            string msg = "Position exacte dans la rue (bord), en mètres, depuis le début de la rue donnée" +
                " (la valeur maximale est la longueur de la rue)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void begininfo_Click(object sender, EventArgs e)
        {
            string msg = "Âge des plus jeunes élèves de l'école (borne inférieure," +
                " inclus dans la tranche d'acceptation)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void endageinfo_Click(object sender, EventArgs e)
        {

            string msg = "Âge des enfants non plus acceptés à l'école " +
                "(borne supérieure, exclu de la tranche d'acceptation)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void capinfo_Click(object sender, EventArgs e)
        {
            string msg = "Nombre maximum d'élèves acceptés";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openinfo_Click(object sender, EventArgs e)
        {
            string msg = "Heure de début des cours (heure scolaire)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeinfo_Click(object sender, EventArgs e)
        {
            string msg = "Heure de fin du cours";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nextpop_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" NEXT SCHOOL");
            if (Schools.Count > 0)
            {
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Opening_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BeginAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EndAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Closing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
