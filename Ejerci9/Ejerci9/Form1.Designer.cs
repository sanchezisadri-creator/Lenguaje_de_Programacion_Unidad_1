namespace Ejerci9
{
    partial class Numero
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
            IngreseNumero = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // IngreseNumero
            // 
            IngreseNumero.AutoSize = true;
            IngreseNumero.Location = new Point(337, 64);
            IngreseNumero.Name = "IngreseNumero";
            IngreseNumero.Size = new Size(111, 20);
            IngreseNumero.TabIndex = 0;
            IngreseNumero.Text = "IngreseNumero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(323, 186);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Numero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(IngreseNumero);
            Name = "Numero";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IngreseNumero;
        private TextBox textBox1;
        private Button button1;
    }
}
