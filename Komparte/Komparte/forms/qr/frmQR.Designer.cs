namespace WindowsFormsApp1
{
    partial class frmQR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcajaqr = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuardarBarra = new System.Windows.Forms.Button();
            this.btnGenerarBarra = new System.Windows.Forms.Button();
            this.txtcajabarra = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgqr = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgbarra = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBoxinv1 = new System.Windows.Forms.GroupBox();
            this.groupBoxinv2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgqr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBoxinv1.SuspendLayout();
            this.groupBoxinv2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxinv2);
            this.groupBox2.Controls.Add(this.txtcajaqr);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(514, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(526, 657);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código QR";
            // 
            // txtcajaqr
            // 
            this.txtcajaqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.txtcajaqr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcajaqr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtcajaqr.Location = new System.Drawing.Point(70, 65);
            this.txtcajaqr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcajaqr.Name = "txtcajaqr";
            this.txtcajaqr.Size = new System.Drawing.Size(346, 28);
            this.txtcajaqr.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxinv1);
            this.groupBox1.Controls.Add(this.txtcajabarra);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.GuardarBarra);
            this.groupBox1.Controls.Add(this.btnGenerarBarra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(493, 659);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código de Barras";
            // 
            // GuardarBarra
            // 
            this.GuardarBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.GuardarBarra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.GuardarBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarBarra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GuardarBarra.Location = new System.Drawing.Point(259, 137);
            this.GuardarBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuardarBarra.Name = "GuardarBarra";
            this.GuardarBarra.Size = new System.Drawing.Size(156, 46);
            this.GuardarBarra.TabIndex = 15;
            this.GuardarBarra.Text = "Guardar";
            this.GuardarBarra.UseVisualStyleBackColor = false;
            this.GuardarBarra.Click += new System.EventHandler(this.GuardarBarra_Click);
            // 
            // btnGenerarBarra
            // 
            this.btnGenerarBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.btnGenerarBarra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.btnGenerarBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarBarra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerarBarra.Location = new System.Drawing.Point(69, 137);
            this.btnGenerarBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarBarra.Name = "btnGenerarBarra";
            this.btnGenerarBarra.Size = new System.Drawing.Size(156, 46);
            this.btnGenerarBarra.TabIndex = 14;
            this.btnGenerarBarra.Text = "Generar";
            this.btnGenerarBarra.UseVisualStyleBackColor = false;
            this.btnGenerarBarra.Click += new System.EventHandler(this.btnGenerarBarra_Click);
            // 
            // txtcajabarra
            // 
            this.txtcajabarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.txtcajabarra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcajabarra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtcajabarra.Location = new System.Drawing.Point(69, 66);
            this.txtcajabarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcajabarra.Name = "txtcajabarra";
            this.txtcajabarra.Size = new System.Drawing.Size(346, 28);
            this.txtcajabarra.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1067, 45);
            this.panel7.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Komparte.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1019, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Komparte.Properties.Resources.cerrar;
            this.pictureBox3.Location = new System.Drawing.Point(1091, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // imgqr
            // 
            this.imgqr.Location = new System.Drawing.Point(7, 22);
            this.imgqr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgqr.Name = "imgqr";
            this.imgqr.Size = new System.Drawing.Size(498, 408);
            this.imgqr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgqr.TabIndex = 2;
            this.imgqr.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Komparte.Properties.Resources.flechas_hacia_atras;
            this.pictureBox2.Location = new System.Drawing.Point(9, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // imgbarra
            // 
            this.imgbarra.Location = new System.Drawing.Point(7, 17);
            this.imgbarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgbarra.Name = "imgbarra";
            this.imgbarra.Size = new System.Drawing.Size(465, 278);
            this.imgbarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbarra.TabIndex = 2;
            this.imgbarra.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(69, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(259, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Komparte.Properties.Resources.straight_white_line_png_1_1;
            this.pictureBox5.Location = new System.Drawing.Point(38, 90);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(407, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Komparte.Properties.Resources.straight_white_line_png_1_1;
            this.pictureBox4.Location = new System.Drawing.Point(41, 90);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(409, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // groupBoxinv1
            // 
            this.groupBoxinv1.Controls.Add(this.imgbarra);
            this.groupBoxinv1.Location = new System.Drawing.Point(7, 192);
            this.groupBoxinv1.Name = "groupBoxinv1";
            this.groupBoxinv1.Size = new System.Drawing.Size(479, 302);
            this.groupBoxinv1.TabIndex = 17;
            this.groupBoxinv1.TabStop = false;
            // 
            // groupBoxinv2
            // 
            this.groupBoxinv2.Controls.Add(this.imgqr);
            this.groupBoxinv2.Location = new System.Drawing.Point(7, 190);
            this.groupBoxinv2.Name = "groupBoxinv2";
            this.groupBoxinv2.Size = new System.Drawing.Size(512, 438);
            this.groupBoxinv2.TabIndex = 18;
            this.groupBoxinv2.TabStop = false;
            // 
            // frmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1060, 721);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgqr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBoxinv1.ResumeLayout(false);
            this.groupBoxinv2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgqr;
        private System.Windows.Forms.TextBox txtcajaqr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgbarra;
        private System.Windows.Forms.TextBox txtcajabarra;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button GuardarBarra;
        private System.Windows.Forms.Button btnGenerarBarra;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBoxinv2;
        private System.Windows.Forms.GroupBox groupBoxinv1;
    }
}

