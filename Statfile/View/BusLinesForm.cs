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
    public partial class BusLinesForm : UserControl
    {
        public EventHandler precedent;
        public EventHandler suivantform;
        private List<BusStation> busStations = new List<BusStation>();
        private List<BusStation> busRevStations = new List<BusStation>();
        private List<BusLine> buslines = new List<BusLine>();
        private List<Frequency> freq = new List<Frequency>();
        private int buslineId;
        public List<BusStation> BusStations { get => busStations; set => busStations = value; }
        public List<BusStation> BusRevStations { get => busRevStations; set => busRevStations = value; }
        public List<BusLine> Buslines { get => buslines; set => buslines = value; }
        public int BuslineId { get => buslineId; set => buslineId = value; }
        public List<Frequency> Freq { get => freq; set => freq = value; }

        public BusLinesForm()
        {
            
            InitializeComponent();
            BuslineId = 1;
            Buslines = new List<BusLine>();
        }

        public void SetList(List<BusStation> busstations)
        {

            BusStations = busstations;
            busRevStations = busstations;
            stationsList.DataSource = null;
            stationsList.DataSource = BusStations;
            stationsList.DisplayMember = "Edge";
            stationsList.ValueMember = "Id";
            revstation.DataSource = BusRevStations;
            revstation.DisplayMember = "Edge";
            revstation.ValueMember = "Id";

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BusLinesForm_Load(object sender, EventArgs e)
        {
            busLineBindingSource.DataSource = Buslines;
            busLinesDatagridView.RowTemplate.Height = 25;

        }


        private void Addline_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(maxtripduration.Text)
                || String.IsNullOrEmpty(begin.Text)
                || String.IsNullOrEmpty(end.Text)
                || String.IsNullOrEmpty(rate.Text)
                || BusStations.Count==0
                || BusRevStations.Count==0
                || Freq.Count==0)
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                try
                { //frequences
                    Frequency frequency = new Frequency(int.Parse(begin.Text), int.Parse(end.Text), int.Parse(rate.Text));
                    Freq.Add(frequency);
                  //bus stations
                    BusStation station = (BusStation)stationsList.SelectedItem;
                    BusStations.Add(station);
                    BusStation revs = (BusStation)revstation.SelectedItem;
                    BusRevStations.Add(revs);
                
                  //busline
                    BusLine bl = new BusLine(BuslineId,int.Parse(maxtripduration.Text),BusStations,BusRevStations,Freq);
                    ValidationContext context = new ValidationContext(bl, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(bl, context, errors, true))
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
                        frequencyBindingSource.Add(frequency);
                        busLineBindingSource.Add(bl);
                        busStationBindingSource.Add(station);
                        busStationBindingSource1.Add(revs);
                        BuslineId += 1;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void busStationDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busLinesDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                   // busStationBindingSource.RemoveCurrent();

                }
            }
        }

        private void frequenciesDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busLinesDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                  //  busStationBindingSource.RemoveCurrent();

                }
            }
        }

        private void stationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busLinesDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                  //  busStationBindingSource.RemoveCurrent();

                }
            }
        }

        private void revGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busLinesDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                  //  busStationBindingSource.RemoveCurrent();

                }
            }
        }

        private void revstation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maxtripduration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void begin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maxtripinfo_Click(object sender, EventArgs e)
        {
            string msg = "Temps maximum nécessaire à un bus pour effectuer le trajet de bout en bout.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void begininfo_Click(object sender, EventArgs e)
        {
            string msg = "Heure du début d'une nouvelle fréquence";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void endinfo_Click(object sender, EventArgs e)
        {
            string msg = "Heure de fin de la fréquence";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rateinfo_Click(object sender, EventArgs e)
        {
            string msg = "Temps entre deux bus, c'est l'inverse de " +
                "la fréquence mathématique. Ce débit de bus est effectué entre les valeurs " +
                "de début et de fin décrites ci-dessus";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void precbusstation_Click(object sender, EventArgs e)
        {
            precedent?.Invoke(sender, e);
        }

        private void nextbusstation_Click(object sender, EventArgs e)
        {

        }
    }

}
