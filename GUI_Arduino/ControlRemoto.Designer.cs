namespace GUI_Arduino
{
    partial class ControlRemoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRemoto));
            this.pb_Up = new System.Windows.Forms.PictureBox();
            this.pb_Left = new System.Windows.Forms.PictureBox();
            this.pb_Right = new System.Windows.Forms.PictureBox();
            this.pb_Down = new System.Windows.Forms.PictureBox();
            this.pb_On = new System.Windows.Forms.PictureBox();
            this.pnl_Arriba = new System.Windows.Forms.Panel();
            this.pb_Min = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_On)).BeginInit();
            this.pnl_Arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Up
            // 
            this.pb_Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Up.BackgroundImage")));
            this.pb_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Up.Location = new System.Drawing.Point(231, 76);
            this.pb_Up.Name = "pb_Up";
            this.pb_Up.Size = new System.Drawing.Size(100, 100);
            this.pb_Up.TabIndex = 0;
            this.pb_Up.TabStop = false;
            // 
            // pb_Left
            // 
            this.pb_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Left.BackgroundImage")));
            this.pb_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Left.Location = new System.Drawing.Point(134, 173);
            this.pb_Left.Name = "pb_Left";
            this.pb_Left.Size = new System.Drawing.Size(100, 100);
            this.pb_Left.TabIndex = 1;
            this.pb_Left.TabStop = false;
            // 
            // pb_Right
            // 
            this.pb_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Right.BackgroundImage")));
            this.pb_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Right.Location = new System.Drawing.Point(328, 173);
            this.pb_Right.Name = "pb_Right";
            this.pb_Right.Size = new System.Drawing.Size(100, 100);
            this.pb_Right.TabIndex = 2;
            this.pb_Right.TabStop = false;
            // 
            // pb_Down
            // 
            this.pb_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Down.BackgroundImage")));
            this.pb_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Down.Location = new System.Drawing.Point(231, 270);
            this.pb_Down.Name = "pb_Down";
            this.pb_Down.Size = new System.Drawing.Size(100, 100);
            this.pb_Down.TabIndex = 3;
            this.pb_Down.TabStop = false;
            // 
            // pb_On
            // 
            this.pb_On.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_On.BackgroundImage")));
            this.pb_On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_On.Location = new System.Drawing.Point(231, 173);
            this.pb_On.Name = "pb_On";
            this.pb_On.Size = new System.Drawing.Size(100, 100);
            this.pb_On.TabIndex = 4;
            this.pb_On.TabStop = false;
            // 
            // pnl_Arriba
            // 
            this.pnl_Arriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.pnl_Arriba.Controls.Add(this.pb_Min);
            this.pnl_Arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Arriba.Location = new System.Drawing.Point(0, 0);
            this.pnl_Arriba.Name = "pnl_Arriba";
            this.pnl_Arriba.Size = new System.Drawing.Size(617, 38);
            this.pnl_Arriba.TabIndex = 5;
            this.pnl_Arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Arriba_MouseDown);
            // 
            // pb_Min
            // 
            this.pb_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_Min.Image = ((System.Drawing.Image)(resources.GetObject("pb_Min.Image")));
            this.pb_Min.Location = new System.Drawing.Point(552, 0);
            this.pb_Min.Name = "pb_Min";
            this.pb_Min.Size = new System.Drawing.Size(38, 38);
            this.pb_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Min.TabIndex = 1;
            this.pb_Min.TabStop = false;
            this.pb_Min.Click += new System.EventHandler(this.pb_Min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(272, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(272, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(269, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = " S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(109, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(434, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = " D";
            // 
            // ControlRemoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(617, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Arriba);
            this.Controls.Add(this.pb_On);
            this.Controls.Add(this.pb_Down);
            this.Controls.Add(this.pb_Right);
            this.Controls.Add(this.pb_Left);
            this.Controls.Add(this.pb_Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlRemoto";
            this.Text = "ControlRemoto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlRemoto_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlRemoto_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControlRemoto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_On)).EndInit();
            this.pnl_Arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Up;
        private System.Windows.Forms.PictureBox pb_Left;
        private System.Windows.Forms.PictureBox pb_Right;
        private System.Windows.Forms.PictureBox pb_Down;
        private System.Windows.Forms.PictureBox pb_On;
        private System.Windows.Forms.Panel pnl_Arriba;
        private System.Windows.Forms.PictureBox pb_Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}