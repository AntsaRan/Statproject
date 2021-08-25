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
    public partial class BusLineForm : UserControl
    {
        public EventHandler precedent;
        public EventHandler suivantform;
        private List<BusLine> busLines;
        private List<BusStation> station;
        private List<BusStation> revstation;
        private modifyBuslineStations form;
        private AjoutFrequences freqform;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<BusLine> BusLines { get => busLines; set => busLines = value; }
        public List<BusStation> Station { get => station; set => station = value; }
        public List<BusStation> Revstation { get => revstation; set => revstation = value; }

        public BusLineForm()
        {
            InitializeComponent();
            form = new modifyBuslineStations();
            freqform = new AjoutFrequences();
            form.modifierevent += new EventHandler(modifierElement);
            freqform.validerF += new EventHandler(validerfrequences);
            busLines = new List<BusLine>();
        }

        private void validerfrequences(object sender, EventArgs e) 
        { 
        
            int index = freqform.Index;
            BusLine bus = freqform.Bus;
            busLineBindingSource.RemoveAt(index);
            busLineBindingSource.Add(bus);
        }

        private void BusLineForm_Load(object sender, EventArgs e)
        {
            busLineBindingSource.DataSource = BusLines;
        }

        public void setstations(List<BusStation> list)
        {
          foreach(BusStation b in list)
            {
                stationslist.Items.Add(b.Id);
                revstationlist.Items.Add(b.Id);
            }
        
        }
        private void addline_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idbus.Text)
             || String.IsNullOrEmpty(maxTripDuration.Text)
             || stationslist.CheckedItems.Count<=0
             || revstationlist.CheckedItems.Count<=0)
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés, renseignez les stations des lignes de bus");
            }
            else
            {
                try
                {
                    List<BusStation> stations = new List<BusStation>();
                    List<BusStation> rev = new List<BusStation>();

                    foreach (int p in stationslist.CheckedItems)
                    {
                        Console.WriteLine(p + " p statoion");
                        BusStation b = new BusStation(p);
                        stations.Add(b);
                    }
                    foreach (int p in revstationlist.CheckedItems)
                    {
                        Console.WriteLine(p + " p revstationlist");
                        BusStation b = new BusStation(p);
                        rev.Add(b);
                    }
                    BusLine str = new BusLine(idbus.Text, int.Parse(maxTripDuration.Text), stations,rev);
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
                        busLineBindingSource.Add(str);
                       // refreshList();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void precbusstation_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);

        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buslinesgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (buslinesgrid.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    busLineBindingSource.RemoveCurrent();

                }
            }else if (buslinesgrid.Columns[e.ColumnIndex].Name == "Modifier")
            {
                BusLine bus = busLines[e.RowIndex];
                form = new modifyBuslineStations();
                form.init(bus, e.RowIndex);
                form.Show();
            }else if(buslinesgrid.Columns[e.ColumnIndex].Name == "addFreq")
            {
                BusLine bus = busLines[e.RowIndex];
                if (bus.Stations.Count == 0)
                {
                    MessageBox.Show("Ajoutez d'abord les stations.","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    freqform = new AjoutFrequences();
                    freqform.init(bus, e.RowIndex);
                    freqform.Show();
                }
        
            }
        }
        public void modifierElement(object sender, EventArgs e)
        {
            int index = form.Index;
            BusLine bus = form.Busline;
            busLineBindingSource.RemoveAt(index);
            busLineBindingSource.Add(bus);
        }

        private void posinfo_Click(object sender, EventArgs e)
        {
            string msg = "Identifiant du bus. Assurez vu qu'il est unique.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edgeinfo_Click(object sender, EventArgs e)
        {
            string msg = "Temps maximum nécessaire à un bus pour effectuer le trajet de bout en bout. (s)";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nextbusLines_Click(object sender, EventArgs e)
        {
            if (BusLines.Count > 0)
            {
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void idbus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maxTripDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
