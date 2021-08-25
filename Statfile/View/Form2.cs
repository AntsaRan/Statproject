using Statfile.FormControls;
using Statfile.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statfile.View
{
    public partial class modifyBuslineStations : Form
    {
        public EventHandler modifierevent;
        private List<BusStation> station;
        private List<BusStation> revstation;
        private BusLine busline;
        private int index = 0;
        public List<BusStation> Station { get => station; set => station = value; }
        public List<BusStation> Revstation { get => revstation; set => revstation = value; }
        public BusLine Busline { get => busline; set => busline = value; }
        public int Index { get => index; set => index = value; }

        public modifyBuslineStations()
        {
            InitializeComponent();
           
        }
        public void init(BusLine bus, int indexb)
        {
            Busline = bus;
            Station = Session.Stations;
            revstation = Session.Stations;
            Index = indexb;
            foreach (BusStation b in Station)
            {
                stationslist.Items.Add(b.Id);
                revstationslist.Items.Add(b.Id);
            }
            CheckItems(bus);
        }
        public void CheckItems(BusLine bus)
        {
            foreach (BusStation b in bus.Stations)
            {
                Console.WriteLine(b.Id + " ID STATION");
                for (int i = 0; i < stationslist.Items.Count; i++)
                {
                    if (b.Id == int.Parse(stationslist.Items[i].ToString()))
                    {
                        stationslist.SetItemChecked(i, true);
                    }
                }

            }
            foreach (BusStation b in bus.RevStations)

            {
                Console.WriteLine(b.Id + " ID Revstation");

                for (int i = 0; i < revstationslist.Items.Count; i++)
                {
                    if (b.Id == int.Parse(revstationslist.Items[i].ToString()))
                    {
                        revstationslist.SetItemChecked(i, true);
                    }
                }

            }
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            List<BusStation> stations = new List<BusStation>();
            List<BusStation> rev = new List<BusStation>();

            foreach (int p in stationslist.CheckedItems)
            {
                BusStation b = new BusStation(p);
                stations.Add(b);
            }
            foreach (int p in revstationslist.CheckedItems)
            {
                BusStation b = new BusStation(p);
                rev.Add(b);
            }
            Busline.Stations = stations;
            Busline.RevStations = rev;
            modifierevent?.Invoke(sender, e);
            this.Close();
        }

        private void modifyBuslineStations_Load(object sender, EventArgs e)
        {

        }
    }
}
