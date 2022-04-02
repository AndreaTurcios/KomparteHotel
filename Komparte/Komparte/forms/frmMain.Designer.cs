
namespace Komparte
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.  
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                // aqui tenemos un comentario para poder probar como funiona github
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBotones2 = new System.Windows.Forms.Panel();
            this.btnTipoEntorno = new System.Windows.Forms.Button();
            this.btnTipoActividades = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMen1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.linkProfile = new System.Windows.Forms.LinkLabel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblUserr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panelBotones2.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.panelMenu.Controls.Add(this.panelBotones2);
            this.panelMenu.Controls.Add(this.btnInformacion);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.panelBotones);
            this.panelMenu.Controls.Add(this.btnMen1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(387, 758);
            this.panelMenu.TabIndex = 0;
            // 
            // panelBotones2
            // 
            this.panelBotones2.Controls.Add(this.btnTipoEntorno);
            this.panelBotones2.Controls.Add(this.btnTipoActividades);
            this.panelBotones2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones2.Location = new System.Drawing.Point(0, 531);
            this.panelBotones2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotones2.Name = "panelBotones2";
            this.panelBotones2.Size = new System.Drawing.Size(387, 146);
            this.panelBotones2.TabIndex = 5;
            // 
            // btnTipoEntorno
            // 
            this.btnTipoEntorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.btnTipoEntorno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoEntorno.FlatAppearance.BorderSize = 0;
            this.btnTipoEntorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoEntorno.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnTipoEntorno.ForeColor = System.Drawing.Color.White;
            this.btnTipoEntorno.Location = new System.Drawing.Point(0, 107);
            this.btnTipoEntorno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTipoEntorno.Name = "btnTipoEntorno";
            this.btnTipoEntorno.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTipoEntorno.Size = new System.Drawing.Size(387, 113);
            this.btnTipoEntorno.TabIndex = 8;
            this.btnTipoEntorno.Text = "Entorno";
            this.btnTipoEntorno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoEntorno.UseVisualStyleBackColor = false;
            this.btnTipoEntorno.Click += new System.EventHandler(this.btnTipoEntorno_Click);
            // 
            // btnTipoActividades
            // 
            this.btnTipoActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.btnTipoActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoActividades.FlatAppearance.BorderSize = 0;
            this.btnTipoActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoActividades.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnTipoActividades.ForeColor = System.Drawing.Color.White;
            this.btnTipoActividades.Location = new System.Drawing.Point(0, 0);
            this.btnTipoActividades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTipoActividades.Name = "btnTipoActividades";
            this.btnTipoActividades.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTipoActividades.Size = new System.Drawing.Size(387, 107);
            this.btnTipoActividades.TabIndex = 7;
            this.btnTipoActividades.Text = "Actividades";
            this.btnTipoActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoActividades.UseVisualStyleBackColor = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInformacion.Location = new System.Drawing.Point(0, 471);
            this.btnInformacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnInformacion.Size = new System.Drawing.Size(387, 60);
            this.btnInformacion.TabIndex = 4;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 698);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(387, 60);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.button4);
            this.panelBotones.Controls.Add(this.button3);
            this.panelBotones.Controls.Add(this.button2);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 252);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(387, 219);
            this.panelBotones.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 221);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(385, 107);
            this.button4.TabIndex = 2;
            this.button4.Text = "Empleados";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(385, 105);
            this.button3.TabIndex = 1;
            this.button3.Text = "Clientes";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(385, 116);
            this.button2.TabIndex = 0;
            this.button2.Text = "Reservaciones";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMen1
            // 
            this.btnMen1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMen1.FlatAppearance.BorderSize = 0;
            this.btnMen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMen1.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnMen1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMen1.Location = new System.Drawing.Point(0, 192);
            this.btnMen1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMen1.Name = "btnMen1";
            this.btnMen1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMen1.Size = new System.Drawing.Size(387, 60);
            this.btnMen1.TabIndex = 1;
            this.btnMen1.Text = "Administración";
            this.btnMen1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMen1.UseVisualStyleBackColor = true;
            this.btnMen1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.linkProfile);
            this.panelLogo.Controls.Add(this.lblPosition);
            this.panelLogo.Controls.Add(this.lblLastName);
            this.panelLogo.Controls.Add(this.lblName);
            this.panelLogo.Controls.Add(this.pictureBoxPhoto);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(387, 192);
            this.panelLogo.TabIndex = 0;
            // 
            // linkProfile
            // 
            this.linkProfile.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkProfile.AutoSize = true;
            this.linkProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.linkProfile.Location = new System.Drawing.Point(25, 135);
            this.linkProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkProfile.Name = "linkProfile";
            this.linkProfile.Size = new System.Drawing.Size(98, 25);
            this.linkProfile.TabIndex = 20;
            this.linkProfile.TabStop = true;
            this.linkProfile.Text = "My Profile";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPosition.Location = new System.Drawing.Point(185, 165);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(76, 24);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "Position";
            this.lblPosition.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLastName.Location = new System.Drawing.Point(132, 77);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(48, 20);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(131, 40);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1606, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnClose_Click);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.BackColor = System.Drawing.Color.White;
            this.btnChildFormClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChildFormClose.FlatAppearance.BorderSize = 0;
            this.btnChildFormClose.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChildFormClose.Location = new System.Drawing.Point(391, 46);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(58, 41);
            this.btnChildFormClose.TabIndex = 2;
            this.btnChildFormClose.Text = "X";
            this.btnChildFormClose.UseVisualStyleBackColor = false;
            this.btnChildFormClose.Visible = false;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.lblUserr);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Location = new System.Drawing.Point(391, 93);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1201, 691);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblUserr
            // 
            this.lblUserr.AutoSize = true;
            this.lblUserr.BackColor = System.Drawing.Color.Transparent;
            this.lblUserr.Font = new System.Drawing.Font("Sanseriffic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.lblUserr.Location = new System.Drawing.Point(602, 32);
            this.lblUserr.Name = "lblUserr";
            this.lblUserr.Size = new System.Drawing.Size(111, 55);
            this.lblUserr.TabIndex = 3;
            this.lblUserr.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sanseriffic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(333, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenid@,";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Sanseriffic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(490, 322);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(140, 55);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Sanseriffic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(104)))), ((int)(((byte)(78)))));
            this.lblHora.Location = new System.Drawing.Point(433, 247);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(163, 75);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "hora";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCaption.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCaption.Location = new System.Drawing.Point(467, 51);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(71, 26);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Home";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Komparte.Properties.Resources.logopngkomparte;
            this.pictureBox1.Location = new System.Drawing.Point(4, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::Komparte.Properties.Resources.DefaultUserProfile;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(27, 23);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(96, 98);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 14;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.pictureBoxPhoto_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Image = global::Komparte.Properties.Resources.close;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 50);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1606, 790);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.btnChildFormClose);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1069, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBotones2.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMen1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Panel panelBotones2;
        private System.Windows.Forms.Button btnTipoEntorno;
        private System.Windows.Forms.Button btnTipoActividades;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.LinkLabel linkProfile;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label lblUserr;
        private System.Windows.Forms.Label label2;
    }
}

