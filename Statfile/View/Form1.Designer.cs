
namespace Statfile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.habitantserror = new System.Windows.Forms.ErrorProvider(this.components);
            this.ruebtn = new System.Windows.Forms.Button();
            this.citygates = new System.Windows.Forms.Button();
            this.schoolbtn = new System.Windows.Forms.Button();
            this.busstationbtn = new System.Windows.Forms.Button();
            this.busLinesbtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.generalbtn = new System.Windows.Forms.Button();
            this.paramsbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.busLinesForm1 = new Statfile.View.BusLinesForm();
            this.busStationsForm1 = new Statfile.View.BusStationsForm();
            this.schoolsForm1 = new Statfile.View.schoolsForm();
            this.cityGatesForm1 = new Statfile.View.cityGatesForm();
            this.streetsForm1 = new Statfile.View.streetsForm();
            this.workHours1 = new Statfile.View.workHoursForm();
            this.populationform1 = new Statfile.View.populationform();
            this.finalisation1 = new Statfile.View.finalisation();
            this.parametersForm1 = new Statfile.View.parametersForm();
            this.generalform1 = new Statfile.View.generalform();
            this.finalbtn = new System.Windows.Forms.Button();
            this.popbtn = new System.Windows.Forms.Button();
            this.workbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consignesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.habitantserror)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // habitantserror
            // 
            this.habitantserror.ContainerControl = this;
            // 
            // ruebtn
            // 
            this.habitantserror.SetIconAlignment(this.ruebtn, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.ruebtn.Location = new System.Drawing.Point(437, 39);
            this.ruebtn.Name = "ruebtn";
            this.ruebtn.Size = new System.Drawing.Size(110, 35);
            this.ruebtn.TabIndex = 6;
            this.ruebtn.Text = "Rues";
            this.ruebtn.UseVisualStyleBackColor = true;
            this.ruebtn.Click += new System.EventHandler(this.ruebtn_Click);
            // 
            // citygates
            // 
            this.habitantserror.SetIconAlignment(this.citygates, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.citygates.Location = new System.Drawing.Point(545, 39);
            this.citygates.Name = "citygates";
            this.citygates.Size = new System.Drawing.Size(110, 35);
            this.citygates.TabIndex = 7;
            this.citygates.Text = "CityGates";
            this.citygates.UseVisualStyleBackColor = true;
            this.citygates.Click += new System.EventHandler(this.citygates_Click);
            // 
            // schoolbtn
            // 
            this.habitantserror.SetIconAlignment(this.schoolbtn, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.schoolbtn.Location = new System.Drawing.Point(653, 39);
            this.schoolbtn.Name = "schoolbtn";
            this.schoolbtn.Size = new System.Drawing.Size(110, 35);
            this.schoolbtn.TabIndex = 8;
            this.schoolbtn.Text = "Schools";
            this.schoolbtn.UseVisualStyleBackColor = true;
            this.schoolbtn.Click += new System.EventHandler(this.schoolbtn_Click);
            // 
            // busstationbtn
            // 
            this.habitantserror.SetIconAlignment(this.busstationbtn, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.busstationbtn.Location = new System.Drawing.Point(760, 39);
            this.busstationbtn.Name = "busstationbtn";
            this.busstationbtn.Size = new System.Drawing.Size(110, 35);
            this.busstationbtn.TabIndex = 9;
            this.busstationbtn.Text = "Bus Stations";
            this.busstationbtn.UseVisualStyleBackColor = true;
            this.busstationbtn.Click += new System.EventHandler(this.busstationbtn_Click);
            // 
            // busLinesbtn
            // 
            this.habitantserror.SetIconAlignment(this.busLinesbtn, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.busLinesbtn.Location = new System.Drawing.Point(867, 39);
            this.busLinesbtn.Name = "busLinesbtn";
            this.busLinesbtn.Size = new System.Drawing.Size(110, 35);
            this.busLinesbtn.TabIndex = 10;
            this.busLinesbtn.Text = "Buslines";
            this.busLinesbtn.UseVisualStyleBackColor = true;
            this.busLinesbtn.Click += new System.EventHandler(this.busLinesbtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // generalbtn
            // 
            this.generalbtn.Location = new System.Drawing.Point(6, 39);
            this.generalbtn.Name = "generalbtn";
            this.generalbtn.Size = new System.Drawing.Size(110, 35);
            this.generalbtn.TabIndex = 0;
            this.generalbtn.Text = "Général";
            this.generalbtn.UseVisualStyleBackColor = true;
            this.generalbtn.Click += new System.EventHandler(this.generalbtn_Click);
            // 
            // paramsbtn
            // 
            this.paramsbtn.Location = new System.Drawing.Point(113, 39);
            this.paramsbtn.Name = "paramsbtn";
            this.paramsbtn.Size = new System.Drawing.Size(110, 35);
            this.paramsbtn.TabIndex = 1;
            this.paramsbtn.Text = "Paramètres";
            this.paramsbtn.UseVisualStyleBackColor = true;
            this.paramsbtn.Click += new System.EventHandler(this.paramsbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.busLinesForm1);
            this.panel1.Controls.Add(this.busStationsForm1);
            this.panel1.Controls.Add(this.schoolsForm1);
            this.panel1.Controls.Add(this.cityGatesForm1);
            this.panel1.Controls.Add(this.streetsForm1);
            this.panel1.Controls.Add(this.workHours1);
            this.panel1.Controls.Add(this.populationform1);
            this.panel1.Controls.Add(this.finalisation1);
            this.panel1.Controls.Add(this.parametersForm1);
            this.panel1.Controls.Add(this.generalform1);
            this.panel1.Location = new System.Drawing.Point(7, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 511);
            this.panel1.TabIndex = 2;
            // 
            // busLinesForm1
            // 
            this.busLinesForm1.BuslineId = 1;
            this.busLinesForm1.Buslines = null;
            this.busLinesForm1.BusRevStations = null;
            this.busLinesForm1.BusStations = null;
            this.busLinesForm1.Freq = null;
            this.busLinesForm1.Location = new System.Drawing.Point(6, 3);
            this.busLinesForm1.Name = "busLinesForm1";
            this.busLinesForm1.Size = new System.Drawing.Size(1233, 511);
            this.busLinesForm1.TabIndex = 9;
            this.busLinesForm1.Load += new System.EventHandler(this.busLinesForm1_Load);
            // 
            // busStationsForm1
            // 
            this.busStationsForm1.BusstationId = 1;
            this.busStationsForm1.BusStations = null;
            this.busStationsForm1.Location = new System.Drawing.Point(6, 0);
            this.busStationsForm1.Name = "busStationsForm1";
            this.busStationsForm1.Size = new System.Drawing.Size(1233, 511);
            this.busStationsForm1.TabIndex = 8;
            // 
            // schoolsForm1
            // 
            this.schoolsForm1.Location = new System.Drawing.Point(5, 6);
            this.schoolsForm1.Name = "schoolsForm1";
            this.schoolsForm1.Size = new System.Drawing.Size(1233, 511);
            this.schoolsForm1.TabIndex = 7;
            // 
            // cityGatesForm1
            // 
            this.cityGatesForm1.Location = new System.Drawing.Point(3, 6);
            this.cityGatesForm1.Name = "cityGatesForm1";
            this.cityGatesForm1.Size = new System.Drawing.Size(1233, 511);
            this.cityGatesForm1.TabIndex = 6;
            // 
            // streetsForm1
            // 
            this.streetsForm1.Location = new System.Drawing.Point(3, 6);
            this.streetsForm1.Name = "streetsForm1";
            this.streetsForm1.Size = new System.Drawing.Size(1233, 505);
            this.streetsForm1.TabIndex = 5;
            // 
            // workHours1
            // 
            this.workHours1.Location = new System.Drawing.Point(3, 3);
            this.workHours1.Name = "workHours1";
            this.workHours1.Size = new System.Drawing.Size(1230, 511);
            this.workHours1.TabIndex = 4;
            // 
            // populationform1
            // 
            this.populationform1.Location = new System.Drawing.Point(0, 0);
            this.populationform1.Name = "populationform1";
            this.populationform1.Size = new System.Drawing.Size(1233, 511);
            this.populationform1.TabIndex = 3;
            // 
            // finalisation1
            // 
            this.finalisation1.BackColor = System.Drawing.Color.White;
            this.finalisation1.Location = new System.Drawing.Point(-1, 0);
            this.finalisation1.Name = "finalisation1";
            this.finalisation1.Size = new System.Drawing.Size(1233, 511);
            this.finalisation1.TabIndex = 2;
            // 
            // parametersForm1
            // 
            this.parametersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersForm1.Location = new System.Drawing.Point(0, 0);
            this.parametersForm1.Name = "parametersForm1";
            this.parametersForm1.Size = new System.Drawing.Size(1233, 511);
            this.parametersForm1.TabIndex = 1;
            // 
            // generalform1
            // 
            this.generalform1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalform1.Location = new System.Drawing.Point(0, 0);
            this.generalform1.Name = "generalform1";
            this.generalform1.Size = new System.Drawing.Size(1233, 511);
            this.generalform1.TabIndex = 0;
            // 
            // finalbtn
            // 
            this.finalbtn.BackColor = System.Drawing.Color.LightGreen;
            this.finalbtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.finalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalbtn.ForeColor = System.Drawing.Color.Black;
            this.finalbtn.Location = new System.Drawing.Point(971, 39);
            this.finalbtn.Margin = new System.Windows.Forms.Padding(0);
            this.finalbtn.Name = "finalbtn";
            this.finalbtn.Size = new System.Drawing.Size(110, 35);
            this.finalbtn.TabIndex = 3;
            this.finalbtn.Text = "Finaliser";
            this.finalbtn.UseVisualStyleBackColor = false;
            // 
            // popbtn
            // 
            this.popbtn.Location = new System.Drawing.Point(221, 39);
            this.popbtn.Name = "popbtn";
            this.popbtn.Size = new System.Drawing.Size(110, 35);
            this.popbtn.TabIndex = 4;
            this.popbtn.Text = "Population";
            this.popbtn.UseVisualStyleBackColor = true;
            this.popbtn.Click += new System.EventHandler(this.popbtn_Click);
            // 
            // workbtn
            // 
            this.workbtn.Location = new System.Drawing.Point(329, 39);
            this.workbtn.Name = "workbtn";
            this.workbtn.Size = new System.Drawing.Size(110, 35);
            this.workbtn.TabIndex = 5;
            this.workbtn.Text = "Heures de travail";
            this.workbtn.UseVisualStyleBackColor = true;
            this.workbtn.Click += new System.EventHandler(this.workbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUMOToolStripMenuItem,
            this.consignesToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aideToolStripMenuItem.Text = "Aide?";
            // 
            // sUMOToolStripMenuItem
            // 
            this.sUMOToolStripMenuItem.Name = "sUMOToolStripMenuItem";
            this.sUMOToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sUMOToolStripMenuItem.Text = "SUMO";
            this.sUMOToolStripMenuItem.Click += new System.EventHandler(this.sUMOToolStripMenuItem_Click);
            // 
            // consignesToolStripMenuItem
            // 
            this.consignesToolStripMenuItem.Name = "consignesToolStripMenuItem";
            this.consignesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.consignesToolStripMenuItem.Text = "Consignes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1243, 588);
            this.Controls.Add(this.busLinesbtn);
            this.Controls.Add(this.busstationbtn);
            this.Controls.Add(this.schoolbtn);
            this.Controls.Add(this.citygates);
            this.Controls.Add(this.ruebtn);
            this.Controls.Add(this.workbtn);
            this.Controls.Add(this.popbtn);
            this.Controls.Add(this.finalbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paramsbtn);
            this.Controls.Add(this.generalbtn);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.habitantserror)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider habitantserror;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button generalbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button paramsbtn;
        private View.generalform generalform1;
        private System.Windows.Forms.Button finalbtn;
        private View.parametersForm parametersForm1;
        private View.finalisation finalisation1;
        private System.Windows.Forms.Button schoolbtn;
        private System.Windows.Forms.Button citygates;
        private System.Windows.Forms.Button ruebtn;
        private System.Windows.Forms.Button workbtn;
        private System.Windows.Forms.Button popbtn;
        private System.Windows.Forms.Button busLinesbtn;
        private System.Windows.Forms.Button busstationbtn;
        private View.populationform populationform1;
        private View.workHoursForm workHours1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUMOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consignesToolStripMenuItem;
        private View.streetsForm streetsForm1;
        private View.cityGatesForm cityGatesForm1;
        private View.schoolsForm schoolsForm1;
        private View.BusStationsForm busStationsForm1;
        private View.BusLinesForm busLinesForm1;
    }
}

