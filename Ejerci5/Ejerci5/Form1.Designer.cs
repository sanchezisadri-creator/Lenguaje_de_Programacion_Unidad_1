namespace Ejerci5
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
            combo_colores = new ComboBox();
            SuspendLayout();
            // 
            // combo_colores
            // 
            combo_colores.FormattingEnabled = true;
            combo_colores.Items.AddRange(new object[] { "ROJO", "AZUL", "VERDE" });
            combo_colores.Location = new Point(239, 84);
            combo_colores.Name = "combo_colores";
            combo_colores.Size = new Size(173, 28);
            combo_colores.TabIndex = 0;
            combo_colores.SelectedIndexChanged += combo_colores_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combo_colores);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox combo_colores;
    }
}
