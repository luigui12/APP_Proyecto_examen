namespace APP_Proyecto_examen
{
    partial class Serie_Factorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.limite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el limite serie Fac.";
            // 
            // limite
            // 
            this.limite.Location = new System.Drawing.Point(231, 62);
            this.limite.Name = "limite";
            this.limite.Size = new System.Drawing.Size(100, 20);
            this.limite.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suma de serie factorial es:";
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(231, 99);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(100, 20);
            this.suma.TabIndex = 3;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(112, 160);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(231, 160);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Serie_Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 195);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limite);
            this.Controls.Add(this.label1);
            this.Name = "Serie_Factorial";
            this.Text = "Serie_Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox limite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Salir;
    }
}