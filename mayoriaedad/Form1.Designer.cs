namespace mayoriaedad
{
    partial class programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.añotxt = new System.Windows.Forms.TextBox();
            this.diatxt = new System.Windows.Forms.TextBox();
            this.mestxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su año de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su mes de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese su día de nacimiento:";
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(402, 124);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(100, 24);
            this.btncontinuar.TabIndex = 6;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.Btncontinuar_Click);
            // 
            // añotxt
            // 
            this.añotxt.Location = new System.Drawing.Point(402, 28);
            this.añotxt.Name = "añotxt";
            this.añotxt.Size = new System.Drawing.Size(100, 20);
            this.añotxt.TabIndex = 7;
            // 
            // diatxt
            // 
            this.diatxt.Location = new System.Drawing.Point(402, 88);
            this.diatxt.Name = "diatxt";
            this.diatxt.Size = new System.Drawing.Size(100, 20);
            this.diatxt.TabIndex = 8;
            // 
            // mestxt
            // 
            this.mestxt.Location = new System.Drawing.Point(402, 58);
            this.mestxt.Name = "mestxt";
            this.mestxt.Size = new System.Drawing.Size(100, 20);
            this.mestxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "_________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Programa para calcular la matoria de edad del usuario.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "___________________________________________";
            // 
            // programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mestxt);
            this.Controls.Add(this.diatxt);
            this.Controls.Add(this.añotxt);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programa";
            this.Text = "Calculo mayoría de edad.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.TextBox añotxt;
        private System.Windows.Forms.TextBox diatxt;
        private System.Windows.Forms.TextBox mestxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

