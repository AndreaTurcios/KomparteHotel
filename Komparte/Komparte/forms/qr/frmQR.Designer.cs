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
            this.btnguardarqr = new System.Windows.Forms.Button();
            this.imgqr = new System.Windows.Forms.PictureBox();
            this.btnqr = new System.Windows.Forms.Button();
            this.txtcajaqr = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardarbarra = new System.Windows.Forms.Button();
            this.imgbarra = new System.Windows.Forms.PictureBox();
            this.btnbarra = new System.Windows.Forms.Button();
            this.txtcajabarra = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgqr)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnguardarqr);
            this.groupBox2.Controls.Add(this.imgqr);
            this.groupBox2.Controls.Add(this.btnqr);
            this.groupBox2.Controls.Add(this.txtcajaqr);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(556, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(526, 482);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código QR";
            // 
            // btnguardarqr
            // 
            this.btnguardarqr.Location = new System.Drawing.Point(261, 137);
            this.btnguardarqr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardarqr.Name = "btnguardarqr";
            this.btnguardarqr.Size = new System.Drawing.Size(156, 63);
            this.btnguardarqr.TabIndex = 3;
            this.btnguardarqr.Text = "Guardar";
            this.btnguardarqr.UseVisualStyleBackColor = true;
            this.btnguardarqr.Click += new System.EventHandler(this.btnguardarqr_Click);
            // 
            // imgqr
            // 
            this.imgqr.Location = new System.Drawing.Point(27, 229);
            this.imgqr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgqr.Name = "imgqr";
            this.imgqr.Size = new System.Drawing.Size(467, 236);
            this.imgqr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgqr.TabIndex = 2;
            this.imgqr.TabStop = false;
            // 
            // btnqr
            // 
            this.btnqr.Location = new System.Drawing.Point(69, 137);
            this.btnqr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnqr.Name = "btnqr";
            this.btnqr.Size = new System.Drawing.Size(156, 63);
            this.btnqr.TabIndex = 1;
            this.btnqr.Text = "Generar";
            this.btnqr.UseVisualStyleBackColor = true;
            this.btnqr.Click += new System.EventHandler(this.btnqr_Click);
            // 
            // txtcajaqr
            // 
            this.txtcajaqr.Location = new System.Drawing.Point(69, 69);
            this.txtcajaqr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcajaqr.Name = "txtcajaqr";
            this.txtcajaqr.Size = new System.Drawing.Size(346, 35);
            this.txtcajaqr.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguardarbarra);
            this.groupBox1.Controls.Add(this.imgbarra);
            this.groupBox1.Controls.Add(this.btnbarra);
            this.groupBox1.Controls.Add(this.txtcajabarra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(526, 492);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código de Barras";
            // 
            // btnguardarbarra
            // 
            this.btnguardarbarra.Location = new System.Drawing.Point(261, 137);
            this.btnguardarbarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardarbarra.Name = "btnguardarbarra";
            this.btnguardarbarra.Size = new System.Drawing.Size(156, 63);
            this.btnguardarbarra.TabIndex = 3;
            this.btnguardarbarra.Text = "Guardar";
            this.btnguardarbarra.UseVisualStyleBackColor = true;
            this.btnguardarbarra.Click += new System.EventHandler(this.btnguardarbarra_Click);
            // 
            // imgbarra
            // 
            this.imgbarra.Location = new System.Drawing.Point(20, 239);
            this.imgbarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgbarra.Name = "imgbarra";
            this.imgbarra.Size = new System.Drawing.Size(480, 235);
            this.imgbarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbarra.TabIndex = 2;
            this.imgbarra.TabStop = false;
            // 
            // btnbarra
            // 
            this.btnbarra.Location = new System.Drawing.Point(69, 137);
            this.btnbarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbarra.Name = "btnbarra";
            this.btnbarra.Size = new System.Drawing.Size(156, 63);
            this.btnbarra.TabIndex = 1;
            this.btnbarra.Text = "Generar";
            this.btnbarra.UseVisualStyleBackColor = true;
            this.btnbarra.Click += new System.EventHandler(this.btnbarra_Click);
            // 
            // txtcajabarra
            // 
            this.txtcajabarra.Location = new System.Drawing.Point(69, 69);
            this.txtcajabarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcajabarra.Name = "txtcajabarra";
            this.txtcajabarra.Size = new System.Drawing.Size(346, 35);
            this.txtcajabarra.TabIndex = 0;
            // 
            // frmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgqr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnguardarqr;
        private System.Windows.Forms.PictureBox imgqr;
        private System.Windows.Forms.Button btnqr;
        private System.Windows.Forms.TextBox txtcajaqr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardarbarra;
        private System.Windows.Forms.PictureBox imgbarra;
        private System.Windows.Forms.Button btnbarra;
        private System.Windows.Forms.TextBox txtcajabarra;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

