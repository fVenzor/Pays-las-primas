namespace Pays_las_primas
{
    partial class Administrador
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
            this.lbltext1 = new System.Windows.Forms.Label();
            this.lbltext2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.Location = new System.Drawing.Point(36, 33);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(0, 13);
            this.lbltext1.TabIndex = 0;
            // 
            // lbltext2
            // 
            this.lbltext2.AutoSize = true;
            this.lbltext2.Location = new System.Drawing.Point(36, 60);
            this.lbltext2.Name = "lbltext2";
            this.lbltext2.Size = new System.Drawing.Size(70, 13);
            this.lbltext2.TabIndex = 1;
            this.lbltext2.Text = "Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del Usuario";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltext2);
            this.Controls.Add(this.lbltext1);
            this.Name = "Administrador";
            this.Text = "Bienvenido Adminitstrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext1;
        private System.Windows.Forms.Label lbltext2;
        private System.Windows.Forms.Label label1;
    }
}