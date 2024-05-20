namespace barınakvt
{
    partial class YeniForm
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
            this.pbFotograf = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbEngelDurumu = new System.Windows.Forms.CheckBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotograf
            // 
            this.pbFotograf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbFotograf.Location = new System.Drawing.Point(252, 26);
            this.pbFotograf.Name = "pbFotograf";
            this.pbFotograf.Size = new System.Drawing.Size(130, 203);
            this.pbFotograf.TabIndex = 67;
            this.pbFotograf.TabStop = false;
            this.pbFotograf.Click += new System.EventHandler(this.pbFotograf_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(54, 178);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 51);
            this.btnEkle.TabIndex = 65;
            this.btnEkle.Text = "➕";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbEngelDurumu
            // 
            this.cbEngelDurumu.AutoSize = true;
            this.cbEngelDurumu.Location = new System.Drawing.Point(54, 127);
            this.cbEngelDurumu.Name = "cbEngelDurumu";
            this.cbEngelDurumu.Size = new System.Drawing.Size(93, 17);
            this.cbEngelDurumu.TabIndex = 64;
            this.cbEngelDurumu.Text = "Engel Durumu";
            this.cbEngelDurumu.UseVisualStyleBackColor = true;
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Location = new System.Drawing.Point(54, 88);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(135, 21);
            this.cmbCins.TabIndex = 61;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(54, 47);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(135, 20);
            this.txtYas.TabIndex = 60;
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(54, 12);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(135, 20);
            this.txtİsim.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(249, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Poster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cinsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Yaşı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "İsim";
            // 
            // YeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 284);
            this.Controls.Add(this.pbFotograf);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbEngelDurumu);
            this.Controls.Add(this.cmbCins);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniForm";
            this.Text = "YeniForm";
            this.Load += new System.EventHandler(this.YeniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotograf;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox cbEngelDurumu;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}