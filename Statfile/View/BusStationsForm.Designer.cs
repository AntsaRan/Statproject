
namespace Statfile.View
{
    partial class BusStationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusStationsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.busStationDatagridView = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.busStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.posinfo = new System.Windows.Forms.PictureBox();
            this.edgeinfo = new System.Windows.Forms.PictureBox();
            this.position = new System.Windows.Forms.TextBox();
            this.edge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addline = new System.Windows.Forms.Button();
            this.nextbusstation = new System.Windows.Forms.Button();
            this.precbusstation = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busStationDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(393, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Arrêts de bus ( Bus stations )";
            // 
            // busStationDatagridView
            // 
            this.busStationDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busStationDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supprimer});
            this.busStationDatagridView.Location = new System.Drawing.Point(46, 116);
            this.busStationDatagridView.Margin = new System.Windows.Forms.Padding(8);
            this.busStationDatagridView.Name = "busStationDatagridView";
            this.busStationDatagridView.RowHeadersVisible = false;
            this.busStationDatagridView.RowHeadersWidth = 80;
            this.busStationDatagridView.Size = new System.Drawing.Size(403, 387);
            this.busStationDatagridView.TabIndex = 92;
            this.busStationDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.streetDatagridView_CellContentClick);
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.posinfo);
            this.panel1.Controls.Add(this.edgeinfo);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.edge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addline);
            this.panel1.Location = new System.Drawing.Point(538, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 236);
            this.panel1.TabIndex = 93;
            // 
            // posinfo
            // 
            this.posinfo.Image = ((System.Drawing.Image)(resources.GetObject("posinfo.Image")));
            this.posinfo.Location = new System.Drawing.Point(273, 77);
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
            this.edgeinfo.Location = new System.Drawing.Point(548, 77);
            this.edgeinfo.Name = "edgeinfo";
            this.edgeinfo.Size = new System.Drawing.Size(29, 19);
            this.edgeinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.edgeinfo.TabIndex = 105;
            this.edgeinfo.TabStop = false;
            this.edgeinfo.Click += new System.EventHandler(this.edgeinfo_Click);
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(131, 77);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(136, 24);
            this.position.TabIndex = 103;
            this.position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.position_KeyPress);
            // 
            // edge
            // 
            this.edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edge.Location = new System.Drawing.Point(408, 75);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(134, 24);
            this.edge.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 99;
            this.label1.Text = "Edge\r\n(rue)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Bus Station ( Arrêt )";
            this.label5.UseWaitCursor = true;
            // 
            // addline
            // 
            this.addline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addline.Location = new System.Drawing.Point(220, 161);
            this.addline.Name = "addline";
            this.addline.Size = new System.Drawing.Size(222, 36);
            this.addline.TabIndex = 94;
            this.addline.Text = "Ajouter";
            this.addline.UseVisualStyleBackColor = false;
            this.addline.Click += new System.EventHandler(this.addline_Click);
            // 
            // nextbusstation
            // 
            this.nextbusstation.Location = new System.Drawing.Point(869, 413);
            this.nextbusstation.Name = "nextbusstation";
            this.nextbusstation.Size = new System.Drawing.Size(127, 36);
            this.nextbusstation.TabIndex = 110;
            this.nextbusstation.Text = "Suivant";
            this.nextbusstation.UseVisualStyleBackColor = true;
            this.nextbusstation.Click += new System.EventHandler(this.nextbusstation_Click);
            // 
            // precbusstation
            // 
            this.precbusstation.Location = new System.Drawing.Point(717, 413);
            this.precbusstation.Name = "precbusstation";
            this.precbusstation.Size = new System.Drawing.Size(127, 36);
            this.precbusstation.TabIndex = 109;
            this.precbusstation.Text = "Précèdent";
            this.precbusstation.UseVisualStyleBackColor = true;
            this.precbusstation.Click += new System.EventHandler(this.precbusstation_Click);
            // 
            // BusStationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nextbusstation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.precbusstation);
            this.Controls.Add(this.busStationDatagridView);
            this.Controls.Add(this.panel2);
            this.Name = "BusStationsForm";
            this.Size = new System.Drawing.Size(1233, 511);
            this.Load += new System.EventHandler(this.BusStationsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busStationDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busStationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView busStationDatagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.BindingSource busStationBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox posinfo;
        private System.Windows.Forms.PictureBox edgeinfo;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox edge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addline;
        private System.Windows.Forms.Button nextbusstation;
        private System.Windows.Forms.Button precbusstation;
    }
}
