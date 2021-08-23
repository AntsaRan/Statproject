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

namespace Statfile.View
{
    public partial class finalisation : UserControl
    {
        public string path;
        public string nomfichierxml;
        private General general;
        private Parameters parameters;
        public EventHandler startgeneration;

        public finalisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathsave.Text = folderBrowserDialog1.SelectedPath;
                path = pathsave.Text;
                path = path.Replace(@"\", @"\\");
                nomfichierxml = nomfichier.Text;
            }
        }
         

        private void finaliser_Click(object sender, EventArgs e)
        {
            startgeneration?.Invoke(sender, e);
            /*CSVgen gen = new CSVgen();
            gen.writeXML(path);*/
        }
    }
}
