
namespace Statfile.View
{
    partial class modifyBuslineStations
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stationslist = new System.Windows.Forms.CheckedListBox();
            this.revstationslist = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 31);
            this.label3.TabIndex = 84;
            this.label3.Text = "Modification";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 73);
            this.panel1.TabIndex = 85;
            // 
            // stationslist
            // 
            this.stationslist.FormattingEnabled = true;
            this.stationslist.Location = new System.Drawing.Point(13, 126);
            this.stationslist.Name = "stationslist";
            this.stationslist.Size = new System.Drawing.Size(211, 229);
            this.stationslist.TabIndex = 86;
            // 
            // revstationslist
            // 
            this.revstationslist.FormattingEnabled = true;
            this.revstationslist.Location = new System.Drawing.Point(246, 126);
            this.revstationslist.Name = "revstationslist";
            this.revstationslist.Size = new System.Drawing.Size(211, 229);
            this.revstationslist.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 39);
            this.panel2.TabIndex = 88;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(247, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 39);
            this.panel3.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rev Stations";
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(173, 382);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(133, 50);
            this.modifier.TabIndex = 90;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // modifyBuslineStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 458);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.revstationslist);
            this.Controls.Add(this.stationslist);
            this.Controls.Add(this.panel1);
            this.Name = "modifyBuslineStations";
            this.Text = "Modification Bus";
            this.Load += new System.EventHandler(this.modifyBuslineStations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox stationslist;
        private System.Windows.Forms.CheckedListBox revstationslist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifier;
    }
}