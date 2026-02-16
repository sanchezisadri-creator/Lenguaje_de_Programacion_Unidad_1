namespace Ejerci11
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
            SelectorFecha = new DateTimePicker();
            EtiquetaFecha = new Label();
            MostrarFecha = new Button();
            SuspendLayout();
            // 
            // SelectorFecha
            // 
            SelectorFecha.Location = new Point(278, 70);
            SelectorFecha.Name = "SelectorFecha";
            SelectorFecha.Size = new Size(162, 27);
            SelectorFecha.TabIndex = 0;
            // 
            // EtiquetaFecha
            // 
            EtiquetaFecha.AutoSize = true;
            EtiquetaFecha.Location = new Point(269, 117);
            EtiquetaFecha.Name = "EtiquetaFecha";
            EtiquetaFecha.Size = new Size(189, 20);
            EtiquetaFecha.TabIndex = 1;
            EtiquetaFecha.Text = "\"Aquí se mostrará la fecha\"";
            // 
            // MostrarFecha
            // 
            MostrarFecha.Location = new Point(278, 185);
            MostrarFecha.Name = "MostrarFecha";
            MostrarFecha.Size = new Size(139, 43);
            MostrarFecha.TabIndex = 2;
            MostrarFecha.Text = "\"Mostrar Fecha\"";
            MostrarFecha.UseVisualStyleBackColor = true;
            MostrarFecha.Click += MostrarFecha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MostrarFecha);
            Controls.Add(EtiquetaFecha);
            Controls.Add(SelectorFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SelectorFecha;
        private Label EtiquetaFecha;
        private Button MostrarFecha;
    }
}
