﻿
namespace Bai2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listImage = new System.Windows.Forms.ListBox();
            this.boxImage = new Bps.Fx.ImageBox.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_Rec = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.CheckOnClick = true;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // listImage
            // 
            this.listImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.listImage.FormattingEnabled = true;
            this.listImage.Location = new System.Drawing.Point(0, 24);
            this.listImage.Name = "listImage";
            this.listImage.Size = new System.Drawing.Size(120, 426);
            this.listImage.TabIndex = 1;
            this.listImage.SelectedIndexChanged += new System.EventHandler(this.listImage_SelectedIndexChanged);
            // 
            // boxImage
            // 
            this.boxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxImage.Location = new System.Drawing.Point(120, 24);
            this.boxImage.Name = "boxImage";
            this.boxImage.ReadEXIF = false;
            this.boxImage.Size = new System.Drawing.Size(680, 426);
            this.boxImage.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_Rec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 3;
            // 
            // rad_Rec
            // 
            this.rad_Rec.AutoSize = true;
            this.rad_Rec.Location = new System.Drawing.Point(14, 14);
            this.rad_Rec.Name = "rad_Rec";
            this.rad_Rec.Size = new System.Drawing.Size(74, 17);
            this.rad_Rec.TabIndex = 0;
            this.rad_Rec.TabStop = true;
            this.rad_Rec.Text = "Rectangle";
            this.rad_Rec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxImage);
            this.Controls.Add(this.listImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ListBox listImage;
        private Bps.Fx.ImageBox.ImageBox boxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rad_Rec;
    }
}

