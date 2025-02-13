namespace Clonesaw
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDevil = new System.Windows.Forms.PictureBox();
            this.pictureBoxHuman = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumanHandL = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumanHandR = new System.Windows.Forms.PictureBox();
            this.pictureBoxDevilHandR = new System.Windows.Forms.PictureBox();
            this.pictureBoxDevilHandL = new System.Windows.Forms.PictureBox();
            this.pictureBoxBell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanHandL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanHandR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevilHandR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevilHandL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBell)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDevil
            // 
            this.pictureBoxDevil.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDevil.Location = new System.Drawing.Point(448, 16);
            this.pictureBoxDevil.Name = "pictureBoxDevil";
            this.pictureBoxDevil.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxDevil.TabIndex = 0;
            this.pictureBoxDevil.TabStop = false;
            // 
            // pictureBoxHuman
            // 
            this.pictureBoxHuman.BackColor = System.Drawing.Color.Red;
            this.pictureBoxHuman.Location = new System.Drawing.Point(448, 409);
            this.pictureBoxHuman.Name = "pictureBoxHuman";
            this.pictureBoxHuman.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxHuman.TabIndex = 1;
            this.pictureBoxHuman.TabStop = false;
            // 
            // pictureBoxHumanHandL
            // 
            this.pictureBoxHumanHandL.BackColor = System.Drawing.Color.Red;
            this.pictureBoxHumanHandL.Enabled = false;
            this.pictureBoxHumanHandL.Location = new System.Drawing.Point(547, 323);
            this.pictureBoxHumanHandL.Name = "pictureBoxHumanHandL";
            this.pictureBoxHumanHandL.Size = new System.Drawing.Size(61, 43);
            this.pictureBoxHumanHandL.TabIndex = 2;
            this.pictureBoxHumanHandL.TabStop = false;
            this.pictureBoxHumanHandL.Click += new System.EventHandler(this.pictureBoxHumanHandL_Click);
            // 
            // pictureBoxHumanHandR
            // 
            this.pictureBoxHumanHandR.BackColor = System.Drawing.Color.Red;
            this.pictureBoxHumanHandR.Location = new System.Drawing.Point(386, 323);
            this.pictureBoxHumanHandR.Name = "pictureBoxHumanHandR";
            this.pictureBoxHumanHandR.Size = new System.Drawing.Size(61, 43);
            this.pictureBoxHumanHandR.TabIndex = 3;
            this.pictureBoxHumanHandR.TabStop = false;
            this.pictureBoxHumanHandR.Click += new System.EventHandler(this.pictureBoxHumanHandR_Click);
            // 
            // pictureBoxDevilHandR
            // 
            this.pictureBoxDevilHandR.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDevilHandR.Location = new System.Drawing.Point(547, 95);
            this.pictureBoxDevilHandR.Name = "pictureBoxDevilHandR";
            this.pictureBoxDevilHandR.Size = new System.Drawing.Size(61, 43);
            this.pictureBoxDevilHandR.TabIndex = 5;
            this.pictureBoxDevilHandR.TabStop = false;
            this.pictureBoxDevilHandR.Click += new System.EventHandler(this.pictureBoxDevilHandR_Click);
            // 
            // pictureBoxDevilHandL
            // 
            this.pictureBoxDevilHandL.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDevilHandL.Location = new System.Drawing.Point(386, 95);
            this.pictureBoxDevilHandL.Name = "pictureBoxDevilHandL";
            this.pictureBoxDevilHandL.Size = new System.Drawing.Size(61, 43);
            this.pictureBoxDevilHandL.TabIndex = 4;
            this.pictureBoxDevilHandL.TabStop = false;
            this.pictureBoxDevilHandL.Click += new System.EventHandler(this.pictureBoxDevilHandL_Click);
            // 
            // pictureBoxBell
            // 
            this.pictureBoxBell.Location = new System.Drawing.Point(448, 202);
            this.pictureBoxBell.Name = "pictureBoxBell";
            this.pictureBoxBell.Size = new System.Drawing.Size(100, 51);
            this.pictureBoxBell.TabIndex = 6;
            this.pictureBoxBell.TabStop = false;
            this.pictureBoxBell.Click += new System.EventHandler(this.pictureBoxBell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 513);
            this.Controls.Add(this.pictureBoxBell);
            this.Controls.Add(this.pictureBoxDevilHandR);
            this.Controls.Add(this.pictureBoxDevilHandL);
            this.Controls.Add(this.pictureBoxHumanHandR);
            this.Controls.Add(this.pictureBoxHumanHandL);
            this.Controls.Add(this.pictureBoxHuman);
            this.Controls.Add(this.pictureBoxDevil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanHandL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumanHandR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevilHandR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevilHandL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDevil;
        private System.Windows.Forms.PictureBox pictureBoxHuman;
        public System.Windows.Forms.PictureBox pictureBoxBell;
        public System.Windows.Forms.PictureBox pictureBoxHumanHandL;
        public System.Windows.Forms.PictureBox pictureBoxHumanHandR;
        public System.Windows.Forms.PictureBox pictureBoxDevilHandR;
        public System.Windows.Forms.PictureBox pictureBoxDevilHandL;
    }
}

