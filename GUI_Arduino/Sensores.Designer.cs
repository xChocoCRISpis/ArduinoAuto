namespace GUI_Arduino
{
    partial class Sensores
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
            this.components = new System.ComponentModel.Container();
            this.pgb_Izq = new System.Windows.Forms.ProgressBar();
            this.pgb_Cen = new System.Windows.Forms.ProgressBar();
            this.pgb_Der = new System.Windows.Forms.ProgressBar();
            this.chb_Left = new System.Windows.Forms.CheckBox();
            this.chb_Center = new System.Windows.Forms.CheckBox();
            this.chb_Right = new System.Windows.Forms.CheckBox();
            this.tm_Sensores = new System.Windows.Forms.Timer(this.components);
            this.lbl_Izq = new System.Windows.Forms.Label();
            this.lbl_Cen = new System.Windows.Forms.Label();
            this.lbl_Right = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb_Izq
            // 
            this.pgb_Izq.Location = new System.Drawing.Point(200, 90);
            this.pgb_Izq.Name = "pgb_Izq";
            this.pgb_Izq.Size = new System.Drawing.Size(176, 57);
            this.pgb_Izq.TabIndex = 0;
            // 
            // pgb_Cen
            // 
            this.pgb_Cen.Location = new System.Drawing.Point(200, 173);
            this.pgb_Cen.Name = "pgb_Cen";
            this.pgb_Cen.Size = new System.Drawing.Size(176, 57);
            this.pgb_Cen.TabIndex = 1;
            // 
            // pgb_Der
            // 
            this.pgb_Der.Location = new System.Drawing.Point(200, 253);
            this.pgb_Der.Name = "pgb_Der";
            this.pgb_Der.Size = new System.Drawing.Size(176, 57);
            this.pgb_Der.TabIndex = 2;
            // 
            // chb_Left
            // 
            this.chb_Left.AutoSize = true;
            this.chb_Left.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Left.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_Left.Location = new System.Drawing.Point(62, 104);
            this.chb_Left.Name = "chb_Left";
            this.chb_Left.Size = new System.Drawing.Size(85, 24);
            this.chb_Left.TabIndex = 3;
            this.chb_Left.Text = "Izquierda";
            this.chb_Left.UseVisualStyleBackColor = true;
            this.chb_Left.CheckedChanged += new System.EventHandler(this.chb_Left_CheckedChanged);
            // 
            // chb_Center
            // 
            this.chb_Center.AutoSize = true;
            this.chb_Center.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Center.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_Center.Location = new System.Drawing.Point(62, 187);
            this.chb_Center.Name = "chb_Center";
            this.chb_Center.Size = new System.Drawing.Size(72, 24);
            this.chb_Center.TabIndex = 4;
            this.chb_Center.Text = "Central";
            this.chb_Center.UseVisualStyleBackColor = true;
            this.chb_Center.CheckedChanged += new System.EventHandler(this.chb_Central_CheckedChanged);
            // 
            // chb_Right
            // 
            this.chb_Right.AutoSize = true;
            this.chb_Right.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Right.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_Right.Location = new System.Drawing.Point(62, 272);
            this.chb_Right.Name = "chb_Right";
            this.chb_Right.Size = new System.Drawing.Size(78, 24);
            this.chb_Right.TabIndex = 5;
            this.chb_Right.Text = "Derecha";
            this.chb_Right.UseVisualStyleBackColor = true;
            this.chb_Right.CheckedChanged += new System.EventHandler(this.chb_Right_CheckedChanged);
            // 
            // tm_Sensores
            // 
            this.tm_Sensores.Interval = 300;
            this.tm_Sensores.Tick += new System.EventHandler(this.tm_Sensores_Tick);
            // 
            // lbl_Izq
            // 
            this.lbl_Izq.AutoSize = true;
            this.lbl_Izq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Izq.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Izq.Location = new System.Drawing.Point(395, 110);
            this.lbl_Izq.Name = "lbl_Izq";
            this.lbl_Izq.Size = new System.Drawing.Size(45, 20);
            this.lbl_Izq.TabIndex = 6;
            this.lbl_Izq.Text = "------";
            // 
            // lbl_Cen
            // 
            this.lbl_Cen.AutoSize = true;
            this.lbl_Cen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cen.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Cen.Location = new System.Drawing.Point(395, 191);
            this.lbl_Cen.Name = "lbl_Cen";
            this.lbl_Cen.Size = new System.Drawing.Size(45, 20);
            this.lbl_Cen.TabIndex = 7;
            this.lbl_Cen.Text = "------";
            // 
            // lbl_Right
            // 
            this.lbl_Right.AutoSize = true;
            this.lbl_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Right.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Right.Location = new System.Drawing.Point(395, 272);
            this.lbl_Right.Name = "lbl_Right";
            this.lbl_Right.Size = new System.Drawing.Size(45, 20);
            this.lbl_Right.TabIndex = 8;
            this.lbl_Right.Text = "------";
            // 
            // Sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(506, 404);
            this.Controls.Add(this.lbl_Right);
            this.Controls.Add(this.lbl_Cen);
            this.Controls.Add(this.lbl_Izq);
            this.Controls.Add(this.chb_Right);
            this.Controls.Add(this.chb_Center);
            this.Controls.Add(this.chb_Left);
            this.Controls.Add(this.pgb_Der);
            this.Controls.Add(this.pgb_Cen);
            this.Controls.Add(this.pgb_Izq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sensores";
            this.Text = "Sensores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_Izq;
        private System.Windows.Forms.ProgressBar pgb_Cen;
        private System.Windows.Forms.ProgressBar pgb_Der;
        private System.Windows.Forms.CheckBox chb_Left;
        private System.Windows.Forms.CheckBox chb_Center;
        private System.Windows.Forms.CheckBox chb_Right;
        private System.Windows.Forms.Timer tm_Sensores;
        private System.Windows.Forms.Label lbl_Izq;
        private System.Windows.Forms.Label lbl_Cen;
        private System.Windows.Forms.Label lbl_Right;
    }
}