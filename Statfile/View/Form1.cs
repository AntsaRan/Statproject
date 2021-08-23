using Statfile.Controller;
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

namespace Statfile
{
    public partial class Form1 : Form
    {
     
        private string path;

        public Form1()
        {
            InitializeComponent();
            disablebuttons();
            busStationsForm1.BringToFront();

            // Ecoute les évènements du formulaire " général" click bouton enablenext
            generalform1.enablenext += new EventHandler(Generalform_enablenext);
            // Ecoute les évènements du formulaire " parametres" validerform
            parametersForm1.validerform += new EventHandler(Parametre_valider);
            // Ecoute les évènements du formulaire " parametres" precedent
            parametersForm1.precedent += new EventHandler(Parametre_precedent);
            // Ecoute les évènements du formulaire " finalisation" startgeneration
            finalisation1.startgeneration += new EventHandler(generateXML);
            // Ecoute les évènements du formulaire " population" precedent
            populationform1.precedent += new EventHandler(Population_precedent);
            // Ecoute les évènements du formulaire " population" suivant
            populationform1.suivantform += new EventHandler(Population_next);
            // Ecoute les évènements du formulaire " work" precedent
            workHours1.precedent += new EventHandler(Work_percedent);
            // Ecoute les évènements du formulaire " work" suivant
            workHours1.suivantform += new EventHandler(Work_next);
            // Ecoute les évènements du formulaire " sreets" precedent
            streetsForm1.precedent += new EventHandler(Street_percedent);
            // Ecoute les évènements du formulaire " streers" suivant
            streetsForm1.suivantform += new EventHandler(Street_suivant);
            // Ecoute les évènements du formulaire " cityGatesForm1" precedent
            cityGatesForm1.precedent += new EventHandler(City_percedent);
            // Ecoute les évènements du formulaire " cityGatesForm1" suivant
            cityGatesForm1.suivantform += new EventHandler(City_suivant);
            // Ecoute les évènements du formulaire " schoolsForm1" precedent
            schoolsForm1.precedent += new EventHandler(School_percedent);
            // Ecoute les évènements du formulaire " schoolsForm1" suivant
            schoolsForm1.suivantform += new EventHandler(School_suivant);
            // Ecoute les évènements du formulaire " busstation" precedent
            busStationsForm1.precedent += new EventHandler(BusStation_percedent);
            // Ecoute les évènements du formulaire " busstation" suivant
            busStationsForm1.suivantform += new EventHandler(BusStation_suivant);
            // Ecoute les évènements du formulaire " busstation" precedent
            busLineForm2.precedent += new EventHandler(BusLine_percedent);
            // Ecoute les évènements du formulaire " busstation" suivant
            busLineForm2.suivantform += new EventHandler(BusLine_suivant);
        }
        private void BusLine_percedent(object sender, EventArgs e)
        {
            busStationsForm1.BringToFront();

        }
        private void BusLine_suivant(object sender, EventArgs e)
        {
            busstationbtn.Enabled = true;
            // finalisation1.BringToFront();
            busStationsForm1.BringToFront();
        }
        private void School_percedent(object sender, EventArgs e)
        {
            cityGatesForm1.BringToFront();

        }
        private void School_suivant(object sender, EventArgs e)
        {
            busstationbtn.Enabled = true;
           // finalisation1.BringToFront();
            busStationsForm1.BringToFront();
        }
        private void BusStation_percedent(object sender, EventArgs e)
        {
            schoolsForm1.BringToFront();

        }
        private void BusStation_suivant(object sender, EventArgs e)
        {
            busLinesbtn.Enabled = true;
            busLineForm2.setstations(busStationsForm1.BusStations);
            busLineForm2.BringToFront();
            //cityGatesForm1.BringToFront();
        }
        private void City_percedent(object sender, EventArgs e)
        {
            streetsForm1.BringToFront();

        }
        private void City_suivant(object sender, EventArgs e)
        {
            schoolbtn.Enabled = true;
            schoolsForm1.BringToFront();
            //finalisation1.BringToFront();
            //cityGatesForm1.BringToFront();
        }
        private void Street_percedent(object sender, EventArgs e)
        {
            workHours1.BringToFront();

        }
        private void Street_suivant(object sender, EventArgs e)
        {
            citygates.Enabled = true;
            //finalisation1.BringToFront();
            cityGatesForm1.BringToFront();
        }
        private void Generalform_enablenext(object sender, EventArgs e)
        {
           paramsbtn.Enabled = true;
           parametersForm1.BringToFront();
        }
        private void Parametre_valider(object sender, EventArgs e)
        {
            popbtn.Enabled = true;
            populationform1.BringToFront();
        }
        private void Population_precedent(object sender, EventArgs e)
        {
            parametersForm1.BringToFront();
        }
        private void Parametre_precedent(object sender, EventArgs e)
        {
            generalform1.BringToFront();
        }
        private void Population_next(object sender, EventArgs e)
        {
            workbtn.Enabled = true;
            workHours1.BringToFront();
        }
        private void Work_percedent(object sender, EventArgs e)
        {
            populationform1.BringToFront();
        }
        private void Work_next(object sender, EventArgs e)
        {
            ruebtn.Enabled = true;
            streetsForm1.BringToFront();
        }

     
        public void genererGeneral()
        {
        }
        public void generateXML(object sender, EventArgs e)
        {
            General general = generalform1.General;
            Parameters parameters = parametersForm1.Parameters;
            path = finalisation1.path +"\\"+ finalisation1.nomfichierxml+ ".xml";
            XMLgen csv = new XMLgen();
            csv.General = general;
            csv.Parameters = parameters;
            csv.Population = populationform1.Pop;
            csv.Openings = workHours1.Open;
            csv.Closings = workHours1.Close;
            csv.Streets = streetsForm1.Streets;
            csv.Entrances = cityGatesForm1.Entrances;
            csv.Schools = schoolsForm1.Schools;
            csv.Busstation = busStationsForm1.BusStations;
            csv.writeXML(path);
        }

