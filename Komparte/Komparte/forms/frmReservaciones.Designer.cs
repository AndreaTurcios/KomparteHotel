
namespace Komparte.forms.obj
{
    partial class frmReservaciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxDia = new System.Windows.Forms.CheckBox();
            this.checkBoxNoche = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridReservacion = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textHoras = new System.Windows.Forms.TextBox();
            this.textAcompa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservacion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 447);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textAcompa);
            this.groupBox1.Controls.Add(this.textHoras);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(817, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de reservaciones";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(66, 41);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(225, 21);
            this.comboBoxCliente.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxServicio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxEstado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(635, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(161, 78);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado reservación";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(55, 18);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(89, 21);
            this.comboBoxEstado.TabIndex = 12;
            this.comboBoxEstado.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonClear);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.buttonRemove);
            this.groupBox5.Controls.Add(this.buttonUpdate);
            this.groupBox5.Location = new System.Drawing.Point(12, 109);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(783, 49);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controles";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(661, 16);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(67, 24);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Agregar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(453, 15);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(67, 24);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Eliminar";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(212, 15);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(67, 24);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxDia);
            this.groupBox4.Controls.Add(this.checkBoxNoche);
            this.groupBox4.Location = new System.Drawing.Point(406, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(142, 57);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reserva";
            // 
            // checkBoxDia
            // 
            this.checkBoxDia.AutoSize = true;
            this.checkBoxDia.Location = new System.Drawing.Point(30, 19);
            this.checkBoxDia.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxDia.Name = "checkBoxDia";
            this.checkBoxDia.Size = new System.Drawing.Size(42, 17);
            this.checkBoxDia.TabIndex = 7;
            this.checkBoxDia.Text = "Dia";
            this.checkBoxDia.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoche
            // 
            this.checkBoxNoche.AutoSize = true;
            this.checkBoxNoche.Location = new System.Drawing.Point(30, 37);
            this.checkBoxNoche.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoxNoche.Name = "checkBoxNoche";
            this.checkBoxNoche.Size = new System.Drawing.Size(58, 17);
            this.checkBoxNoche.TabIndex = 24;
            this.checkBoxNoche.Text = "Noche";
            this.checkBoxNoche.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Horas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Acompañantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.dataGridReservacion);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(783, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 188);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 28);
            this.button7.TabIndex = 25;
            this.button7.Text = "> Detalle reservación";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(701, 188);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridReservacion
            // 
            this.dataGridReservacion.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridReservacion.ColumnHeadersHeight = 34;
            this.dataGridReservacion.Location = new System.Drawing.Point(11, 15);
            this.dataGridReservacion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridReservacion.Name = "dataGridReservacion";
            this.dataGridReservacion.RowHeadersWidth = 62;
            this.dataGridReservacion.Size = new System.Drawing.Size(762, 170);
            this.dataGridReservacion.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 43);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(265, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de reservaciones";
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Location = new System.Drawing.Point(55, 44);
            this.comboBoxServicio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(89, 21);
            this.comboBoxServicio.TabIndex = 28;
            this.comboBoxServicio.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Servicio:";
            // 
            // textHoras
            // 
            this.textHoras.Location = new System.Drawing.Point(65, 73);
            this.textHoras.Name = "textHoras";
            this.textHoras.Size = new System.Drawing.Size(100, 20);
            this.textHoras.TabIndex = 28;
            // 
            // textAcompa
            // 
            this.textAcompa.Location = new System.Drawing.Point(276, 70);
            this.textAcompa.Name = "textAcompa";
            this.textAcompa.Size = new System.Drawing.Size(100, 20);
            this.textAcompa.TabIndex = 29;
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 448);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmReservaciones";
            this.Text = "Lista de reservaciones";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservacion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridReservacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxNoche;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAcompa;
        private System.Windows.Forms.TextBox textHoras;
    }
}