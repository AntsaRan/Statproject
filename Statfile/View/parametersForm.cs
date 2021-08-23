using Statfile.Controller;
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
    public partial class parametersForm : UserControl
    {
        public EventHandler validerform;
        public EventHandler precedent;
        private Parameters parameters;

        internal Parameters Parameters { get => parameters; set => parameters = value; }

        public parametersForm()
        {
            InitializeComponent();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(carPreference.Text)
                 || String.IsNullOrEmpty(meanTimePerKmInCity.Text)
                 || String.IsNullOrEmpty(freeTimeActivityRate.Text)
                 || String.IsNullOrEmpty(uniformRandomTraffic.Text)
                 || String.IsNullOrEmpty(departureVariation.Text))
            {

                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {

                Parameters = new Parameters();
                Parameters.CarPreference = double.Parse(carPreference.Text);
                Parameters.MeanTimePerKmInCity = int.Parse(meanTimePerKmInCity.Text);
                Parameters.FreeTimeActivityRate = double.Parse(freeTimeActivityRate.Text, CultureInfo.InvariantCulture);
                Parameters.UniformRandomTraffic = double.Parse(uniformRandomTraffic.Text, CultureInfo.InvariantCulture);
                Parameters.DepartureVariation = double.Parse(departureVariation.Text);

                ValidationContext context = new ValidationContext(Parameters, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(Parameters, context, errors, true))
                {

                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    validerform?.Invoke(sender, e);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);
        }

        private void carPreference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void uniformRandomTraffic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void meanTimePerKmInCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void departureVariation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void freeTimeActivityRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
