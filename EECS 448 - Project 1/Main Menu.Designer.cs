﻿
namespace EECS_448___Project_1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Button NetworkGameButton;
            this.LocalGameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            NetworkGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NetworkGameButton
            // 
            NetworkGameButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            NetworkGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            NetworkGameButton.Location = new System.Drawing.Point(25, 197);
            NetworkGameButton.Name = "NetworkGameButton";
            NetworkGameButton.Size = new System.Drawing.Size(399, 103);
            NetworkGameButton.TabIndex = 2;
            NetworkGameButton.Text = "Network Game ";
            NetworkGameButton.UseVisualStyleBackColor = false;
            // 
            // LocalGameButton
            // 
            this.LocalGameButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LocalGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.LocalGameButton.Location = new System.Drawing.Point(25, 88);
            this.LocalGameButton.Name = "LocalGameButton";
            this.LocalGameButton.Size = new System.Drawing.Size(399, 103);
            this.LocalGameButton.TabIndex = 0;
            this.LocalGameButton.Text = "Local Game";
            this.LocalGameButton.UseVisualStyleBackColor = false;
            this.LocalGameButton.Click += new System.EventHandler(this.LocalGameButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.button1.Location = new System.Drawing.Point(25, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 103);
            this.button1.TabIndex = 1;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Battleship";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(449, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(NetworkGameButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LocalGameButton);
            this.Name = "Form1";
            this.Text = "Battleship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LocalGameButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

