namespace Ejerci12
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
            EtiquetaCelsius = new Label();
            Celsius = new TextBox();
            Convertir = new Button();
            Resultado = new Label();
            SuspendLayout();
            // 
            // EtiquetaCelsius
            // 
            EtiquetaCelsius.AutoSize = true;
            EtiquetaCelsius.Location = new Point(332, 60);
            EtiquetaCelsius.Name = "EtiquetaCelsius";
            EtiquetaCelsius.Size = new Size(50, 20);
            EtiquetaCelsius.TabIndex = 0;
            EtiquetaCelsius.Text = "label1";
            // 
            // Celsius
            // 
            Celsius.Location = new Point(284, 94);
            Celsius.Name = "Celsius";
            Celsius.Size = new Size(142, 27);
            Celsius.TabIndex = 1;
            // 
            // Convertir
            // 
            Convertir.Location = new Point(271, 127);
            Convertir.Name = "Convertir";
            Convertir.Size = new Size(164, 127);
            Convertir.TabIndex = 2;
            Convertir.Text = "Dale";
            Convertir.UseVisualStyleBackColor = true;
            Convertir.Click += Convertir_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(556, 312);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(50, 20);
            Resultado.TabIndex = 3;
            Resultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(Convertir);
            Controls.Add(Celsius);
            Controls.Add(EtiquetaCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaCelsius;
        private TextBox Celsius;
        private Button Convertir;
        private Label Resultado;
    }
}
