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
    public partial class cityGatesForm : UserControl
    {

        public EventHandler precedent;
        public EventHandler suivantform;
        private List<Entrance> entrances;

        internal List<Entrance> Entrances { get => entrances; set => entrances = value; }

        public cityGatesForm()
        {
            InitializeComponent();
            Entrances = new List<Entrance>();

        }

        private void precgate_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);
        }

        private void nextgate_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" NEXTGATE");
            if (Entrances.Count > 0)
            {
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void addline_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edge.Text)
               || String.IsNullOrEmpty(pos.Text)
               || String.IsNullOrEmpty(incoming.Text)
               || String.IsNullOrEmpty(outgoing.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {

                Entrance str = new Entrance(edge.Text, float.Parse(pos.Text, CultureInfo.InvariantCulture), float.Parse(incoming.Text, CultureInfo.InvariantCulture), float.Parse(outgoing.Text, CultureInfo.InvariantCulture));
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
                    entranceBindingSource.Add(str);
                }

            }
        }

        private void cityGatesForm_Load(object sender, EventArgs e)
        {
            entranceBindingSource.DataSource = Entrances;
            citygatesDatagridView.RowTemplate.Height = 25;
        }

        private void citygatesDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (citygatesDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    entranceBindingSource.RemoveCurrent();

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string msg = "Vous pourrez trouver l'identifiant de la rue en ouvrant le fichier de network sur NetEdit. Pour plus d'informations, veuillez consulter le site officiel , dans la rebrique aide.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string msg = "Position exacte dans la rue (bord), en mètres, depuis le début de la rue donnée (la valeur maximale est la longueur de la rue)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string msg = "Proportion des véhicules entrants, passant par ce portail (par rapport aux valeurs entrantes des autres portails)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string msg = "Proportion des véhicules sortants, sortant de la ville par ce portail (par rapport aux valeurs sortantes des autres portails).";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void edge_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void incoming_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void outgoing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
