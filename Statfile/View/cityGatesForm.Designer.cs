
namespace Statfile.View
{
    partial class cityGatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cityGatesForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.citygatesDatagridView = new System.Windows.Forms.DataGridView();
            this.edgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outgoingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.entranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.outgoing = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.incoming = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.TextBox();
            this.edge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addline = new System.Windows.Forms.Button();
            this.nextgate = new System.Windows.Forms.Button();
            this.precgate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citygatesDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(418, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Portails de la ville ( City Gates)";
            // 
            // citygatesDatagridView
            // 
            this.citygatesDatagridView.AutoGenerateColumns = false;
            this.citygatesDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citygatesDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edgeDataGridViewTextBoxColumn,
            this.posDataGridViewTextBoxColumn,
            this.incomingDataGridViewTextBoxColumn,
            this.outgoingDataGridViewTextBoxColumn,
            this.Supprimer});
            this.citygatesDatagridView.DataSource = this.entranceBindingSource;
            this.citygatesDatagridView.Location = new System.Drawing.Point(32, 114);
            this.citygatesDatagridView.Margin = new System.Windows.Forms.Padding(8);
            this.citygatesDatagridView.Name = "citygatesDatagridView";
            this.citygatesDatagridView.RowHeadersVisible = false;
            this.citygatesDatagridView.RowHeadersWidth = 80;
            this.citygatesDatagridView.Size = new System.Drawing.Size(504, 387);
            this.citygatesDatagridView.TabIndex = 92;
            this.citygatesDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.citygatesDatagridView_CellContentClick);
            // 
            // edgeDataGridViewTextBoxColumn
            // 
            this.edgeDataGridViewTextBoxColumn.DataPropertyName = "Edge";
            this.edgeDataGridViewTextBoxColumn.HeaderText = "Edge";
            this.edgeDataGridViewTextBoxColumn.Name = "edgeDataGridViewTextBoxColumn";
            // 
            // posDataGridViewTextBoxColumn
            // 
            this.posDataGridViewTextBoxColumn.DataPropertyName = "Pos";
            this.posDataGridViewTextBoxColumn.HeaderText = "Pos";
            this.posDataGridViewTextBoxColumn.Name = "posDataGridViewTextBoxColumn";
            // 
            // incomingDataGridViewTextBoxColumn
            // 
            this.incomingDataGridViewTextBoxColumn.DataPropertyName = "Incoming";
            this.incomingDataGridViewTextBoxColumn.HeaderText = "Incoming";
            this.incomingDataGridViewTextBoxColumn.Name = "incomingDataGridViewTextBoxColumn";
            // 
            // outgoingDataGridViewTextBoxColumn
            // 
            this.outgoingDataGridViewTextBoxColumn.DataPropertyName = "Outgoing";
            this.outgoingDataGridViewTextBoxColumn.HeaderText = "Outgoing";
            this.outgoingDataGridViewTextBoxColumn.Name = "outgoingDataGridViewTextBoxColumn";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // entranceBindingSource
            // 
            this.entranceBindingSource.DataSource = typeof(Statfile.Model.Entrance);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.outgoing);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.incoming);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Controls.Add(this.edge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addline);
            this.panel1.Location = new System.Drawing.Point(570, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 278);
            this.panel1.TabIndex = 93;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(556, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // outgoing
            // 
            this.outgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outgoing.Location = new System.Drawing.Point(416, 160);
            this.outgoing.Name = "outgoing";
            this.outgoing.Size = new System.Drawing.Size(134, 24);
            this.outgoing.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 32);
            this.label6.TabIndex = 107;
            this.label6.Text = "Outgoing\r\n(sortant)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(277, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(556, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // incoming
            // 
            this.incoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incoming.Location = new System.Drawing.Point(135, 160);
            this.incoming.Name = "incoming";
            this.incoming.Size = new System.Drawing.Size(136, 24);
            this.incoming.TabIndex = 103;
            // 
            // pos
            // 
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.Location = new System.Drawing.Point(416, 76);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(134, 24);
            this.pos.TabIndex = 102;
            // 
            // edge
            // 
            this.edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edge.Location = new System.Drawing.Point(135, 76);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(136, 24);
            this.edge.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 100;
            this.label4.Text = "Incoming\r\n(entrant)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 48);
            this.label1.TabIndex = 99;
            this.label1.Text = "Pos\r\n(position)\r\n(m)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 48);
            this.label2.TabIndex = 98;
            this.label2.Text = "Edge\r\n(id de la rue \r\ndans le réseau )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Entrance ( entrée )";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addline
            // 
            this.addline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addline.Location = new System.Drawing.Point(200, 221);
            this.addline.Name = "addline";
            this.addline.Size = new System.Drawing.Size(222, 36);
            this.addline.TabIndex = 94;
            this.addline.Text = "Ajouter";
            this.addline.UseVisualStyleBackColor = false;
            this.addline.Click += new System.EventHandler(this.addline_Click);
            // 
            // nextgate
            // 
            this.nextgate.Location = new System.Drawing.Point(898, 448);
            this.nextgate.Name = "nextgate";
            this.nextgate.Size = new System.Drawing.Size(127, 36);
            this.nextgate.TabIndex = 110;
            this.nextgate.Text = "Suivant";
            this.nextgate.UseVisualStyleBackColor = true;
            this.nextgate.Click += new System.EventHandler(this.nextgate_Click);
            // 
            // precgate
            // 
            this.precgate.Location = new System.Drawing.Point(746, 448);
            this.precgate.Name = "precgate";
            this.precgate.Size = new System.Drawing.Size(127, 36);
            this.precgate.TabIndex = 109;
            this.precgate.Text = "Précèdent";
            this.precgate.UseVisualStyleBackColor = true;
            this.precgate.Click += new System.EventHandler(this.precgate_Click);
            // 
            // cityGatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nextgate);
            this.Controls.Add(this.precgate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.citygatesDatagridView);
            this.Controls.Add(this.panel2);
            this.Name = "cityGatesForm";
            this.Size = new System.Drawing.Size(1233, 511);
            this.Load += new System.EventHandler(this.cityGatesForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citygatesDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView citygatesDatagridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn edgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outgoingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.BindingSource entranceBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox incoming;
        private System.Windows.Forms.TextBox pos;
        private System.Windows.Forms.TextBox edge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addline;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox outgoing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nextgate;
        private System.Windows.Forms.Button precgate;
    }
}
