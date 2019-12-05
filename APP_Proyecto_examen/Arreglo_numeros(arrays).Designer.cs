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
            this.muestra = new System.Windows.Forms.ListBox();
            this.mostrar = new System.Windows.Forms.Button();
            this.orden = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ordenar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // muestra
            // 
            this.muestra.FormattingEnabled = true;
            this.muestra.Location = new System.Drawing.Point(29, 91);
            this.muestra.Name = "muestra";
            this.muestra.Size = new System.Drawing.Size(183, 316);
            this.muestra.TabIndex = 0;
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(433, 91);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 1;
            this.mostrar.Text = "&Mostrar";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // orden
            // 
            this.orden.Location = new System.Drawing.Point(433, 120);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(75, 23);
            this.orden.TabIndex = 2;
            this.orden.Text = "&Ordenar";
            this.orden.UseVisualStyleBackColor = true;
            this.orden.Click += new System.EventHandler(this.orden_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(433, 149);
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
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Location = new System.Drawing.Point(226, 91);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(162, 316);
            this.ordenar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // Arreglo_numeros_arrays_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.muestra);
            this.Name = "Arreglo_numeros_arrays_";
            this.Text = "Arreglo_numeros_arrays_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox muestra;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ordenar;
        private System.Windows.Forms.Label label2;
    }
}