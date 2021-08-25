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
    public partial class generalform : UserControl
    {
        private General general;
        public EventHandler enablenext;

        internal General General { get => general; set => general = value; }

        public generalform()
        {
            InitializeComponent();

        }

        private void nextgen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("nextgen_Click");
            if (String.IsNullOrEmpty(inhabitants.Text)
                 || String.IsNullOrEmpty(households.Text)
                 || String.IsNullOrEmpty(childrenAgeLimit.Text)
                 || String.IsNullOrEmpty(retirementAgeLimit.Text)
                 || String.IsNullOrEmpty(carRate.Text)
                 || String.IsNullOrEmpty(unemploymentRate.Text)
                 || String.IsNullOrEmpty(footDistanceLimit.Text)
                 || String.IsNullOrEmpty(incomingTraffic.Text)
                 || String.IsNullOrEmpty(outgoingTraffic.Text))
            {

                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                General = new General();
                General.Inhabitants = int.Parse(inhabitants.Text);
                General.Households = int.Parse(households.Text);
                General.ChildrenAgeLimit = int.Parse(childrenAgeLimit.Text);
                General.RetirementAgeLimit = int.Parse(retirementAgeLimit.Text);
                General.CarRate = double.Parse(carRate.Text, CultureInfo.InvariantCulture);
                General.UnemploymentRate = double.Parse(unemploymentRate.Text, CultureInfo.InvariantCulture);
                General.FootDistanceLimit = double.Parse(footDistanceLimit.Text, CultureInfo.InvariantCulture);
                General.IncomingTraffic = int.Parse(incomingTraffic.Text);
                General.OutgoingTraffic = int.Parse(outgoingTraffic.Text);
                ValidationContext context = new ValidationContext(General, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(General, context, errors, true))
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
                    enablenext?.Invoke(sender, e);

                }
                // enablenext?.Invoke(sender, e);
            }
        }

        private void inhabitants_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void households_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void childrenAgeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void retirementAgeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void carRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void unemploymentRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void footDistanceLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void incomingTraffic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void outgoingTraffic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void generalform_Load(object sender, EventArgs e)
        {

        }
    }
}
