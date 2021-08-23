
namespace Statfile.View
{
    partial class schoolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schoolsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.schoolDatagridView = new System.Windows.Forms.DataGridView();
            this.edgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.addline = new System.Windows.Forms.Button();
            this.endageinfo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EndAge = new System.Windows.Forms.TextBox();
            this.closeinfo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Closing = new System.Windows.Forms.TextBox();
            this.begininfo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BeginAge = new System.Windows.Forms.TextBox();
            this.openinfo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Opening = new System.Windows.Forms.TextBox();
            this.posinfo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.TextBox();
            this.capinfo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.edgeinfo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edge = new System.Windows.Forms.TextBox();
            this.precpop = new System.Windows.Forms.Button();
            this.nextpop = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endageinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begininfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capinfo)).BeginInit();
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
            this.panel2.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Ecoles ( Schools )";
            // 
            // schoolDatagridView
            // 
            this.schoolDatagridView.AutoGenerateColumns = false;
            this.schoolDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edgeDataGridViewTextBoxColumn,
            this.posDataGridViewTextBoxColumn,
            this.beginAgeDataGridViewTextBoxColumn,
            this.endAgeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.openingDataGridViewTextBoxColumn,
            this.closingDataGridViewTextBoxColumn,
            this.Supprimer});
            this.schoolDatagridView.DataSource = this.schoolBindingSource;
            this.schoolDatagridView.Location = new System.Drawing.Point(3, 116);
            this.schoolDatagridView.Margin = new System.Windows.Forms.Padding(8);
            this.schoolDatagridView.Name = "schoolDatagridView";
            this.schoolDatagridView.RowHeadersVisible = false;
            this.schoolDatagridView.RowHeadersWidth = 80;
            this.schoolDatagridView.Size = new System.Drawing.Size(703, 387);
            this.schoolDatagridView.TabIndex = 91;
            this.schoolDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.popDatagridView_CellContentClick);
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
            // beginAgeDataGridViewTextBoxColumn
            // 
            this.beginAgeDataGridViewTextBoxColumn.DataPropertyName = "BeginAge";
            this.beginAgeDataGridViewTextBoxColumn.HeaderText = "BeginAge";
            this.beginAgeDataGridViewTextBoxColumn.Name = "beginAgeDataGridViewTextBoxColumn";
            // 
            // endAgeDataGridViewTextBoxColumn
            // 
            this.endAgeDataGridViewTextBoxColumn.DataPropertyName = "EndAge";
            this.endAgeDataGridViewTextBoxColumn.HeaderText = "EndAge";
            this.endAgeDataGridViewTextBoxColumn.Name = "endAgeDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // openingDataGridViewTextBoxColumn
            // 
            this.openingDataGridViewTextBoxColumn.DataPropertyName = "Opening";
            this.openingDataGridViewTextBoxColumn.HeaderText = "Opening";
            this.openingDataGridViewTextBoxColumn.Name = "openingDataGridViewTextBoxColumn";
            // 
            // closingDataGridViewTextBoxColumn
            // 
            this.closingDataGridViewTextBoxColumn.DataPropertyName = "Closing";
            this.closingDataGridViewTextBoxColumn.HeaderText = "Closing";
            this.closingDataGridViewTextBoxColumn.Name = "closingDataGridViewTextBoxColumn";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataSource = typeof(Statfile.Model.School);
            // 
            // schoolBindingSource1
            // 
            this.schoolBindingSource1.DataSource = typeof(Statfile.Model.School);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.addline);
            this.panel1.Controls.Add(this.endageinfo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.EndAge);
            this.panel1.Controls.Add(this.closeinfo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Closing);
            this.panel1.Controls.Add(this.begininfo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BeginAge);
            this.panel1.Controls.Add(this.openinfo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Opening);
            this.panel1.Controls.Add(this.posinfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Controls.Add(this.capinfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Capacity);
            this.panel1.Controls.Add(this.edgeinfo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.edge);
            this.panel1.Location = new System.Drawing.Point(717, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 345);
            this.panel1.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(195, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 152;
            this.label9.Text = "School ( école )";
            // 
            // addline
            // 
            this.addline.Location = new System.Drawing.Point(311, 285);
            this.addline.Name = "addline";
            this.addline.Size = new System.Drawing.Size(193, 45);
            this.addline.TabIndex = 151;
            this.addline.Text = "Ajouter";
            this.addline.UseVisualStyleBackColor = true;
            this.addline.Click += new System.EventHandler(this.addline_Click);
            // 
            // endageinfo
            // 
            this.endageinfo.Image = ((System.Drawing.Image)(resources.GetObject("endageinfo.Image")));
            this.endageinfo.Location = new System.Drawing.Point(224, 285);
            this.endageinfo.Name = "endageinfo";
            this.endageinfo.Size = new System.Drawing.Size(26, 30);
            this.endageinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.endageinfo.TabIndex = 150;
            this.endageinfo.TabStop = false;
            this.endageinfo.Click += new System.EventHandler(this.endageinfo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 149;
            this.label8.Text = "EndAge\r\n(Âge maximum)\r\n";
            // 
            // EndAge
            // 
            this.EndAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndAge.Location = new System.Drawing.Point(133, 288);
            this.EndAge.Name = "EndAge";
            this.EndAge.Size = new System.Drawing.Size(85, 22);
            this.EndAge.TabIndex = 148;
            // 
            // closeinfo
            // 
            this.closeinfo.Image = ((System.Drawing.Image)(resources.GetObject("closeinfo.Image")));
            this.closeinfo.Location = new System.Drawing.Point(478, 209);
            this.closeinfo.Name = "closeinfo";
            this.closeinfo.Size = new System.Drawing.Size(26, 30);
            this.closeinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeinfo.TabIndex = 147;
            this.closeinfo.TabStop = false;
            this.closeinfo.Click += new System.EventHandler(this.closeinfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 48);
            this.label7.TabIndex = 146;
            this.label7.Text = "Closing\r\n(Fermeture)\r\n(sec)\r\n";
            // 
            // Closing
            // 
            this.Closing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closing.Location = new System.Drawing.Point(387, 212);
            this.Closing.Name = "Closing";
            this.Closing.Size = new System.Drawing.Size(85, 22);
            this.Closing.TabIndex = 145;
            // 
            // begininfo
            // 
            this.begininfo.Image = ((System.Drawing.Image)(resources.GetObject("begininfo.Image")));
            this.begininfo.Location = new System.Drawing.Point(224, 212);
            this.begininfo.Name = "begininfo";
            this.begininfo.Size = new System.Drawing.Size(26, 30);
            this.begininfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.begininfo.TabIndex = 144;
            this.begininfo.TabStop = false;
            this.begininfo.Click += new System.EventHandler(this.begininfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 143;
            this.label6.Text = "BeginAge\r\n(âge d\'entrée)\r\n";
            // 
            // BeginAge
            // 
            this.BeginAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginAge.Location = new System.Drawing.Point(133, 215);
            this.BeginAge.Name = "BeginAge";
            this.BeginAge.Size = new System.Drawing.Size(85, 22);
            this.BeginAge.TabIndex = 142;
            // 
            // openinfo
            // 
            this.openinfo.Image = ((System.Drawing.Image)(resources.GetObject("openinfo.Image")));
            this.openinfo.Location = new System.Drawing.Point(478, 136);
            this.openinfo.Name = "openinfo";
            this.openinfo.Size = new System.Drawing.Size(26, 30);
            this.openinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.openinfo.TabIndex = 141;
            this.openinfo.TabStop = false;
            this.openinfo.Click += new System.EventHandler(this.openinfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 48);
            this.label5.TabIndex = 140;
            this.label5.Text = "Opening\r\n(Ouverture)\r\n(sec)";
            // 
            // Opening
            // 
            this.Opening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opening.Location = new System.Drawing.Point(387, 139);
            this.Opening.Name = "Opening";
            this.Opening.Size = new System.Drawing.Size(85, 22);
            this.Opening.TabIndex = 139;
            // 
            // posinfo
            // 
            this.posinfo.Image = ((System.Drawing.Image)(resources.GetObject("posinfo.Image")));
            this.posinfo.Location = new System.Drawing.Point(224, 133);
            this.posinfo.Name = "posinfo";
            this.posinfo.Size = new System.Drawing.Size(26, 30);
            this.posinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.posinfo.TabIndex = 138;
            this.posinfo.TabStop = false;
            this.posinfo.Click += new System.EventHandler(this.posinfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 137;
            this.label2.Text = "Position\r\n(m)";
            // 
            // pos
            // 
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.Location = new System.Drawing.Point(133, 136);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(85, 22);
            this.pos.TabIndex = 136;
            // 
            // capinfo
            // 
            this.capinfo.Image = ((System.Drawing.Image)(resources.GetObject("capinfo.Image")));
            this.capinfo.Location = new System.Drawing.Point(478, 58);
            this.capinfo.Name = "capinfo";
            this.capinfo.Size = new System.Drawing.Size(26, 30);
            this.capinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.capinfo.TabIndex = 135;
            this.capinfo.TabStop = false;
            this.capinfo.Click += new System.EventHandler(this.capinfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 134;
            this.label1.Text = "Capacity\r\n(Capacité)\r\n";
            // 
            // Capacity
            // 
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacity.Location = new System.Drawing.Point(387, 61);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(85, 22);
            this.Capacity.TabIndex = 133;
            this.Capacity.TextChanged += new System.EventHandler(this.Capacity_TextChanged);
            // 
            // edgeinfo
            // 
            this.edgeinfo.Image = ((System.Drawing.Image)(resources.GetObject("edgeinfo.Image")));
            this.edgeinfo.Location = new System.Drawing.Point(224, 58);
            this.edgeinfo.Name = "edgeinfo";
            this.edgeinfo.Size = new System.Drawing.Size(26, 30);
            this.edgeinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.edgeinfo.TabIndex = 132;
            this.edgeinfo.TabStop = false;
            this.edgeinfo.Click += new System.EventHandler(this.edgeinfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 48);
            this.label4.TabIndex = 131;
            this.label4.Text = "Edge\r\n(id de la rue \r\ndans le réseau )\r\n";
            // 
            // edge
            // 
            this.edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edge.Location = new System.Drawing.Point(133, 61);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(85, 22);
            this.edge.TabIndex = 130;
            // 
            // precpop
            // 
            this.precpop.Location = new System.Drawing.Point(830, 467);
            this.precpop.Name = "precpop";
            this.precpop.Size = new System.Drawing.Size(127, 36);
            this.precpop.TabIndex = 155;
            this.precpop.Text = "Précèdent";
            this.precpop.UseVisualStyleBackColor = true;
            this.precpop.Click += new System.EventHandler(this.precpop_Click);
            // 
            // nextpop
            // 
            this.nextpop.Location = new System.Drawing.Point(1015, 467);
            this.nextpop.Name = "nextpop";
            this.nextpop.Size = new System.Drawing.Size(127, 36);
            this.nextpop.TabIndex = 154;
            this.nextpop.Text = "Suivant";
            this.nextpop.UseVisualStyleBackColor = true;
            this.nextpop.Click += new System.EventHandler(this.nextpop_Click);
            // 
            // schoolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.precpop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextpop);
            this.Controls.Add(this.schoolDatagridView);
            this.Controls.Add(this.panel2);
            this.Name = "schoolsForm";
            this.Size = new System.Drawing.Size(1233, 511);
            this.Load += new System.EventHandler(this.schoolsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endageinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begininfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView schoolDatagridView;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.BindingSource schoolBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn edgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addline;
        private System.Windows.Forms.PictureBox endageinfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EndAge;
        private System.Windows.Forms.PictureBox closeinfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Closing;
        private System.Windows.Forms.PictureBox begininfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BeginAge;
        private System.Windows.Forms.PictureBox openinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Opening;
        private System.Windows.Forms.PictureBox posinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pos;
        private System.Windows.Forms.PictureBox capinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.PictureBox edgeinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edge;
        private System.Windows.Forms.Button precpop;
        private System.Windows.Forms.Button nextpop;
        private System.Windows.Forms.Label label9;
    }
}
