﻿
namespace Kaptan_Pansiyon_v1
{
    partial class FrmAnaForm
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
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminGiris.Location = new System.Drawing.Point(73, 64);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(100, 71);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Admin Giriş";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.SteelBlue;
            this.btnYeniMusteri.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYeniMusteri.Location = new System.Drawing.Point(342, 64);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(100, 71);
            this.btnYeniMusteri.TabIndex = 0;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOdalar.Location = new System.Drawing.Point(602, 64);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(100, 71);
            this.btnOdalar.TabIndex = 0;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.btnAdminGiris);
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnOdalar;
    }
}