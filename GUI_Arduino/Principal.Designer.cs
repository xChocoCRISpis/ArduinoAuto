namespace GUI_Arduino
{
    partial class form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Principal));
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.cmb_Conexion = new System.Windows.Forms.ComboBox();
            this.pb_Conexion = new System.Windows.Forms.PictureBox();
            this.pnl_Conectar = new System.Windows.Forms.Panel();
            this.btn_Desconectar = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Automatic = new System.Windows.Forms.Button();
            this.btn_Sensores = new System.Windows.Forms.Button();
            this.btn_Motores = new System.Windows.Forms.Button();
            this.btn_Control = new System.Windows.Forms.Button();
            this.pnl_Forms = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Conexion)).BeginInit();
            this.pnl_Conectar.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btn_Conectar.Location = new System.Drawing.Point(272, 3);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(100, 43);
            this.btn_Conectar.TabIndex = 0;
            this.btn_Conectar.Text = "CONECTAR";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // cmb_Conexion
            // 
            this.cmb_Conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmb_Conexion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Conexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Conexion.ForeColor = System.Drawing.SystemColors.Info;
            this.cmb_Conexion.FormattingEnabled = true;
            this.cmb_Conexion.Location = new System.Drawing.Point(106, 20);
            this.cmb_Conexion.Name = "cmb_Conexion";
            this.cmb_Conexion.Size = new System.Drawing.Size(121, 21);
            this.cmb_Conexion.TabIndex = 1;
            this.cmb_Conexion.SelectedIndexChanged += new System.EventHandler(this.cmb_Conexion_SelectedIndexChanged);
            this.cmb_Conexion.Click += new System.EventHandler(this.cmb_Conexion_Click);
            // 
            // pb_Conexion
            // 
            this.pb_Conexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Conexion.BackgroundImage")));
            this.pb_Conexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Conexion.Location = new System.Drawing.Point(31, 5);
            this.pb_Conexion.Name = "pb_Conexion";
            this.pb_Conexion.Size = new System.Drawing.Size(42, 44);
            this.pb_Conexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Conexion.TabIndex = 2;
            this.pb_Conexion.TabStop = false;
            // 
            // pnl_Conectar
            // 
            this.pnl_Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.pnl_Conectar.Controls.Add(this.btn_Desconectar);
            this.pnl_Conectar.Controls.Add(this.btn_Conectar);
            this.pnl_Conectar.Controls.Add(this.pb_Conexion);
            this.pnl_Conectar.Controls.Add(this.cmb_Conexion);
            this.pnl_Conectar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Conectar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Conectar.Name = "pnl_Conectar";
            this.pnl_Conectar.Size = new System.Drawing.Size(800, 49);
            this.pnl_Conectar.TabIndex = 3;
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btn_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Desconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btn_Desconectar.Location = new System.Drawing.Point(273, 3);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(99, 43);
            this.btn_Desconectar.TabIndex = 3;
            this.btn_Desconectar.Text = "DESCONECTAR";
            this.btn_Desconectar.UseVisualStyleBackColor = false;
            this.btn_Desconectar.Visible = false;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.pnl_Menu.Controls.Add(this.btn_Automatic);
            this.pnl_Menu.Controls.Add(this.btn_Sensores);
            this.pnl_Menu.Controls.Add(this.btn_Motores);
            this.pnl_Menu.Controls.Add(this.btn_Control);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 49);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(156, 401);
            this.pnl_Menu.TabIndex = 4;
            // 
            // btn_Automatic
            // 
            this.btn_Automatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btn_Automatic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Automatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Automatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btn_Automatic.Location = new System.Drawing.Point(0, 186);
            this.btn_Automatic.Name = "btn_Automatic";
            this.btn_Automatic.Size = new System.Drawing.Size(156, 62);
            this.btn_Automatic.TabIndex = 3;
            this.btn_Automatic.Text = "AUTOMÁTICO";
            this.btn_Automatic.UseVisualStyleBackColor = false;
            this.btn_Automatic.Click += new System.EventHandler(this.btn_Automatic_Click);
            // 
            // btn_Sensores
            // 
            this.btn_Sensores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btn_Sensores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sensores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sensores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btn_Sensores.Location = new System.Drawing.Point(0, 124);
            this.btn_Sensores.Name = "btn_Sensores";
            this.btn_Sensores.Size = new System.Drawing.Size(156, 62);
            this.btn_Sensores.TabIndex = 2;
            this.btn_Sensores.Text = "SENSORES";
            this.btn_Sensores.UseVisualStyleBackColor = false;
            this.btn_Sensores.Click += new System.EventHandler(this.btn_Sensores_Click);
            // 
            // btn_Motores
            // 
            this.btn_Motores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btn_Motores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Motores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Motores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btn_Motores.Location = new System.Drawing.Point(0, 62);
            this.btn_Motores.Name = "btn_Motores";
            this.btn_Motores.Size = new System.Drawing.Size(156, 62);
            this.btn_Motores.TabIndex = 1;
            this.btn_Motores.Text = "MOTORES";
            this.btn_Motores.UseVisualStyleBackColor = false;
            this.btn_Motores.Click += new System.EventHandler(this.btn_Motores_Click);
            // 
            // btn_Control
            // 
            this.btn_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btn_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.btn_Control.Location = new System.Drawing.Point(0, 0);
            this.btn_Control.Name = "btn_Control";
            this.btn_Control.Size = new System.Drawing.Size(156, 62);
            this.btn_Control.TabIndex = 0;
            this.btn_Control.Text = "CONTROL REMOTO";
            this.btn_Control.UseVisualStyleBackColor = false;
            this.btn_Control.Click += new System.EventHandler(this.btn_Control_Click);
            // 
            // pnl_Forms
            // 
            this.pnl_Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnl_Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Forms.Location = new System.Drawing.Point(156, 49);
            this.pnl_Forms.Name = "pnl_Forms";
            this.pnl_Forms.Size = new System.Drawing.Size(644, 401);
            this.pnl_Forms.TabIndex = 5;
            // 
            // form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Forms);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Conectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_Principal";
            this.Text = "Auto seguidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Principal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Conexion)).EndInit();
            this.pnl_Conectar.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.ComboBox cmb_Conexion;
        private System.Windows.Forms.PictureBox pb_Conexion;
        private System.Windows.Forms.Panel pnl_Conectar;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_Control;
        private System.Windows.Forms.Button btn_Automatic;
        private System.Windows.Forms.Button btn_Sensores;
        private System.Windows.Forms.Button btn_Motores;
        private System.Windows.Forms.Panel pnl_Forms;
        private System.Windows.Forms.Button btn_Desconectar;
    }
}

