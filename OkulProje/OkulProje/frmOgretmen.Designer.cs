
namespace OkulProje
{
    partial class frmOgretmen
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
            this.btnDers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSınav = new System.Windows.Forms.Button();
            this.btnOgrt = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDers
            // 
            this.btnDers.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDers.FlatAppearance.BorderSize = 3;
            this.btnDers.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDers.Location = new System.Drawing.Point(49, 21);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(334, 80);
            this.btnDers.TabIndex = 0;
            this.btnDers.Text = "Ders İşlemleri";
            this.btnDers.UseVisualStyleBackColor = false;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(49, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kulüp İşlemleri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSınav
            // 
            this.btnSınav.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSınav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSınav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSınav.FlatAppearance.BorderSize = 3;
            this.btnSınav.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSınav.Location = new System.Drawing.Point(49, 193);
            this.btnSınav.Name = "btnSınav";
            this.btnSınav.Size = new System.Drawing.Size(334, 80);
            this.btnSınav.TabIndex = 2;
            this.btnSınav.Text = "Sınav Notları";
            this.btnSınav.UseVisualStyleBackColor = false;
            // 
            // btnOgrt
            // 
            this.btnOgrt.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOgrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOgrt.FlatAppearance.BorderSize = 3;
            this.btnOgrt.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrt.Location = new System.Drawing.Point(49, 279);
            this.btnOgrt.Name = "btnOgrt";
            this.btnOgrt.Size = new System.Drawing.Size(334, 80);
            this.btnOgrt.TabIndex = 3;
            this.btnOgrt.Text = "Öğretmenler";
            this.btnOgrt.UseVisualStyleBackColor = false;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.PeachPuff;
            this.btnOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenci.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOgrenci.FlatAppearance.BorderSize = 3;
            this.btnOgrenci.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenci.Location = new System.Drawing.Point(49, 365);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(334, 80);
            this.btnOgrenci.TabIndex = 4;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // frmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(455, 476);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnOgrt);
            this.Controls.Add(this.btnSınav);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDers);
            this.Name = "frmOgretmen";
            this.Text = "frmOgretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSınav;
        private System.Windows.Forms.Button btnOgrt;
        private System.Windows.Forms.Button btnOgrenci;
    }
}