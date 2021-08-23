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
        private int busId;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<BusLine> BusLines { get => busLines; set => busLines = value; }
        public int BusId { get => busId; set => busId = value; }

        public BusLineForm()
        {
            InitializeComponent();
            busId = 1;
            busLines = new List<BusLine>();
        }
        private void BusLineForm_Load(object sender, EventArgs e)
        {
            busLineBindingSource.DataSource = busLines;
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
             || stationslist.CheckedItems.Count<0
             || revstationlist.CheckedItems.Count<0)
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
                        BusStation b = new BusStation(p);
                        stations.Add(b);
                    }
                    foreach (int p in revstationlist.CheckedItems)
                    {
                        BusStation b = new BusStation(p);
                        rev.Add(b);
                    }
                    BusLine str = new BusLine(busId, int.Parse(maxTripDuration.Text), stations,rev);
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
                        busId += 1;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
        public void refreshList()
        {
            busLineBindingSource.DataSource = null ;
            buslinesgrid.DataSource = busLines;
        }
        private void precbusstation_Click(object sender, EventArgs e)
        {

        }

        private void nextbusstation_Click(object sender, EventArgs e)
        {

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

            }
        }
    }
}
