using Statfile.FormControls;
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
    public partial class BusStationsForm : UserControl
    {

        public EventHandler precedent;
        public EventHandler suivantform;
        private List<BusStation> busStations;
        private int busstationId;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<BusStation> BusStations { get => busStations; set => busStations = value; }
        public int BusstationId { get => busstationId; set => busstationId = value; }

        public BusStationsForm()
        {
            InitializeComponent();
            BusstationId = 1;
            BusStations = new List<BusStation>();
        }

        private void streetDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (busStationDatagridView.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    busStationBindingSource.RemoveCurrent();

                }
            }
        }

        private void BusStationsForm_Load(object sender, EventArgs e)
        {
            busStationBindingSource.DataSource = BusStations;
            busStationDatagridView.RowTemplate.Height = 25;
        }

        private void idinfo_Click(object sender, EventArgs e)
        {
            string msg = "Vous pourrez trouver l'identifiant de la rue en ouvrant le fichier de network sur NetEdit. Pour plus d'informations, veuillez consulter le site officiel , dans la rebrique aide.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void posinfo_Click(object sender, EventArgs e)
        {
            string msg = "Vous pourrez trouver l'identifiant de la rue en ouvrant le fichier de network sur NetEdit. Pour plus d'informations, veuillez consulter le site officiel , dans la rebrique aide.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void edgeinfo_Click(object sender, EventArgs e)
        {
            string msg = "Vous pourrez trouver l'identifiant de la rue en ouvrant le fichier de network sur NetEdit. Pour plus d'informations, veuillez consulter le site officiel , dans la rebrique aide.";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addline_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(position.Text)
                || String.IsNullOrEmpty(edge.Text))
            {
                // ajouter control de valeurs 
                // habitantserror.SetError(inhabitants, "doit être renseigné");
                MessageBox.Show("Tous les champs doivent être renseignés");
            }
            else
            {
                try
                {
                    BusStation str = new BusStation(BusstationId, edge.Text,int.Parse(position.Text));
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
                        busStationBindingSource.Add(str);
                        BusstationId += 1;
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

        private void nextbusstation_Click(object sender, EventArgs e)
        {
            if (BusStations.Count > 0)
            {
                Session.Stations = busStations;
                suivantform?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Vérifiez que vous avez bien ajouté des éléments", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void position_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
