namespace GUI_Arduino
{
    partial class Actuadores
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
            this.btn_IzqDelante = new System.Windows.Forms.Button();
            this.btn_IzqAtras = new System.Windows.Forms.Button();
            this.btn_DerDelante = new System.Windows.Forms.Button();
            this.btn_DerAtras = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_Delante = new System.Windows.Forms.Button();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Velocidades = new System.Windows.Forms.Panel();
            this.rdb_Rapido = new System.Windows.Forms.RadioButton();
            this.rdb_Standard = new System.Windows.Forms.RadioButton();
            this.rdb_Lento = new System.Windows.Forms.RadioButton();
            this.pnl_Velocidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IzqDelante
            // 
            this.btn_IzqDelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_IzqDelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IzqDelante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_IzqDelante.Location = new System.Drawing.Point(266, 129);
            this.btn_IzqDelante.Name = "btn_IzqDelante";
            this.btn_IzqDelante.Size = new System.Drawing.Size(101, 49);
            this.btn_IzqDelante.TabIndex = 0;
            this.btn_IzqDelante.Text = "IZQUIERDA DELANTE";
            this.btn_IzqDelante.UseVisualStyleBackColor = false;
            this.btn_IzqDelante.Click += new System.EventHandler(this.btn_IzqDelante_Click);
            // 
            // btn_IzqAtras
            // 
            this.btn_IzqAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_IzqAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IzqAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_IzqAtras.Location = new System.Drawing.Point(266, 203);
            this.btn_IzqAtras.Name = "btn_IzqAtras";
            this.btn_IzqAtras.Size = new System.Drawing.Size(101, 49);
            this.btn_IzqAtras.TabIndex = 1;
            this.btn_IzqAtras.Text = "IZQUIERDA DETRAS";
            this.btn_IzqAtras.UseVisualStyleBackColor = false;
            this.btn_IzqAtras.Click += new System.EventHandler(this.btn_IzqAtras_Click);
            // 
            // btn_DerDelante
            // 
            this.btn_DerDelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_DerDelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DerDelante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_DerDelante.Location = new System.Drawing.Point(513, 129);
            this.btn_DerDelante.Name = "btn_DerDelante";
            this.btn_DerDelante.Size = new System.Drawing.Size(101, 49);
            this.btn_DerDelante.TabIndex = 2;
            this.btn_DerDelante.Text = "DERECHA DELANTE";
            this.btn_DerDelante.UseVisualStyleBackColor = false;
            this.btn_DerDelante.Click += new System.EventHandler(this.btn_DerDelante_Click);
            // 
            // btn_DerAtras
            // 
            this.btn_DerAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_DerAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DerAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_DerAtras.Location = new System.Drawing.Point(513, 203);
            this.btn_DerAtras.Name = "btn_DerAtras";
            this.btn_DerAtras.Size = new System.Drawing.Size(101, 49);
            this.btn_DerAtras.TabIndex = 3;
            this.btn_DerAtras.Text = "DERECHA DETRAS";
            this.btn_DerAtras.UseVisualStyleBackColor = false;
            this.btn_DerAtras.Click += new System.EventHandler(this.btn_DerAtras_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Atras.Location = new System.Drawing.Point(389, 287);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(101, 49);
            this.btn_Atras.TabIndex = 4;
            this.btn_Atras.Text = "DETRAS";
            this.btn_Atras.UseVisualStyleBackColor = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_Delante
            // 
            this.btn_Delante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Delante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Delante.Location = new System.Drawing.Point(389, 42);
            this.btn_Delante.Name = "btn_Delante";
            this.btn_Delante.Size = new System.Drawing.Size(101, 49);
            this.btn_Delante.TabIndex = 5;
            this.btn_Delante.Text = "DELANTE";
            this.btn_Delante.UseVisualStyleBackColor = false;
            this.btn_Delante.Click += new System.EventHandler(this.btn_Delante_Click);
            // 
            // btn_Parar
            // 
            this.btn_Parar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Parar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(208)))));
            this.btn_Parar.Location = new System.Drawing.Point(389, 166);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(101, 49);
            this.btn_Parar.TabIndex = 6;
            this.btn_Parar.Text = "PARAR";
            this.btn_Parar.UseVisualStyleBackColor = false;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "SELECTOR VELOCIDADES";
            // 
            // pnl_Velocidades
            // 
            this.pnl_Velocidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.pnl_Velocidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Velocidades.Controls.Add(this.rdb_Rapido);
            this.pnl_Velocidades.Controls.Add(this.rdb_Standard);
            this.pnl_Velocidades.Controls.Add(this.rdb_Lento);
            this.pnl_Velocidades.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_Velocidades.Location = new System.Drawing.Point(15, 129);
            this.pnl_Velocidades.Margin = new System.Windows.Forms.Padding(20);
            this.pnl_Velocidades.Name = "pnl_Velocidades";
            this.pnl_Velocidades.Size = new System.Drawing.Size(186, 135);
            this.pnl_Velocidades.TabIndex = 14;
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
            // Actuadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(691, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_Velocidades);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.btn_Delante);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_DerAtras);
            this.Controls.Add(this.btn_DerDelante);
            this.Controls.Add(this.btn_IzqAtras);
            this.Controls.Add(this.btn_IzqDelante);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(78)))), ((int)(((byte)(132)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Actuadores";
            this.Text = "Acturadores";
            this.pnl_Velocidades.ResumeLayout(false);
            this.pnl_Velocidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IzqDelante;
        private System.Windows.Forms.Button btn_IzqAtras;
        private System.Windows.Forms.Button btn_DerDelante;
        private System.Windows.Forms.Button btn_DerAtras;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_Delante;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Velocidades;
        private System.Windows.Forms.RadioButton rdb_Rapido;
        private System.Windows.Forms.RadioButton rdb_Standard;
        private System.Windows.Forms.RadioButton rdb_Lento;
    }
}