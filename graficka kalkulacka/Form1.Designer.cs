﻿namespace graficka_kalkulacka
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            text = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(91, 318);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton;
            // 
            // button2
            // 
            button2.Location = new Point(228, 318);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton;
            // 
            // button3
            // 
            button3.Location = new Point(367, 318);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton;
            // 
            // button4
            // 
            button4.Location = new Point(91, 257);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton;
            // 
            // button5
            // 
            button5.Location = new Point(228, 257);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton;
            // 
            // button6
            // 
            button6.Location = new Point(367, 257);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton;
            // 
            // button7
            // 
            button7.Location = new Point(91, 195);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton;
            // 
            // button8
            // 
            button8.Location = new Point(228, 195);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton;
            // 
            // button9
            // 
            button9.Location = new Point(367, 195);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton;
            // 
            // button10
            // 
            button10.Location = new Point(228, 371);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton;
            // 
            // button11
            // 
            button11.Location = new Point(558, 139);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 10;
            button11.Text = "/";
            button11.UseVisualStyleBackColor = true;
            button11.Click += SignButton;
            // 
            // button12
            // 
            button12.Location = new Point(558, 195);
            button12.Name = "button12";
            button12.Size = new Size(112, 34);
            button12.TabIndex = 11;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += SignButton;
            // 
            // button13
            // 
            button13.Location = new Point(558, 257);
            button13.Name = "button13";
            button13.Size = new Size(112, 34);
            button13.TabIndex = 12;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += SignButton;
            // 
            // button14
            // 
            button14.Location = new Point(558, 318);
            button14.Name = "button14";
            button14.Size = new Size(112, 34);
            button14.TabIndex = 13;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += SignButton;
            // 
            // button15
            // 
            button15.Location = new Point(558, 371);
            button15.Name = "button15";
            button15.Size = new Size(112, 34);
            button15.TabIndex = 14;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += EvaluateButton;
            // 
            // text
            // 
            text.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            text.Location = new Point(91, 61);
            text.Multiline = true;
            text.Name = "text";
            text.Size = new Size(388, 97);
            text.TabIndex = 15;
            text.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(text);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private TextBox text;
        private Label label1;
    }
}
