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
    public partial class workHoursForm : UserControl
    {
        public EventHandler precedent;
        public EventHandler suivantform;
        private List<Opening> open;
        private List<Closing> close;

        internal List<Opening> Open { get => open; set => open = value; }
        internal List<Closing> Close { get => close; set => close = value; }

        public workHoursForm()
        {
            InitializeComponent();
            Open = new List<Opening>();
            Close = new List<Closing>();
        }


        private void ajoutopening_Click(object sender, EventArgs e)
        {
        }

        private void ajoutclosing_Click(object sender, EventArgs e)
        {

           
        }

        private void workHours_Load(object sender, EventArgs e)
        {
            openingBindingSource.DataSource = Open;
            closingBindingSource.DataSource = Close;
            openingGrid.RowTemplate.Height = 25;
            closingGrid.RowTemplate.Height = 25;
        }

        private void precpop_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);
        }

        private void nextpop_Click(object sender, EventArgs e)
        {
            if (Open.Count > 0 && Close.Count > 0)
            {
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void openingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (openingGrid.Columns[e.ColumnIndex].Name == "SupprimerO")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    openingBindingSource.RemoveCurrent();

                }
            }
        }

        private void closingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (closingGrid.Columns[e.ColumnIndex].Name == "SupprimerC")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    closingBindingSource.RemoveCurrent();

                }
            }
        }

        private void TEST(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string msg = "Nombres de secondes écoulées à partir de minuit. Ex: 3600=01h00 du matin ;30 600 = 8.5 h soit 8h30 du matin.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string msg = "Proportion de lieux de travail ayant cette heure d'ouverture. Forme: 0.30 = 30% ( 100% représente le nombre total de lieux de travail";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ajoutopening_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(houropening.Text)
                || String.IsNullOrEmpty(proportionopening.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                if (int.Parse(houropening.Text) <= 86400 && int.Parse(houropening.Text) > 0)
                {
                    Opening opening = new Opening(int.Parse(houropening.Text), float.Parse(proportionopening.Text, CultureInfo.InvariantCulture));
                    ValidationContext context = new ValidationContext(opening, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(opening, context, errors, true))
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
                        openingBindingSource.Add(opening);
                    }
                }
                else
                {
                    MessageBox.Show("L'heure ne doit pas dépasser 86400 soit 00h00 et l'heure doit être un nombre positif", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void ajoutclosing_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(hourclosing.Text)
               || String.IsNullOrEmpty(proportionclosing.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                if (int.Parse(hourclosing.Text) <= 86400 && int.Parse(hourclosing.Text) > 0)
                {
                    Closing closing = new Closing(int.Parse(hourclosing.Text), float.Parse(proportionclosing.Text, CultureInfo.InvariantCulture));
                    ValidationContext context = new ValidationContext(closing, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(closing, context, errors, true))
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
                        closingBindingSource.Add(closing);
                    }
                }
                else
                {
                    MessageBox.Show("L'heure ne doit pas dépasser 86400 soit 00h00 et l'heure doit être un nombre positif", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void houropening_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void proportionopening_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void hourclosing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void proportionclosing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
