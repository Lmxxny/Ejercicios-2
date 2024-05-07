namespace Cifras
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
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcifra = new System.Windows.Forms.TextBox();
            this.txtinvertido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "El número es:";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(321, 195);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(138, 56);
            this.btncerrar.TabIndex = 31;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncalc.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(177, 195);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(138, 56);
            this.btncalc.TabIndex = 30;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlimpiar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(33, 195);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(138, 56);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Provea un número de 3 cifras:";
            // 
            // txtcifra
            // 
            this.txtcifra.Location = new System.Drawing.Point(165, 76);
            this.txtcifra.Name = "txtcifra";
            this.txtcifra.Size = new System.Drawing.Size(137, 29);
            this.txtcifra.TabIndex = 27;
            this.txtcifra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtinvertido
            // 
            this.txtinvertido.Location = new System.Drawing.Point(228, 131);
            this.txtinvertido.Name = "txtinvertido";
            this.txtinvertido.Size = new System.Drawing.Size(143, 29);
            this.txtinvertido.TabIndex = 26;
            this.txtinvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(502, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcifra);
            this.Controls.Add(this.txtinvertido);
            this.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcifra;
        private System.Windows.Forms.TextBox txtinvertido;
    }
}

