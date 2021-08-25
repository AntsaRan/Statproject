
namespace Statfile.View
{
    partial class BusLineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusLineForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buslinesgrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTripDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFreq = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.busLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.posinfo = new System.Windows.Forms.PictureBox();
            this.edgeinfo = new System.Windows.Forms.PictureBox();
            this.idbus = new System.Windows.Forms.TextBox();
            this.maxTripDuration = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.labele = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addline = new System.Windows.Forms.Button();
            this.nextbusLines = new System.Windows.Forms.Button();
            this.precbusstation = new System.Windows.Forms.Button();
            this.stationslist = new System.Windows.Forms.CheckedListBox();
            this.revstationlist = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buslinesgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLineBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 100);
            this.panel2.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Lignes de bus (Bus lines)\r\n";
            // 
            // buslinesgrid
            // 
            this.buslinesgrid.AutoGenerateColumns = false;
            this.buslinesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buslinesgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maxTripDurationDataGridViewTextBoxColumn,
            this.addFreq,
            this.Modifier,
            this.Supprimer});
            this.buslinesgrid.DataSource = this.busLineBindingSource;
            this.buslinesgrid.Location = new System.Drawing.Point(13, 154);
            this.buslinesgrid.Name = "buslinesgrid";
            this.buslinesgrid.RowHeadersVisible = false;
            this.buslinesgrid.Size = new System.Drawing.Size(506, 344);
            this.buslinesgrid.TabIndex = 93;
            this.buslinesgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buslinesgrid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // maxTripDurationDataGridViewTextBoxColumn
            // 
            this.maxTripDurationDataGridViewTextBoxColumn.DataPropertyName = "MaxTripDuration";
            this.maxTripDurationDataGridViewTextBoxColumn.HeaderText = "MaxTripDuration";
            this.maxTripDurationDataGridViewTextBoxColumn.Name = "maxTripDurationDataGridViewTextBoxColumn";
            // 
            // addFreq
            // 
            this.addFreq.HeaderText = "Ajouter Fréquences";
            this.addFreq.Name = "addFreq";
            this.addFreq.Text = "Ajouter Fréquences";
            this.addFreq.UseColumnTextForButtonValue = true;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // busLineBindingSource
            // 
            this.busLineBindingSource.DataSource = typeof(Statfile.Model.BusLine);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bl);
            this.panel1.Location = new System.Drawing.Point(13, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 38);
            this.panel1.TabIndex = 94;
            // 
            // bl
            // 
            this.bl.AutoSize = true;
            this.bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl.Location = new System.Drawing.Point(215, 11);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(83, 20);
            this.bl.TabIndex = 0;
            this.bl.Text = "BusLines";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.posinfo);
            this.panel3.Controls.Add(this.edgeinfo);
            this.panel3.Controls.Add(this.idbus);
            this.panel3.Controls.Add(this.maxTripDuration);
            this.panel3.Controls.Add(this.id);
            this.panel3.Controls.Add(this.labele);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(829, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 198);
            this.panel3.TabIndex = 95;
            // 
            // posinfo
            // 
            this.posinfo.Image = ((System.Drawing.Image)(resources.GetObject("posinfo.Image")));
            this.posinfo.Location = new System.Drawing.Point(274, 74);
            this.posinfo.Name = "posinfo";
            this.posinfo.Size = new System.Drawing.Size(29, 19);
            this.posinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.posinfo.TabIndex = 106;
            this.posinfo.TabStop = false;
            this.posinfo.Click += new System.EventHandler(this.posinfo_Click);
            // 
            // edgeinfo
            // 
            this.edgeinfo.Image = ((System.Drawing.Image)(resources.GetObject("edgeinfo.Image")));
            this.edgeinfo.Location = new System.Drawing.Point(274, 127);
            this.edgeinfo.Name = "edgeinfo";
            this.edgeinfo.Size = new System.Drawing.Size(29, 19);
            this.edgeinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.edgeinfo.TabIndex = 105;
            this.edgeinfo.TabStop = false;
            this.edgeinfo.Click += new System.EventHandler(this.edgeinfo_Click);
            // 
            // idbus
            // 
            this.idbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbus.Location = new System.Drawing.Point(132, 72);
            this.idbus.Name = "idbus";
            this.idbus.Size = new System.Drawing.Size(136, 24);
            this.idbus.TabIndex = 103;
            this.idbus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idbus_KeyPress);
            // 
            // maxTripDuration
            // 
            this.maxTripDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTripDuration.Location = new System.Drawing.Point(134, 125);
            this.maxTripDuration.Name = "maxTripDuration";
            this.maxTripDuration.Size = new System.Drawing.Size(134, 24);
            this.maxTripDuration.TabIndex = 102;
            this.maxTripDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxTripDuration_KeyPress);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(107, 77);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 16);
            this.id.TabIndex = 100;
            this.id.Text = "Id\r\n";
            // 
            // labele
            // 
            this.labele.AutoSize = true;
            this.labele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labele.Location = new System.Drawing.Point(17, 125);
            this.labele.Name = "labele";
            this.labele.Size = new System.Drawing.Size(111, 48);
            this.labele.TabIndex = 99;
            this.labele.Text = "maxTripDuration\r\n(durée maximale \r\nde trajet)(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Bus Line ( ligne de bus )";
            this.label5.UseWaitCursor = true;
            // 
            // addline
            // 
            this.addline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addline.Location = new System.Drawing.Point(929, 332);
            this.addline.Name = "addline";
            this.addline.Size = new System.Drawing.Size(222, 36);
            this.addline.TabIndex = 94;
            this.addline.Text = "Ajouter";
            this.addline.UseVisualStyleBackColor = false;
            this.addline.Click += new System.EventHandler(this.addline_Click);
            // 
            // nextbusLines
            // 
            this.nextbusLines.Location = new System.Drawing.Point(1062, 438);
            this.nextbusLines.Name = "nextbusLines";
            this.nextbusLines.Size = new System.Drawing.Size(127, 36);
            this.nextbusLines.TabIndex = 112;
            this.nextbusLines.Text = "Suivant";
            this.nextbusLines.UseVisualStyleBackColor = true;
            this.nextbusLines.Click += new System.EventHandler(this.nextbusLines_Click);
            // 
            // precbusstation
            // 
            this.precbusstation.Location = new System.Drawing.Point(893, 438);
            this.precbusstation.Name = "precbusstation";
            this.precbusstation.Size = new System.Drawing.Size(127, 36);
            this.precbusstation.TabIndex = 111;
            this.precbusstation.Text = "Précèdent";
            this.precbusstation.UseVisualStyleBackColor = true;
            this.precbusstation.Click += new System.EventHandler(this.precbusstation_Click);
            // 
            // stationslist
            // 
            this.stationslist.FormattingEnabled = true;
            this.stationslist.Location = new System.Drawing.Point(537, 154);
            this.stationslist.Name = "stationslist";
            this.stationslist.Size = new System.Drawing.Size(126, 334);
            this.stationslist.TabIndex = 115;
            this.stationslist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // revstationlist
            // 
            this.revstationlist.FormattingEnabled = true;
            this.revstationlist.Location = new System.Drawing.Point(685, 154);
            this.revstationlist.Name = "revstationlist";
            this.revstationlist.Size = new System.Drawing.Size(122, 334);
            this.revstationlist.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(537, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(126, 38);
            this.panel4.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "RevStations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(685, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 38);
            this.panel5.TabIndex = 96;
            // 
            // BusLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.revstationlist);
            this.Controls.Add(this.stationslist);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.nextbusLines);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.precbusstation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buslinesgrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addline);
            this.Name = "BusLineForm";
            this.Size = new System.Drawing.Size(1233, 511);
            this.Load += new System.EventHandler(this.BusLineForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buslinesgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busLineBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView buslinesgrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox edgeinfo;
        private System.Windows.Forms.TextBox maxTripDuration;
        private System.Windows.Forms.Label labele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addline;
        private System.Windows.Forms.Button nextbusLines;
        private System.Windows.Forms.Button precbusstation;
        private System.Windows.Forms.PictureBox posinfo;
        private System.Windows.Forms.TextBox idbus;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.BindingSource busLineBindingSource;
        private System.Windows.Forms.CheckedListBox stationslist;
        private System.Windows.Forms.CheckedListBox revstationlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTripDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn addFreq;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
