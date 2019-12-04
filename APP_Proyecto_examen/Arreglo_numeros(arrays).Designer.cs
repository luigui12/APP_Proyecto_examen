namespace APP_Proyecto_examen
{
    partial class Arreglo_numeros_arrays_
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.mostrar = new System.Windows.Forms.Button();
            this.orden = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(159, 91);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(183, 160);
            this.Lista.TabIndex = 0;
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(374, 91);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 1;
            this.mostrar.Text = "&Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            // 
            // orden
            // 
            this.orden.Location = new System.Drawing.Point(374, 120);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(75, 23);
            this.orden.TabIndex = 2;
            this.orden.Text = "&Ordenar";
            this.orden.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(374, 149);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "&Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordenacion de 20 numeros reales";
            // 
            // Arreglo_numeros_arrays_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.Lista);
            this.Name = "Arreglo_numeros_arrays_";
            this.Text = "Arreglo_numeros_arrays_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
    }
}