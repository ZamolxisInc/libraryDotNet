﻿namespace libraryDotNet
{
    partial class InchiriazaCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InchiriazaCarte));
            this.buttonInchiriazaCarte = new System.Windows.Forms.Button();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInchiriazaCarte
            // 
            this.buttonInchiriazaCarte.Location = new System.Drawing.Point(388, 26);
            this.buttonInchiriazaCarte.Name = "buttonInchiriazaCarte";
            this.buttonInchiriazaCarte.Size = new System.Drawing.Size(140, 134);
            this.buttonInchiriazaCarte.TabIndex = 0;
            this.buttonInchiriazaCarte.Text = "Inchiriaza carte";
            this.buttonInchiriazaCarte.UseVisualStyleBackColor = true;
            this.buttonInchiriazaCarte.Click += new System.EventHandler(this.buttonInchiriazaCarte_Click);
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(98, 34);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(248, 20);
            this.textBoxBookID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "bookID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(98, 68);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(248, 20);
            this.textBoxNume.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenume";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(98, 104);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(248, 20);
            this.textBoxPrenume.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clasa";
            // 
            // textBoxClasa
            // 
            this.textBoxClasa.Location = new System.Drawing.Point(98, 140);
            this.textBoxClasa.Name = "textBoxClasa";
            this.textBoxClasa.Size = new System.Drawing.Size(248, 20);
            this.textBoxClasa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inchiriaza cartea";
            // 
            // InchiriazaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 185);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxClasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.buttonInchiriazaCarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InchiriazaCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InchiriazaCarte";
            this.Load += new System.EventHandler(this.InchiriazaCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInchiriazaCarte;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxClasa;
        private System.Windows.Forms.Label label5;
    }
}