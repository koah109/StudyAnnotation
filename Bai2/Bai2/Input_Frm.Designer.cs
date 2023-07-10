
namespace Bai2
{
    partial class Input_Frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Input_box = new System.Windows.Forms.TextBox();
            this.Output_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_btn = new System.Windows.Forms.Button();
            this.Output_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Image";
            // 
            // Input_box
            // 
            this.Input_box.Location = new System.Drawing.Point(169, 26);
            this.Input_box.Name = "Input_box";
            this.Input_box.Size = new System.Drawing.Size(343, 20);
            this.Input_box.TabIndex = 1;
            // 
            // Output_box
            // 
            this.Output_box.Location = new System.Drawing.Point(169, 75);
            this.Output_box.Name = "Output_box";
            this.Output_box.Size = new System.Drawing.Size(343, 20);
            this.Output_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Image";
            // 
            // Input_btn
            // 
            this.Input_btn.Location = new System.Drawing.Point(541, 20);
            this.Input_btn.Name = "Input_btn";
            this.Input_btn.Size = new System.Drawing.Size(49, 31);
            this.Input_btn.TabIndex = 4;
            this.Input_btn.Text = "...";
            this.Input_btn.UseVisualStyleBackColor = true;
            this.Input_btn.Click += new System.EventHandler(this.Input_btn_Click);
            // 
            // Output_btn
            // 
            this.Output_btn.Location = new System.Drawing.Point(541, 75);
            this.Output_btn.Name = "Output_btn";
            this.Output_btn.Size = new System.Drawing.Size(49, 31);
            this.Output_btn.TabIndex = 5;
            this.Output_btn.Text = "...";
            this.Output_btn.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(633, 37);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 51);
            this.OK_btn.TabIndex = 6;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Input_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 151);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Output_btn);
            this.Controls.Add(this.Input_btn);
            this.Controls.Add(this.Output_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_box);
            this.Controls.Add(this.label1);
            this.Name = "Input_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_box;
        private System.Windows.Forms.TextBox Output_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Input_btn;
        private System.Windows.Forms.Button Output_btn;
        private System.Windows.Forms.Button OK_btn;
    }
}