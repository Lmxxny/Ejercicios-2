namespace Valor
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtacele = new System.Windows.Forms.TextBox();
            this.txtfuerza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtmasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Aceleración:";
            // 
            // txtacele
            // 
            this.txtacele.Location = new System.Drawing.Point(221, 123);
            this.txtacele.Name = "txtacele";
            this.txtacele.Size = new System.Drawing.Size(98, 29);
            this.txtacele.TabIndex = 51;
            this.txtacele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfuerza
            // 
            this.txtfuerza.Location = new System.Drawing.Point(177, 250);
            this.txtfuerza.Name = "txtfuerza";
            this.txtfuerza.Size = new System.Drawing.Size(173, 29);
            this.txtfuerza.TabIndex = 50;
            this.txtfuerza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fuerza:";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(286, 182);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(103, 44);
            this.btncerrar.TabIndex = 48;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncalc.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(177, 182);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(103, 44);
            this.btncalc.TabIndex = 47;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlimpiar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(68, 182);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 44);
            this.btnlimpiar.TabIndex = 46;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtmasa
            // 
            this.txtmasa.Location = new System.Drawing.Point(221, 65);
            this.txtmasa.Name = "txtmasa";
            this.txtmasa.Size = new System.Drawing.Size(98, 29);
            this.txtmasa.TabIndex = 45;
            this.txtmasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Masa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Calcular el valor de la fuerza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(421, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtacele);
            this.Controls.Add(this.txtfuerza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtmasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtacele;
        private System.Windows.Forms.TextBox txtfuerza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtmasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

