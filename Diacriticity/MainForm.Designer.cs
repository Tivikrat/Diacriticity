namespace Diacriticity
{
    partial class MainForm
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
            this.buttonVariant1 = new System.Windows.Forms.Button();
            this.buttonVariant2 = new System.Windows.Forms.Button();
            this.buttonVariant3 = new System.Windows.Forms.Button();
            this.buttonVariant4 = new System.Windows.Forms.Button();
            this.buttonVariant5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVariant1
            // 
            this.buttonVariant1.Location = new System.Drawing.Point(16, 15);
            this.buttonVariant1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVariant1.Name = "buttonVariant1";
            this.buttonVariant1.Size = new System.Drawing.Size(128, 28);
            this.buttonVariant1.TabIndex = 0;
            this.buttonVariant1.Text = "Варіант 1";
            this.buttonVariant1.UseVisualStyleBackColor = true;
            this.buttonVariant1.Click += new System.EventHandler(this.buttonVariant1_Click);
            // 
            // buttonVariant2
            // 
            this.buttonVariant2.Location = new System.Drawing.Point(16, 50);
            this.buttonVariant2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVariant2.Name = "buttonVariant2";
            this.buttonVariant2.Size = new System.Drawing.Size(128, 28);
            this.buttonVariant2.TabIndex = 0;
            this.buttonVariant2.Text = "Варіант 2";
            this.buttonVariant2.UseVisualStyleBackColor = true;
            this.buttonVariant2.Click += new System.EventHandler(this.buttonVariant2_Click);
            // 
            // buttonVariant3
            // 
            this.buttonVariant3.Location = new System.Drawing.Point(16, 86);
            this.buttonVariant3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVariant3.Name = "buttonVariant3";
            this.buttonVariant3.Size = new System.Drawing.Size(128, 28);
            this.buttonVariant3.TabIndex = 0;
            this.buttonVariant3.Text = "Варіант 3";
            this.buttonVariant3.UseVisualStyleBackColor = true;
            this.buttonVariant3.Click += new System.EventHandler(this.buttonVariant3_Click);
            // 
            // buttonVariant4
            // 
            this.buttonVariant4.Location = new System.Drawing.Point(16, 122);
            this.buttonVariant4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVariant4.Name = "buttonVariant4";
            this.buttonVariant4.Size = new System.Drawing.Size(128, 28);
            this.buttonVariant4.TabIndex = 0;
            this.buttonVariant4.Text = "Варіант 4";
            this.buttonVariant4.UseVisualStyleBackColor = true;
            this.buttonVariant4.Click += new System.EventHandler(this.buttonVariant4_Click);
            // 
            // buttonVariant5
            // 
            this.buttonVariant5.Location = new System.Drawing.Point(16, 158);
            this.buttonVariant5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVariant5.Name = "buttonVariant5";
            this.buttonVariant5.Size = new System.Drawing.Size(128, 28);
            this.buttonVariant5.TabIndex = 0;
            this.buttonVariant5.Text = "Варіант 5";
            this.buttonVariant5.UseVisualStyleBackColor = true;
            this.buttonVariant5.Click += new System.EventHandler(this.buttonVariant5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 243);
            this.Controls.Add(this.buttonVariant5);
            this.Controls.Add(this.buttonVariant4);
            this.Controls.Add(this.buttonVariant3);
            this.Controls.Add(this.buttonVariant2);
            this.Controls.Add(this.buttonVariant1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Diacriticity — Вибір варіанту";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVariant1;
        private System.Windows.Forms.Button buttonVariant2;
        private System.Windows.Forms.Button buttonVariant3;
        private System.Windows.Forms.Button buttonVariant4;
        private System.Windows.Forms.Button buttonVariant5;
    }
}

