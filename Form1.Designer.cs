﻿namespace Klavyeden__Girilen__3_Değeri_Çarpan_Uygulama
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Location = new Point(150, 210);
            button1.Name = "button1";
            button1.Size = new Size(137, 34);
            button1.TabIndex = 0;
            button1.Text = "Çarpım";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 33);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 33);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 33);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 45);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 4;
            label1.Text = "1. Sayı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 84);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 5;
            label2.Text = "2. Sayı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 123);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 6;
            label3.Text = "3. Sayı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 79);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Sonuç :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 80);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(634, 434);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}