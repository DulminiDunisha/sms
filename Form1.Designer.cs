﻿namespace sms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 55);
            label1.Name = "label1";
            label1.Size = new Size(224, 15);
            label1.TabIndex = 0;
            label1.Text = "SUPERMARCKET MANAGEMENT SYSTEM";
            // 
            // button1
            // 
            button1.Location = new Point(337, 149);
            button1.Name = "button1";
            button1.Size = new Size(122, 57);
            button1.TabIndex = 1;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(581, 294);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "dulmini";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
    }
}
