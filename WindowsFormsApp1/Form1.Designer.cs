namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrimary = new System.Windows.Forms.Button();
            this.textoLabel = new System.Windows.Forms.Label();
            this.textForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrimary
            // 
            this.btnPrimary.Location = new System.Drawing.Point(565, 31);
            this.btnPrimary.Name = "btnPrimary";
            this.btnPrimary.Size = new System.Drawing.Size(75, 23);
            this.btnPrimary.TabIndex = 0;
            this.btnPrimary.Text = "btnPrimary";
            this.btnPrimary.UseVisualStyleBackColor = true;
            this.btnPrimary.Click += new System.EventHandler(this.btnPrimary_Click);
            // 
            // textoLabel
            // 
            this.textoLabel.AutoSize = true;
            this.textoLabel.Location = new System.Drawing.Point(76, 38);
            this.textoLabel.Name = "textoLabel";
            this.textoLabel.Size = new System.Drawing.Size(60, 13);
            this.textoLabel.TabIndex = 1;
            this.textoLabel.Text = "Bienvenido";
            // 
            // textForm
            // 
            this.textForm.Location = new System.Drawing.Point(154, 31);
            this.textForm.Name = "textForm";
            this.textForm.Size = new System.Drawing.Size(387, 20);
            this.textForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textForm);
            this.Controls.Add(this.textoLabel);
            this.Controls.Add(this.btnPrimary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimary;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.TextBox textForm;
    }
}

