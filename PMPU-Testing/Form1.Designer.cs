﻿namespace PMPU_Testing
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
            this.btn_single = new System.Windows.Forms.Button();
            this.btn_changeMonitor = new System.Windows.Forms.Button();
            this.btn_quad = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_single
            // 
            this.btn_single.Location = new System.Drawing.Point(97, 70);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(138, 23);
            this.btn_single.TabIndex = 0;
            this.btn_single.Text = "Single Camera";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // btn_changeMonitor
            // 
            this.btn_changeMonitor.Location = new System.Drawing.Point(97, 128);
            this.btn_changeMonitor.Name = "btn_changeMonitor";
            this.btn_changeMonitor.Size = new System.Drawing.Size(138, 23);
            this.btn_changeMonitor.TabIndex = 1;
            this.btn_changeMonitor.Text = "Change Single Monitor";
            this.btn_changeMonitor.UseVisualStyleBackColor = true;
            this.btn_changeMonitor.Click += new System.EventHandler(this.btn_changeMonitor_Click);
            // 
            // btn_quad
            // 
            this.btn_quad.Location = new System.Drawing.Point(97, 99);
            this.btn_quad.Name = "btn_quad";
            this.btn_quad.Size = new System.Drawing.Size(138, 23);
            this.btn_quad.TabIndex = 2;
            this.btn_quad.Text = "Quad Cameras";
            this.btn_quad.UseVisualStyleBackColor = true;
            this.btn_quad.Click += new System.EventHandler(this.btn_quad_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(97, 158);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(138, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send Change";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_quad);
            this.Controls.Add(this.btn_changeMonitor);
            this.Controls.Add(this.btn_single);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_changeMonitor;
        private System.Windows.Forms.Button btn_quad;
        private System.Windows.Forms.Button btn_send;
    }
}