        private void finalbtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }


        public void disablebuttons()
        {
            paramsbtn.Enabled = false;
            finalbtn.Enabled = false;
            popbtn.Enabled = false;
            workbtn.Enabled = false;
            citygates.Enabled = false;
            ruebtn.Enabled = false;
            busstationbtn.Enabled = false;
            schoolbtn.Enabled = false;
            busstationbtn.Enabled = false;
            busLinesbtn.Enabled = false;
        }

    

        private void populationform1_Load(object sender, EventArgs e)
        {

        }

        private void sUMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sumo.dlr.de/docs/Demand/Activity-based_Demand_Generation.html");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        // BOUTONS
        private void neutralbtn()
        {
            foreach (Button btn in Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.DarkGray)
                {
                    btn.BackColor = Color.LightGray;
                }
            }
        }

        private void paramsbtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            paramsbtn.BackColor = Color.DarkGray;
            parametersForm1.BringToFront();
        }

        private void generalbtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            generalbtn.BackColor = Color.DarkGray;
            generalform1.BringToFront();
        }
        private void popbtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            popbtn.BackColor = Color.DarkGray;
            populationform1.BringToFront();
        }

        private void ruebtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            ruebtn.BackColor = Color.DarkGray;
            streetsForm1.BringToFront();
        }

        private void citygates_Click(object sender, EventArgs e)
        {
            neutralbtn();
            citygates.BackColor = Color.DarkGray;
            cityGatesForm1.BringToFront();
        }

        private void schoolbtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            schoolbtn.BackColor = Color.DarkGray;
            schoolsForm1.BringToFront();
        }

        private void busstationbtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            busstationbtn.BackColor = Color.DarkGray;
            busStationsForm1.BringToFront();
        }

        private void busLinesbtn_Click(object sender, EventArgs e)
        {
            neutralbtn();
            busLinesbtn.BackColor = Color.DarkGray;
        }


    }
}
