namespace ejerci4
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
            cajaNumero1 = new TextBox();
            cajaNumero2 = new TextBox();
            boton_Sumar = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // cajaNumero1
            // 
            cajaNumero1.Location = new Point(222, 39);
            cajaNumero1.Name = "cajaNumero1";
            cajaNumero1.Size = new Size(100, 27);
            cajaNumero1.TabIndex = 0;
            // 
            // cajaNumero2
            // 
            cajaNumero2.Location = new Point(379, 39);
            cajaNumero2.Name = "cajaNumero2";
            cajaNumero2.Size = new Size(135, 27);
            cajaNumero2.TabIndex = 1;
            // 
            // boton_Sumar
            // 
            boton_Sumar.BackColor = SystemColors.ActiveCaptionText;
            boton_Sumar.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_Sumar.ForeColor = SystemColors.ActiveCaption;
            boton_Sumar.Location = new Point(300, 110);
            boton_Sumar.Name = "boton_Sumar";
            boton_Sumar.Size = new Size(109, 55);
            boton_Sumar.TabIndex = 2;
            boton_Sumar.Text = "Dale pa que sume!";
            boton_Sumar.UseVisualStyleBackColor = false;
            boton_Sumar.Click += botonSumar_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(300, 80);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(115, 17);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "El resultado es :";
            labelResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 306);
            Controls.Add(labelResultado);
            Controls.Add(boton_Sumar);
            Controls.Add(cajaNumero2);
            Controls.Add(cajaNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cajaNumero1;
        private TextBox cajaNumero2;
        private Button boton_Sumar;
        private Label labelResultado;
    }
}
