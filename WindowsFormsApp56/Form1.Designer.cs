﻿namespace WindowsFormsApp56
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEgit = new System.Windows.Forms.Button();
            this.lblEgitilenAdet = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFaceName = new System.Windows.Forms.TextBox();
            this.btnEgitimSil = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEgit
            // 
            this.btnEgit.Location = new System.Drawing.Point(718, 12);
            this.btnEgit.Name = "btnEgit";
            this.btnEgit.Size = new System.Drawing.Size(102, 52);
            this.btnEgit.TabIndex = 1;
            this.btnEgit.Text = "Yüz Eğit\n(10 Adet)";
            this.btnEgit.UseVisualStyleBackColor = true;
            this.btnEgit.Click += new System.EventHandler(this.btnEgit_Click);
            // 
            // lblEgitilenAdet
            // 
            this.lblEgitilenAdet.AutoSize = true;
            this.lblEgitilenAdet.Location = new System.Drawing.Point(718, 96);
            this.lblEgitilenAdet.Name = "lblEgitilenAdet";
            this.lblEgitilenAdet.Size = new System.Drawing.Size(29, 13);
            this.lblEgitilenAdet.TabIndex = 2;
            this.lblEgitilenAdet.Text = "Adet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(718, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtFaceName
            // 
            this.txtFaceName.Location = new System.Drawing.Point(718, 70);
            this.txtFaceName.Name = "txtFaceName";
            this.txtFaceName.Size = new System.Drawing.Size(102, 20);
            this.txtFaceName.TabIndex = 4;
            // 
            // btnEgitimSil
            // 
            this.btnEgitimSil.Location = new System.Drawing.Point(718, 237);
            this.btnEgitimSil.Name = "btnEgitimSil";
            this.btnEgitimSil.Size = new System.Drawing.Size(102, 52);
            this.btnEgitimSil.TabIndex = 5;
            this.btnEgitimSil.Text = "Tüm Eğitimleri Sil";
            this.btnEgitimSil.UseVisualStyleBackColor = true;
            this.btnEgitimSil.Click += new System.EventHandler(this.btnEgitimSil_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(718, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 485);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnEgitimSil);
            this.Controls.Add(this.txtFaceName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEgitilenAdet);
            this.Controls.Add(this.btnEgit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEgit;
        private System.Windows.Forms.Label lblEgitilenAdet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFaceName;
        private System.Windows.Forms.Button btnEgitimSil;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

