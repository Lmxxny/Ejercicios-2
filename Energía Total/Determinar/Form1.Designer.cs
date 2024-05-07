namespace Determinar
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
            this.txtvelo = new System.Windows.Forms.TextBox();
            this.txtenercin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtmasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtenerpot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtenertot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Velocidad:";
            // 
            // txtvelo
            // 
            this.txtvelo.Location = new System.Drawing.Point(209, 143);
            this.txtvelo.Name = "txtvelo";
            this.txtvelo.Size = new System.Drawing.Size(98, 29);
            this.txtvelo.TabIndex = 51;
            this.txtvelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtenercin
            // 
            this.txtenercin.Location = new System.Drawing.Point(191, 322);
            this.txtenercin.Name = "txtenercin";
            this.txtenercin.Size = new System.Drawing.Size(173, 29);
            this.txtenercin.TabIndex = 50;
            this.txtenercin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Energía Cinética:";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(297, 246);
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
            this.btncalc.Location = new System.Drawing.Point(188, 246);
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
            this.btnlimpiar.Location = new System.Drawing.Point(79, 246);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 44);
            this.btnlimpiar.TabIndex = 46;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtmasa
            // 
            this.txtmasa.Location = new System.Drawing.Point(209, 97);
            this.txtmasa.Name = "txtmasa";
            this.txtmasa.Size = new System.Drawing.Size(98, 29);
            this.txtmasa.TabIndex = 45;
            this.txtmasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Masa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Calcular la energía total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 26);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ingrese los siguientes datos:";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(209, 191);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(98, 29);
            this.txtaltura.TabIndex = 55;
            this.txtaltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Altura:";
            // 
            // txtenerpot
            // 
            this.txtenerpot.Location = new System.Drawing.Point(191, 375);
            this.txtenerpot.Name = "txtenerpot";
            this.txtenerpot.Size = new System.Drawing.Size(173, 29);
            this.txtenerpot.TabIndex = 59;
            this.txtenerpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Energía Potencial:";
            // 
            // txtenertot
            // 
            this.txtenertot.Location = new System.Drawing.Point(191, 428);
            this.txtenertot.Name = "txtenertot";
            this.txtenertot.Size = new System.Drawing.Size(173, 29);
            this.txtenertot.TabIndex = 61;
            this.txtenertot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 22);
            this.label9.TabIndex = 60;
            this.label9.Text = "Eenergía Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(465, 488);
            this.Controls.Add(this.txtenertot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtenerpot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvelo);
            this.Controls.Add(this.txtenercin);
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
        private System.Windows.Forms.TextBox txtvelo;
        private System.Windows.Forms.TextBox txtenercin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtmasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtenerpot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtenertot;
        private System.Windows.Forms.Label label9;
    }
}

