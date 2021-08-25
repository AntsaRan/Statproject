
namespace Statfile.View
{
    partial class AjoutFrequences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutFrequences));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.freqgrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posinfo = new System.Windows.Forms.PictureBox();
            this.edgeinfo = new System.Windows.Forms.PictureBox();
            this.begin = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.labele = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.frequencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqgrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 83);
            this.panel1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Ajout fréquences";
            // 
            // freqgrid
            // 
            this.freqgrid.AutoGenerateColumns = false;
            this.freqgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freqgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.Supprimer});
            this.freqgrid.DataSource = this.frequencyBindingSource;
            this.freqgrid.Location = new System.Drawing.Point(13, 91);
            this.freqgrid.Name = "freqgrid";
            this.freqgrid.RowHeadersVisible = false;
            this.freqgrid.Size = new System.Drawing.Size(405, 386);
            this.freqgrid.TabIndex = 87;
            this.freqgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.freqgrid_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.rate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.posinfo);
            this.panel3.Controls.Add(this.edgeinfo);
            this.panel3.Controls.Add(this.begin);
            this.panel3.Controls.Add(this.end);
            this.panel3.Controls.Add(this.id);
            this.panel3.Controls.Add(this.labele);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(424, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 227);
            this.panel3.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(79, 169);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(134, 24);
            this.rate.TabIndex = 108;
            this.rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 32);
            this.label1.TabIndex = 107;
            this.label1.Text = "rate \r\n(taux)(s)";
            // 
            // posinfo
            // 
            this.posinfo.Image = ((System.Drawing.Image)(resources.GetObject("posinfo.Image")));
            this.posinfo.Location = new System.Drawing.Point(221, 68);
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
            this.edgeinfo.Location = new System.Drawing.Point(221, 124);
            this.edgeinfo.Name = "edgeinfo";
            this.edgeinfo.Size = new System.Drawing.Size(29, 19);
            this.edgeinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.edgeinfo.TabIndex = 105;
            this.edgeinfo.TabStop = false;
            this.edgeinfo.Click += new System.EventHandler(this.edgeinfo_Click);
            // 
            // begin
            // 
            this.begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin.Location = new System.Drawing.Point(79, 66);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(136, 24);
            this.begin.TabIndex = 103;
            this.begin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.begin_KeyPress);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(79, 119);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(134, 24);
            this.end.TabIndex = 102;
            this.end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.end_KeyPress);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(8, 58);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(65, 32);
            this.id.TabIndex = 100;
            this.id.Text = "Begin \r\n(début)(s)";
            // 
            // labele
            // 
            this.labele.AutoSize = true;
            this.labele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labele.Location = new System.Drawing.Point(8, 104);
            this.labele.Name = "labele";
            this.labele.Size = new System.Drawing.Size(50, 32);
            this.labele.TabIndex = 99;
            this.labele.Text = "end\r\n( fin )(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Fréquences bus";
            this.label5.UseWaitCursor = true;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(488, 343);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(136, 39);
            this.ajouter.TabIndex = 97;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(488, 421);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(136, 39);
            this.valider.TabIndex = 98;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // frequencyBindingSource
            // 
            this.frequencyBindingSource.DataSource = typeof(Statfile.Model.Frequency);
            // 
            // beginDataGridViewTextBoxColumn
            // 
            this.beginDataGridViewTextBoxColumn.DataPropertyName = "Begin";
            this.beginDataGridViewTextBoxColumn.HeaderText = "Begin";
            this.beginDataGridViewTextBoxColumn.Name = "beginDataGridViewTextBoxColumn";
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // AjoutFrequences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 489);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.freqgrid);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutFrequences";
            this.Text = "AjoutFrequences";
            this.Load += new System.EventHandler(this.AjoutFrequences_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqgrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView freqgrid;
        private System.Windows.Forms.BindingSource frequencyBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox posinfo;
        private System.Windows.Forms.PictureBox edgeinfo;
        private System.Windows.Forms.TextBox begin;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label labele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}