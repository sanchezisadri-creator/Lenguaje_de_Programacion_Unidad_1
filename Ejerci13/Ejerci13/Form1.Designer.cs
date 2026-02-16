namespace Ejerci13
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            iniciar = new Button();
            finalizar = new Button();
            progreso = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(110, 83);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(361, 40);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // iniciar
            // 
            iniciar.Location = new Point(120, 167);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(153, 30);
            iniciar.TabIndex = 1;
            iniciar.Text = "inicio";
            iniciar.UseVisualStyleBackColor = true;
            // 
            // finalizar
            // 
            finalizar.Location = new Point(368, 167);
            finalizar.Name = "finalizar";
            finalizar.Size = new Size(140, 53);
            finalizar.TabIndex = 2;
            finalizar.Text = "final";
            finalizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(finalizar);
            Controls.Add(iniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button iniciar;
        private Button finalizar;
        private System.Windows.Forms.Timer progreso;
    }
}
