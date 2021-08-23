
namespace Statfile.View
{
    partial class workHoursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workHoursForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closingGrid = new System.Windows.Forms.DataGridView();
            this.SupprimerC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openingGrid = new System.Windows.Forms.DataGridView();
            this.SupprimerO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.precpop = new System.Windows.Forms.Button();
            this.nextpop = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.houropening = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ajoutopening = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proportionopening = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.proportionclosing = new System.Windows.Forms.TextBox();
            this.hourclosing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ajoutclosing = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.hourDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proportionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proportionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openingGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closingGrid);
            this.panel1.Controls.Add(this.openingGrid);
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 406);
            this.panel1.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 48);
            this.label2.TabIndex = 91;
            this.label2.Text = "Closing Hours\r\n(Heures de fermeture)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 48);
            this.label1.TabIndex = 90;
            this.label1.Text = "Opening Hours\r\n(Heures d\'ouverture)";
            // 
            // closingGrid
            // 
            this.closingGrid.AutoGenerateColumns = false;
            this.closingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hourDataGridViewTextBoxColumn1,
            this.proportionDataGridViewTextBoxColumn1,
            this.SupprimerC});
            this.closingGrid.DataSource = this.closingBindingSource;
            this.closingGrid.Location = new System.Drawing.Point(327, 76);
            this.closingGrid.Name = "closingGrid";
            this.closingGrid.RowHeadersVisible = false;
            this.closingGrid.Size = new System.Drawing.Size(307, 305);
            this.closingGrid.TabIndex = 89;
            this.closingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.closingGrid_CellContentClick);
            // 
            // SupprimerC
            // 
            this.SupprimerC.HeaderText = "Supprimer";
            this.SupprimerC.Name = "SupprimerC";
            this.SupprimerC.Text = "Supprimer";
            this.SupprimerC.UseColumnTextForButtonValue = true;
            // 
            // openingGrid
            // 
            this.openingGrid.AutoGenerateColumns = false;
            this.openingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hourDataGridViewTextBoxColumn,
            this.proportionDataGridViewTextBoxColumn,
            this.SupprimerO});
            this.openingGrid.DataSource = this.openingBindingSource;
            this.openingGrid.Location = new System.Drawing.Point(15, 76);
            this.openingGrid.Name = "openingGrid";
            this.openingGrid.RowHeadersVisible = false;
            this.openingGrid.Size = new System.Drawing.Size(306, 305);
            this.openingGrid.TabIndex = 89;
            this.openingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openingGrid_CellContentClick);
            // 
            // SupprimerO
            // 
            this.SupprimerO.HeaderText = "Supprimer";
            this.SupprimerO.Name = "SupprimerO";
            this.SupprimerO.Text = "Supprimer";
            this.SupprimerO.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 100);
            this.panel2.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Heures de travail ( WorkHours)";
            // 
            // precpop
            // 
            this.precpop.Location = new System.Drawing.Point(782, 447);
            this.precpop.Name = "precpop";
            this.precpop.Size = new System.Drawing.Size(127, 36);
            this.precpop.TabIndex = 97;
            this.precpop.Text = "Précèdent";
            this.precpop.UseVisualStyleBackColor = true;
            this.precpop.Click += new System.EventHandler(this.precpop_Click);
            // 
            // nextpop
            // 
            this.nextpop.Location = new System.Drawing.Point(961, 447);
            this.nextpop.Name = "nextpop";
            this.nextpop.Size = new System.Drawing.Size(127, 36);
            this.nextpop.TabIndex = 98;
            this.nextpop.Text = "Suivant";
            this.nextpop.UseVisualStyleBackColor = true;
            this.nextpop.Click += new System.EventHandler(this.nextpop_Click);
            // 
            // houropening
            // 
            this.houropening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.houropening, "Nombres de secondes écoulées à partir de minuit. Ex: 01h00 du matin = 3600 ;30 60" +
        "0 = 8.5 h soit 8h30 du matin ");
            this.houropening.Location = new System.Drawing.Point(78, 41);
            this.houropening.Name = "houropening";
            this.helpProvider1.SetShowHelp(this.houropening, true);
            this.houropening.Size = new System.Drawing.Size(85, 22);
            this.houropening.TabIndex = 135;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(653, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 54);
            this.panel4.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 18);
            this.label9.TabIndex = 105;
            this.label9.Text = "Heure de fermeture";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(653, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 54);
            this.panel3.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 104;
            this.label8.Text = "Heure d\'ouverture";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.ajoutopening);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.houropening);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.proportionopening);
            this.panel5.Location = new System.Drawing.Point(653, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 111);
            this.panel5.TabIndex = 137;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(405, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 141;
            this.pictureBox2.TabStop = false;
            // 
            // ajoutopening
            // 
            this.ajoutopening.Location = new System.Drawing.Point(448, 36);
            this.ajoutopening.Name = "ajoutopening";
            this.ajoutopening.Size = new System.Drawing.Size(114, 32);
            this.ajoutopening.TabIndex = 137;
            this.ajoutopening.Text = "Ajouter";
            this.ajoutopening.UseVisualStyleBackColor = true;
            this.ajoutopening.Click += new System.EventHandler(this.ajoutopening_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 48);
            this.label4.TabIndex = 138;
            this.label4.Text = "Hour\r\n(heure)\r\n(sec)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 32);
            this.label6.TabIndex = 139;
            this.label6.Text = "Proportion\r\n(proportion)";
            // 
            // proportionopening
            // 
            this.proportionopening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proportionopening.Location = new System.Drawing.Point(306, 41);
            this.proportionopening.Name = "proportionopening";
            this.proportionopening.Size = new System.Drawing.Size(93, 22);
            this.proportionopening.TabIndex = 136;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.Controls.Add(this.proportionclosing);
            this.panel6.Controls.Add(this.hourclosing);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.ajoutclosing);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(653, 324);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 103);
            this.panel6.TabIndex = 150;
            // 
            // proportionclosing
            // 
            this.proportionclosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proportionclosing.Location = new System.Drawing.Point(312, 30);
            this.proportionclosing.Name = "proportionclosing";
            this.proportionclosing.Size = new System.Drawing.Size(93, 22);
            this.proportionclosing.TabIndex = 134;
            // 
            // hourclosing
            // 
            this.hourclosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourclosing.Location = new System.Drawing.Point(74, 30);
            this.hourclosing.Name = "hourclosing";
            this.hourclosing.Size = new System.Drawing.Size(85, 22);
            this.hourclosing.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 32);
            this.label7.TabIndex = 137;
            this.label7.Text = "Propotion\r\n(proportion)";
            // 
            // ajoutclosing
            // 
            this.ajoutclosing.Location = new System.Drawing.Point(444, 27);
            this.ajoutclosing.Name = "ajoutclosing";
            this.ajoutclosing.Size = new System.Drawing.Size(114, 30);
            this.ajoutclosing.TabIndex = 135;
            this.ajoutclosing.Text = "Ajouter";
            this.ajoutclosing.UseVisualStyleBackColor = true;
            this.ajoutclosing.Click += new System.EventHandler(this.ajoutclosing_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 48);
            this.label5.TabIndex = 136;
            this.label5.Text = "Hour\r\n(heure)\r\n(sec)\r\n";
            // 
            // hourDataGridViewTextBoxColumn1
            // 
            this.hourDataGridViewTextBoxColumn1.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn1.HeaderText = "Hour";
            this.hourDataGridViewTextBoxColumn1.Name = "hourDataGridViewTextBoxColumn1";
            // 
            // proportionDataGridViewTextBoxColumn1
            // 
            this.proportionDataGridViewTextBoxColumn1.DataPropertyName = "Proportion";
            this.proportionDataGridViewTextBoxColumn1.HeaderText = "Proportion";
            this.proportionDataGridViewTextBoxColumn1.Name = "proportionDataGridViewTextBoxColumn1";
            // 
            // closingBindingSource
            // 
            this.closingBindingSource.DataSource = typeof(Statfile.Model.Closing);
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "Hour";
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            // 
            // proportionDataGridViewTextBoxColumn
            // 
            this.proportionDataGridViewTextBoxColumn.DataPropertyName = "Proportion";
            this.proportionDataGridViewTextBoxColumn.HeaderText = "Proportion";
            this.proportionDataGridViewTextBoxColumn.Name = "proportionDataGridViewTextBoxColumn";
            // 
            // openingBindingSource
            // 
            this.openingBindingSource.DataSource = typeof(Statfile.Model.Opening);
            // 
            // workHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nextpop);
            this.Controls.Add(this.precpop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "workHoursForm";
            this.Size = new System.Drawing.Size(1233, 511);
            this.Load += new System.EventHandler(this.workHours_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openingGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView closingGrid;
        private System.Windows.Forms.DataGridView openingGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button precpop;
        private System.Windows.Forms.Button nextpop;
        private System.Windows.Forms.BindingSource closingBindingSource;
        private System.Windows.Forms.BindingSource openingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proportionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SupprimerO;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proportionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn SupprimerC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ajoutopening;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox houropening;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox proportionopening;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox proportionclosing;
        private System.Windows.Forms.TextBox hourclosing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ajoutclosing;
        private System.Windows.Forms.Label label5;
    }
}
