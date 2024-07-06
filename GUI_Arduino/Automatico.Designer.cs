namespace GUI_Arduino
{
    partial class Automatico
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
            this.btn_Encender = new System.Windows.Forms.Button();
            this.rdb_Dis1 = new System.Windows.Forms.RadioButton();
            this.pnl_Distancias = new System.Windows.Forms.Panel();
            this.rdb_Dis3 = new System.Windows.Forms.RadioButton();
            this.rdb_Dis2 = new System.Windows.Forms.RadioButton();
            this.pnl_Velocidades = new System.Windows.Forms.Panel();
            this.rdb_Rapido = new System.Windows.Forms.RadioButton();
            this.rdb_Standard = new System.Windows.Forms.RadioButton();
            this.rdb_Lento = new System.Windows.Forms.RadioButton();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Salida = new System.Windows.Forms.PictureBox();
            this.lbl_Salida = new System.Windows.Forms.Label();
            this.pnl_Distancias.SuspendLayout();
            this.pnl_Velocidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Salida)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Encender
            // 
            this.btn_Encender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Encender.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Encender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Encender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Encender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Encender.Location = new System.Drawing.Point(254, 89);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(101, 49);
            this.btn_Encender.TabIndex = 6;
            this.btn_Encender.Text = "ENCENDER";
            this.btn_Encender.UseVisualStyleBackColor = false;
            this.btn_Encender.Click += new System.EventHandler(this.btn_Encender_Click);
            // 
            // rdb_Dis1
            // 
            this.rdb_Dis1.AutoSize = true;
            this.rdb_Dis1.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Dis1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Dis1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.rdb_Dis1.Location = new System.Drawing.Point(25, 14);
            this.rdb_Dis1.Name = "rdb_Dis1";
            this.rdb_Dis1.Size = new System.Drawing.Size(133, 24);
            this.rdb_Dis1.TabIndex = 7;
            this.rdb_Dis1.TabStop = true;
            this.rdb_Dis1.Text = "3 CENTÍMETROS";
            this.rdb_Dis1.UseVisualStyleBackColor = false;
            this.rdb_Dis1.CheckedChanged += new System.EventHandler(this.rdb_Dis1_CheckedChanged);
            // 
            // pnl_Distancias
            // 
            this.pnl_Distancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.pnl_Distancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Distancias.Controls.Add(this.rdb_Dis3);
            this.pnl_Distancias.Controls.Add(this.rdb_Dis2);
            this.pnl_Distancias.Controls.Add(this.rdb_Dis1);
            this.pnl_Distancias.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_Distancias.Location = new System.Drawing.Point(45, 47);
            this.pnl_Distancias.Margin = new System.Windows.Forms.Padding(20);
            this.pnl_Distancias.Name = "pnl_Distancias";
            this.pnl_Distancias.Size = new System.Drawing.Size(186, 135);
            this.pnl_Distancias.TabIndex = 8;
            // 
            // rdb_Dis3
            // 
            this.rdb_Dis3.AutoSize = true;
            this.rdb_Dis3.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Dis3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Dis3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.rdb_Dis3.Location = new System.Drawing.Point(25, 92);
            this.rdb_Dis3.Name = "rdb_Dis3";
            this.rdb_Dis3.Size = new System.Drawing.Size(140, 24);
            this.rdb_Dis3.TabIndex = 9;
            this.rdb_Dis3.TabStop = true;
            this.rdb_Dis3.Text = "15 CENTÍMETROS";
            this.rdb_Dis3.UseVisualStyleBackColor = false;
            this.rdb_Dis3.CheckedChanged += new System.EventHandler(this.rdb_Dis3_CheckedChanged);
            // 
            // rdb_Dis2
            // 
            this.rdb_Dis2.AutoSize = true;
            this.rdb_Dis2.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Dis2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Dis2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.rdb_Dis2.Location = new System.Drawing.Point(25, 53);
            this.rdb_Dis2.Name = "rdb_Dis2";
            this.rdb_Dis2.Size = new System.Drawing.Size(140, 24);
            this.rdb_Dis2.TabIndex = 8;
            this.rdb_Dis2.TabStop = true;
            this.rdb_Dis2.Text = "10 CENTÍMETROS";
            this.rdb_Dis2.UseVisualStyleBackColor = false;
            this.rdb_Dis2.CheckedChanged += new System.EventHandler(this.rdb_Dis2_CheckedChanged);
            // 
            // pnl_Velocidades
            // 
            this.pnl_Velocidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.pnl_Velocidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Velocidades.Controls.Add(this.rdb_Rapido);
            this.pnl_Velocidades.Controls.Add(this.rdb_Standard);
            this.pnl_Velocidades.Controls.Add(this.rdb_Lento);
            this.pnl_Velocidades.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_Velocidades.Location = new System.Drawing.Point(383, 47);
            this.pnl_Velocidades.Margin = new System.Windows.Forms.Padding(20);
            this.pnl_Velocidades.Name = "pnl_Velocidades";
            this.pnl_Velocidades.Size = new System.Drawing.Size(186, 135);
            this.pnl_Velocidades.TabIndex = 10;
            // 
            // rdb_Rapido
            // 
            this.rdb_Rapido.AutoSize = true;
            this.rdb_Rapido.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Rapido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Rapido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.rdb_Rapido.Location = new System.Drawing.Point(54, 92);
            this.rdb_Rapido.Name = "rdb_Rapido";
            this.rdb_Rapido.Size = new System.Drawing.Size(77, 24);
            this.rdb_Rapido.TabIndex = 9;
            this.rdb_Rapido.TabStop = true;
            this.rdb_Rapido.Text = "RÁPIDO";
            this.rdb_Rapido.UseVisualStyleBackColor = false;
            this.rdb_Rapido.CheckedChanged += new System.EventHandler(this.rdb_Rapido_CheckedChanged);
            // 
            // rdb_Standard
            // 
            this.rdb_Standard.AutoSize = true;
            this.rdb_Standard.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Standard.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Standard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.rdb_Standard.Location = new System.Drawing.Point(44, 53);
            this.rdb_Standard.Name = "rdb_Standard";
            this.rdb_Standard.Size = new System.Drawing.Size(98, 24);
            this.rdb_Standard.TabIndex = 8;
            this.rdb_Standard.TabStop = true;
            this.rdb_Standard.Text = "STANDARD";
            this.rdb_Standard.UseVisualStyleBackColor = false;
            this.rdb_Standard.CheckedChanged += new System.EventHandler(this.rdb_Standard_CheckedChanged);
            // 
            // rdb_Lento
            // 
            this.rdb_Lento.AutoSize = true;
            this.rdb_Lento.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Lento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Lento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.rdb_Lento.Location = new System.Drawing.Point(60, 14);
            this.rdb_Lento.Name = "rdb_Lento";
            this.rdb_Lento.Size = new System.Drawing.Size(71, 24);
            this.rdb_Lento.TabIndex = 7;
            this.rdb_Lento.TabStop = true;
            this.rdb_Lento.Text = "LENTO";
            this.rdb_Lento.UseVisualStyleBackColor = false;
            this.rdb_Lento.CheckedChanged += new System.EventHandler(this.rdb_Lento_CheckedChanged);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Apagar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Apagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Apagar.Location = new System.Drawing.Point(254, 89);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(101, 49);
            this.btn_Apagar.TabIndex = 11;
            this.btn_Apagar.Text = "APAGAR";
            this.btn_Apagar.UseVisualStyleBackColor = false;
            this.btn_Apagar.Visible = false;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "SELECTOR DISTANCIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(380, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SELECTOR VELOCIDADES";
            // 
            // pb_Salida
            // 
            this.pb_Salida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_Salida.Location = new System.Drawing.Point(167, 253);
            this.pb_Salida.Name = "pb_Salida";
            this.pb_Salida.Size = new System.Drawing.Size(264, 144);
            this.pb_Salida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Salida.TabIndex = 14;
            this.pb_Salida.TabStop = false;
            // 
            // lbl_Salida
            // 
            this.lbl_Salida.AutoSize = true;
            this.lbl_Salida.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salida.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Salida.Location = new System.Drawing.Point(285, 219);
            this.lbl_Salida.Name = "lbl_Salida";
            this.lbl_Salida.Size = new System.Drawing.Size(33, 20);
            this.lbl_Salida.TabIndex = 15;
            this.lbl_Salida.Text = "------";
            this.lbl_Salida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Automatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.lbl_Salida);
            this.Controls.Add(this.pb_Salida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.pnl_Velocidades);
            this.Controls.Add(this.pnl_Distancias);
            this.Controls.Add(this.btn_Encender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Automatico";
            this.Text = "Automatico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Automatico_FormClosing);
            this.pnl_Distancias.ResumeLayout(false);
            this.pnl_Distancias.PerformLayout();
            this.pnl_Velocidades.ResumeLayout(false);
            this.pnl_Velocidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Salida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encender;
        private System.Windows.Forms.RadioButton rdb_Dis1;
        private System.Windows.Forms.Panel pnl_Distancias;
        private System.Windows.Forms.RadioButton rdb_Dis3;
        private System.Windows.Forms.RadioButton rdb_Dis2;
        private System.Windows.Forms.Panel pnl_Velocidades;
        private System.Windows.Forms.RadioButton rdb_Rapido;
        private System.Windows.Forms.RadioButton rdb_Standard;
        private System.Windows.Forms.RadioButton rdb_Lento;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Salida;
        private System.Windows.Forms.Label lbl_Salida;
    }
}