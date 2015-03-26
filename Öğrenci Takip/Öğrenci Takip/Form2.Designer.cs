namespace Öğrenci_Takip
{
    partial class Form2
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fenbox = new System.Windows.Forms.TextBox();
            this.sosyalbox = new System.Windows.Forms.TextBox();
            this.matematikbox = new System.Windows.Forms.TextBox();
            this.turkcebox = new System.Windows.Forms.TextBox();
            this.adsoyadbox = new System.Windows.Forms.TextBox();
            this.nobox = new System.Windows.Forms.TextBox();
            this.guncellebutton = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(542, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Fen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Sosyal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Matematik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Türkçe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Okul No";
            // 
            // fenbox
            // 
            this.fenbox.Location = new System.Drawing.Point(545, 28);
            this.fenbox.Name = "fenbox";
            this.fenbox.Size = new System.Drawing.Size(100, 20);
            this.fenbox.TabIndex = 47;
            // 
            // sosyalbox
            // 
            this.sosyalbox.Location = new System.Drawing.Point(439, 28);
            this.sosyalbox.Name = "sosyalbox";
            this.sosyalbox.Size = new System.Drawing.Size(100, 20);
            this.sosyalbox.TabIndex = 46;
            // 
            // matematikbox
            // 
            this.matematikbox.Location = new System.Drawing.Point(333, 27);
            this.matematikbox.Name = "matematikbox";
            this.matematikbox.Size = new System.Drawing.Size(100, 20);
            this.matematikbox.TabIndex = 45;
            // 
            // turkcebox
            // 
            this.turkcebox.Location = new System.Drawing.Point(227, 27);
            this.turkcebox.Name = "turkcebox";
            this.turkcebox.Size = new System.Drawing.Size(100, 20);
            this.turkcebox.TabIndex = 44;
            // 
            // adsoyadbox
            // 
            this.adsoyadbox.Location = new System.Drawing.Point(121, 28);
            this.adsoyadbox.Name = "adsoyadbox";
            this.adsoyadbox.Size = new System.Drawing.Size(100, 20);
            this.adsoyadbox.TabIndex = 43;
            // 
            // nobox
            // 
            this.nobox.Location = new System.Drawing.Point(15, 28);
            this.nobox.Name = "nobox";
            this.nobox.Size = new System.Drawing.Size(100, 20);
            this.nobox.TabIndex = 42;
            // 
            // guncellebutton
            // 
            this.guncellebutton.Location = new System.Drawing.Point(348, 76);
            this.guncellebutton.Name = "guncellebutton";
            this.guncellebutton.Size = new System.Drawing.Size(75, 23);
            this.guncellebutton.TabIndex = 54;
            this.guncellebutton.Text = "Güncelle";
            this.guncellebutton.UseVisualStyleBackColor = true;
            this.guncellebutton.Click += new System.EventHandler(this.guncellebutton_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(0, -1);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(15, 13);
            this.idlabel.TabIndex = 55;
            this.idlabel.Text = "id";
            this.idlabel.Visible = false;
            // 
            // tarih
            // 
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(651, 28);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(94, 20);
            this.tarih.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tarih";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.guncellebutton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fenbox);
            this.Controls.Add(this.sosyalbox);
            this.Controls.Add(this.matematikbox);
            this.Controls.Add(this.turkcebox);
            this.Controls.Add(this.adsoyadbox);
            this.Controls.Add(this.nobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guncellebutton;
        public System.Windows.Forms.TextBox fenbox;
        public System.Windows.Forms.TextBox sosyalbox;
        public System.Windows.Forms.TextBox matematikbox;
        public System.Windows.Forms.TextBox turkcebox;
        public System.Windows.Forms.TextBox adsoyadbox;
        public System.Windows.Forms.TextBox nobox;
        public System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker tarih;

    }
}