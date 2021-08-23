
namespace Statfile.View
{
    partial class populationform
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
            this.popDatagridView = new System.Windows.Forms.DataGridView();
            this.beginAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleNbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.populationBracketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.peopleNbr = new System.Windows.Forms.TextBox();
            this.endAge = new System.Windows.Forms.TextBox();
            this.beginAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addline = new System.Windows.Forms.Button();
            this.precpop = new System.Windows.Forms.Button();
            this.nextpop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titreGeneral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.popDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationBracketBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // popDatagridView
            // 
            this.popDatagridView.AutoGenerateColumns = false;
            this.popDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginAgeDataGridViewTextBoxColumn,
            this.endAgeDataGridViewTextBoxColumn,
            this.peopleNbrDataGridViewTextBoxColumn,
            this.Supprimer});
            this.popDatagridView.DataSource = this.populationBracketBindingSource;
            this.popDatagridView.Location = new System.Drawing.Point(37, 116);
            this.popDatagridView.Margin = new System.Windows.Forms.Padding(8);
            this.popDatagridView.Name = "popDatagridView";
            this.popDatagridView.RowHeadersVisible = false;
            this.popDatagridView.RowHeadersWidth = 80;
            this.popDatagridView.Size = new System.Drawing.Size(553, 387);
            this.popDatagridView.TabIndex = 83;
            this.popDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.popDatagridView_CellContentClick);
            // 
            // beginAgeDataGridViewTextBoxColumn
            // 
            this.beginAgeDataGridViewTextBoxColumn.DataPropertyName = "BeginAge";
            this.beginAgeDataGridViewTextBoxColumn.HeaderText = "BeginAge";
            this.beginAgeDataGridViewTextBoxColumn.Name = "beginAgeDataGridViewTextBoxColumn";
            this.beginAgeDataGridViewTextBoxColumn.Width = 150;
            // 
            // endAgeDataGridViewTextBoxColumn
            // 
            this.endAgeDataGridViewTextBoxColumn.DataPropertyName = "EndAge";
            this.endAgeDataGridViewTextBoxColumn.HeaderText = "EndAge";
            this.endAgeDataGridViewTextBoxColumn.Name = "endAgeDataGridViewTextBoxColumn";
            this.endAgeDataGridViewTextBoxColumn.Width = 150;
            // 
            // peopleNbrDataGridViewTextBoxColumn
            // 
            this.peopleNbrDataGridViewTextBoxColumn.DataPropertyName = "PeopleNbr";
            this.peopleNbrDataGridViewTextBoxColumn.HeaderText = "PeopleNbr";
            this.peopleNbrDataGridViewTextBoxColumn.Name = "peopleNbrDataGridViewTextBoxColumn";
            this.peopleNbrDataGridViewTextBoxColumn.Width = 150;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // populationBracketBindingSource
            // 
            this.populationBracketBindingSource.DataSource = typeof(Statfile.Model.PopulationBracket);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.peopleNbr);
            this.panel1.Controls.Add(this.endAge);
            this.panel1.Controls.Add(this.beginAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addline);
            this.panel1.Location = new System.Drawing.Point(631, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 236);
            this.panel1.TabIndex = 84;
            // 
            // peopleNbr
            // 
            this.peopleNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleNbr.Location = new System.Drawing.Point(110, 160);
            this.peopleNbr.Name = "peopleNbr";
            this.peopleNbr.Size = new System.Drawing.Size(136, 24);
            this.peopleNbr.TabIndex = 103;
            // 
            // endAge
            // 
            this.endAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endAge.Location = new System.Drawing.Point(392, 76);
            this.endAge.Name = "endAge";
            this.endAge.Size = new System.Drawing.Size(134, 24);
            this.endAge.TabIndex = 102;
            // 
            // beginAge
            // 
            this.beginAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginAge.Location = new System.Drawing.Point(110, 76);
            this.beginAge.Name = "beginAge";
            this.beginAge.Size = new System.Drawing.Size(136, 24);
            this.beginAge.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 48);
            this.label4.TabIndex = 100;
            this.label4.Text = "PeopleNbr\r\n(Nombre \r\nde personnes)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 99;
            this.label3.Text = "EndAge\r\n(Age fin)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 98;
            this.label2.Text = "BeginAge\r\n(Age début)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(171, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Bracket (Tranche d\'âge)";
            // 
            // addline
            // 
            this.addline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addline.Location = new System.Drawing.Point(304, 148);
            this.addline.Name = "addline";
            this.addline.Size = new System.Drawing.Size(222, 36);
            this.addline.TabIndex = 94;
            this.addline.Text = "Ajouter";
            this.addline.UseVisualStyleBackColor = false;
            this.addline.Click += new System.EventHandler(this.addline_Click);
            // 
            // precpop
            // 
            this.precpop.Location = new System.Drawing.Point(750, 448);
            this.precpop.Name = "precpop";
            this.precpop.Size = new System.Drawing.Size(127, 36);
            this.precpop.TabIndex = 96;
            this.precpop.Text = "Précèdent";
            this.precpop.UseVisualStyleBackColor = true;
            this.precpop.Click += new System.EventHandler(this.precpop_Click);
            // 
            // nextpop
            // 
            this.nextpop.Location = new System.Drawing.Point(935, 448);
            this.nextpop.Name = "nextpop";
            this.nextpop.Size = new System.Drawing.Size(127, 36);
            this.nextpop.TabIndex = 95;
            this.nextpop.Text = "Suivant";
            this.nextpop.UseVisualStyleBackColor = true;
            this.nextpop.Click += new System.EventHandler(this.nextpop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 60);
            this.label5.TabIndex = 97;
            this.label5.Text = "Assurez vous que les tranches d\'âge se suivent sans \r\ngap entre l\'âge de fin d\'un" +
    "e tranche et l\'âge de début de la tranche\r\nsuivante.\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.titreGeneral);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 100);
            this.panel2.TabIndex = 107;
            // 
            // titreGeneral
            // 
            this.titreGeneral.AutoSize = true;
            this.titreGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreGeneral.ForeColor = System.Drawing.Color.Snow;
            this.titreGeneral.Location = new System.Drawing.Point(37, 34);
            this.titreGeneral.Name = "titreGeneral";
            this.titreGeneral.Size = new System.Drawing.Size(152, 31);
            this.titreGeneral.TabIndex = 83;
            this.titreGeneral.Text = "Population";
            // 
            // populationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.popDatagridView);
            this.Controls.Add(this.precpop);
            this.Controls.Add(this.nextpop);
            this.Name = "populationform";
            this.Size = new System.Drawing.Size(1233, 511);
            this.Load += new System.EventHandler(this.populationform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationBracketBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView popDatagridView;
        private System.Windows.Forms.BindingSource populationBracketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleNbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox peopleNbr;
        private System.Windows.Forms.TextBox endAge;
        private System.Windows.Forms.TextBox beginAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button precpop;
        private System.Windows.Forms.Button nextpop;
        private System.Windows.Forms.Button addline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titreGeneral;
    }
}
