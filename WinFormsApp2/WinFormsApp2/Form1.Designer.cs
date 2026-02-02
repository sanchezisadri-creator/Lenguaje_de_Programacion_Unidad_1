namespace WinFormsApp2
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
            exotico_1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(305, 137);
            button1.Name = "button1";
            button1.Size = new Size(154, 79);
            button1.TabIndex = 1;
            button1.Text = "Toca este boton para que muestre el label o etiqueta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 2;
            // 
            // exotico_1
            // 
            exotico_1.AutoSize = true;
            exotico_1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exotico_1.Location = new Point(343, 97);
            exotico_1.Name = "exotico_1";
            exotico_1.Size = new Size(82, 25);
            exotico_1.TabIndex = 3;
            exotico_1.Text = "exotico";
            exotico_1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 226);
            Controls.Add(exotico_1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label exotico_1;
    }
}
