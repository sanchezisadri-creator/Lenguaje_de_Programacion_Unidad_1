namespace Ejerci16
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
            Pantalla = new TextBox();
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
            label1 = new Label();
            SuspendLayout();
            // 
            // Pantalla
            // 
            Pantalla.Location = new Point(249, 50);
            Pantalla.Name = "Pantalla";
            Pantalla.ReadOnly = true;
            Pantalla.RightToLeft = RightToLeft.Yes;
            Pantalla.Size = new Size(233, 27);
            Pantalla.TabIndex = 0;
            Pantalla.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(249, 99);
            button1.Name = "button1";
            button1.Size = new Size(61, 33);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(330, 99);
            button2.Name = "button2";
            button2.Size = new Size(61, 33);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(421, 99);
            button3.Name = "button3";
            button3.Size = new Size(61, 33);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(249, 148);
            button4.Name = "button4";
            button4.Size = new Size(61, 33);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(330, 148);
            button5.Name = "button5";
            button5.Size = new Size(61, 33);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(421, 148);
            button6.Name = "button6";
            button6.Size = new Size(61, 33);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(249, 202);
            button7.Name = "button7";
            button7.Size = new Size(61, 33);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(330, 202);
            button8.Name = "button8";
            button8.Size = new Size(61, 33);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(421, 202);
            button9.Name = "button9";
            button9.Size = new Size(61, 33);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(249, 241);
            button10.Name = "button10";
            button10.Size = new Size(36, 29);
            button10.TabIndex = 10;
            button10.Text = "+";
            // 
            // button11
            // 
            button11.Location = new Point(300, 241);
            button11.Name = "button11";
            button11.Size = new Size(42, 29);
            button11.TabIndex = 11;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(357, 241);
            button12.Name = "button12";
            button12.Size = new Size(45, 29);
            button12.TabIndex = 12;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(437, 241);
            button13.Name = "button13";
            button13.Size = new Size(45, 29);
            button13.TabIndex = 13;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 28);
            label1.TabIndex = 14;
            label1.Text = "Calculadora version pica pollo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
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
            Controls.Add(Pantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Pantalla;
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
        private Label label1;
    }
}
