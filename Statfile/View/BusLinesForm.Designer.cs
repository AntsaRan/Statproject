
namespace Statfile.View
{
    partial class BusLinesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusLinesForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.busLinesDatagridView = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.busLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.maxtripduration = new System.Windows.Forms.TextBox();
            this.frequenciesDatagrid = new System.Windows.Forms.DataGridView();
            this.IdBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.frequencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxtripinfo = new System.Windows.Forms.PictureBox();
            this.endinfo = new System.Windows.Forms.PictureBox();
            this.begininfo = new System.Windows.Forms.PictureBox();
            this.rateinfo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.stationsList = new System.Windows.Forms.ListBox();
            this.nextbusline = new System.Windows.Forms.Button();
            this.precbusline = new System.Windows.Forms.Button();
            this.busStationsFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busLinesFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busLinesFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.revstation = new System.Windows.Forms.ListBox();
            this.stationGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.busStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.revGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.busStationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Addline = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busLinesDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxtripinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begininfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateinfo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busStationsFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLinesFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLinesFormBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBindingSource)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 100);
            this.panel2.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Lignes de bus ( Bus Lines )";
            // 
            // busLinesDatagridView
            // 
            this.busLinesDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busLinesDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supprimer});
            this.busLinesDatagridView.Location = new System.Drawing.Point(8, 162);
            this.busLinesDatagridView.Margin = new System.Windows.Forms.Padding(8);
            this.busLinesDatagridView.Name = "busLinesDatagridView";
            this.busLinesDatagridView.RowHeadersVisible = false;
            this.busLinesDatagridView.RowHeadersWidth = 80;
            this.busLinesDatagridView.Size = new System.Drawing.Size(304, 234);
            this.busLinesDatagridView.TabIndex = 94;
            this.busLinesDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busStationDatagridView_CellContentClick);
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 95;
            this.label1.Text = "MaxTripDuration\r\n( Durée maximum\r\n trajet)(s)";
            // 
            // maxtripduration
            // 
            this.maxtripduration.Location = new System.Drawing.Point(849, 173);
            this.maxtripduration.Name = "maxtripduration";
            this.maxtripduration.Size = new System.Drawing.Size(91, 20);
            this.maxtripduration.TabIndex = 96;
            this.maxtripduration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxtripduration_KeyPress);
            // 
            // frequenciesDatagrid
            // 
            this.frequenciesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequenciesDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBus,
            this.dataGridViewButtonColumn1});
            this.frequenciesDatagrid.Location = new System.Drawing.Point(329, 161);
            this.frequenciesDatagrid.Margin = new System.Windows.Forms.Padding(8);
            this.frequenciesDatagrid.Name = "frequenciesDatagrid";
            this.frequenciesDatagrid.RowHeadersVisible = false;
            this.frequenciesDatagrid.RowHeadersWidth = 80;
            this.frequenciesDatagrid.Size = new System.Drawing.Size(407, 234);
            this.frequenciesDatagrid.TabIndex = 97;
            this.frequenciesDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frequenciesDatagrid_CellContentClick);
            // 
            // IdBus
            // 
            this.IdBus.HeaderText = "IdBus";
            this.IdBus.Name = "IdBus";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Supprimer";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Supprimer";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 46);
            this.panel1.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bus Lines ( Lignes de Bus)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(329, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 46);
            this.panel3.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Frequencies (Frequences)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(961, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 65);
            this.label6.TabIndex = 101;
            this.label6.Text = "Begin \r\n(début de \r\nfréquence)\r\n(s)\r\n ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(1096, 173);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(85, 20);
            this.begin.TabIndex = 102;
            this.begin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.begin_KeyPress);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(849, 241);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(91, 20);
            this.end.TabIndex = 104;
            this.end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.end_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(754, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 39);
            this.label7.TabIndex = 103;
            this.label7.Text = "End \r\n(fin de fréquence)\r\n (s)";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(1096, 241);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(85, 20);
            this.rate.TabIndex = 106;
            this.rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rate_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1025, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 52);
            this.label8.TabIndex = 105;
            this.label8.Text = "Rate \r\n(temps entre\r\ndeux bus)\r\n (s)";
            // 
            // maxtripinfo
            // 
            this.maxtripinfo.Image = ((System.Drawing.Image)(resources.GetObject("maxtripinfo.Image")));
            this.maxtripinfo.Location = new System.Drawing.Point(957, 162);
            this.maxtripinfo.Name = "maxtripinfo";
            this.maxtripinfo.Size = new System.Drawing.Size(28, 31);
            this.maxtripinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maxtripinfo.TabIndex = 107;
            this.maxtripinfo.TabStop = false;
            this.maxtripinfo.Click += new System.EventHandler(this.maxtripinfo_Click);
            // 
            // endinfo
            // 
            this.endinfo.Image = ((System.Drawing.Image)(resources.GetObject("endinfo.Image")));
            this.endinfo.Location = new System.Drawing.Point(957, 238);
            this.endinfo.Name = "endinfo";
            this.endinfo.Size = new System.Drawing.Size(28, 32);
            this.endinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.endinfo.TabIndex = 108;
            this.endinfo.TabStop = false;
            this.endinfo.Click += new System.EventHandler(this.endinfo_Click);
            // 
            // begininfo
            // 
            this.begininfo.Image = ((System.Drawing.Image)(resources.GetObject("begininfo.Image")));
            this.begininfo.Location = new System.Drawing.Point(1196, 161);
            this.begininfo.Name = "begininfo";
            this.begininfo.Size = new System.Drawing.Size(28, 32);
            this.begininfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.begininfo.TabIndex = 109;
            this.begininfo.TabStop = false;
            this.begininfo.Click += new System.EventHandler(this.begininfo_Click);
            // 
            // rateinfo
            // 
            this.rateinfo.Image = ((System.Drawing.Image)(resources.GetObject("rateinfo.Image")));
            this.rateinfo.Location = new System.Drawing.Point(1196, 230);
            this.rateinfo.Name = "rateinfo";
            this.rateinfo.Size = new System.Drawing.Size(28, 32);
            this.rateinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rateinfo.TabIndex = 110;
            this.rateinfo.TabStop = false;
            this.rateinfo.Click += new System.EventHandler(this.rateinfo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(741, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 31);
            this.panel4.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bus Lines ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(746, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 31);
            this.panel5.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Stations";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(994, 310);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 31);
            this.panel6.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "revStation";
            // 
            // stationsList
            // 
            this.stationsList.FormattingEnabled = true;
            this.stationsList.Location = new System.Drawing.Point(747, 347);
            this.stationsList.Name = "stationsList";
            this.stationsList.Size = new System.Drawing.Size(238, 186);
            this.stationsList.TabIndex = 111;
            this.stationsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nextbusline
            // 
            this.nextbusline.Location = new System.Drawing.Point(986, 638);
            this.nextbusline.Name = "nextbusline";
            this.nextbusline.Size = new System.Drawing.Size(127, 36);
            this.nextbusline.TabIndex = 113;
            this.nextbusline.Text = "Suivant";
            this.nextbusline.UseVisualStyleBackColor = true;
            this.nextbusline.Click += new System.EventHandler(this.nextbusstation_Click);
            // 
            // precbusline
            // 
            this.precbusline.Location = new System.Drawing.Point(853, 638);
            this.precbusline.Name = "precbusline";
            this.precbusline.Size = new System.Drawing.Size(127, 36);
            this.precbusline.TabIndex = 112;
            this.precbusline.Text = "Précèdent";
            this.precbusline.UseVisualStyleBackColor = true;
            this.precbusline.Click += new System.EventHandler(this.precbusstation_Click);
            // 
            // revstation
            // 
            this.revstation.FormattingEnabled = true;
            this.revstation.Location = new System.Drawing.Point(995, 347);
            this.revstation.Name = "revstation";
            this.revstation.Size = new System.Drawing.Size(229, 186);
            this.revstation.TabIndex = 114;
            this.revstation.SelectedIndexChanged += new System.EventHandler(this.revstation_SelectedIndexChanged);
            // 
            // stationGrid
            // 
            this.stationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn2});
            this.stationGrid.Location = new System.Drawing.Point(128, 457);
            this.stationGrid.Margin = new System.Windows.Forms.Padding(8);
            this.stationGrid.Name = "stationGrid";
            this.stationGrid.RowHeadersVisible = false;
            this.stationGrid.RowHeadersWidth = 80;
            this.stationGrid.Size = new System.Drawing.Size(200, 234);
            this.stationGrid.TabIndex = 115;
            this.stationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stationGrid_CellContentClick);
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Supprimer";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Supprimer";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(128, 407);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 46);
            this.panel7.TabIndex = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Stations (Arrêt)";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(347, 407);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(203, 46);
            this.panel8.TabIndex = 101;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 36);
            this.label13.TabIndex = 1;
            this.label13.Text = "Reverse Station \r\n(Arrêt opposé)";
            // 
            // revGrid
            // 
            this.revGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn3});
            this.revGrid.Location = new System.Drawing.Point(347, 457);
            this.revGrid.Margin = new System.Windows.Forms.Padding(8);
            this.revGrid.Name = "revGrid";
            this.revGrid.RowHeadersVisible = false;
            this.revGrid.RowHeadersWidth = 80;
            this.revGrid.Size = new System.Drawing.Size(203, 234);
            this.revGrid.TabIndex = 116;
            this.revGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revGrid_CellContentClick);
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Supprimer";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Text = "Supprimer";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // Addline
            // 
            this.Addline.Location = new System.Drawing.Point(911, 576);
            this.Addline.Name = "Addline";
            this.Addline.Size = new System.Drawing.Size(139, 37);
            this.Addline.TabIndex = 117;
            this.Addline.Text = "Ajouter";
            this.Addline.UseVisualStyleBackColor = true;
            this.Addline.Click += new System.EventHandler(this.Addline_Click);
            // 
            // BusLinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Addline);
            this.Controls.Add(this.revGrid);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.stationGrid);
            this.Controls.Add(this.revstation);
            this.Controls.Add(this.nextbusline);
            this.Controls.Add(this.precbusline);
            this.Controls.Add(this.stationsList);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rateinfo);
            this.Controls.Add(this.begininfo);
            this.Controls.Add(this.endinfo);
            this.Controls.Add(this.maxtripinfo);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frequenciesDatagrid);
            this.Controls.Add(this.maxtripduration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busLinesDatagridView);
            this.Controls.Add(this.panel2);
            this.Name = "BusLinesForm";
            this.Size = new System.Drawing.Size(1233, 692);
            this.Load += new System.EventHandler(this.BusLinesForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busLinesDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxtripinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begininfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateinfo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busStationsFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLinesFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLinesFormBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBindingSource)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView busLinesDatagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTripDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.BindingSource busLineBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxtripduration;
        private System.Windows.Forms.DataGridView frequenciesDatagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox begin;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox maxtripinfo;
        private System.Windows.Forms.PictureBox endinfo;
        private System.Windows.Forms.PictureBox begininfo;
        private System.Windows.Forms.PictureBox rateinfo;
        private System.Windows.Forms.BindingSource frequencyBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox stationsList;
        private System.Windows.Forms.BindingSource busStationsFormBindingSource;
        private System.Windows.Forms.BindingSource busLinesFormBindingSource;
        private System.Windows.Forms.BindingSource busLinesFormBindingSource1;
        private System.Windows.Forms.Button nextbusline;
        private System.Windows.Forms.Button precbusline;
        private System.Windows.Forms.ListBox revstation;
        private System.Windows.Forms.DataGridView stationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView revGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.Button Addline;
        private System.Windows.Forms.BindingSource busStationBindingSource;
        private System.Windows.Forms.BindingSource busStationBindingSource1;
    }
}
