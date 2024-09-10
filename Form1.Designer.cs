namespace Lab3
{
    partial class Form1
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
            this.btidentificar = new System.Windows.Forms.Button();
            this.listbVocales = new System.Windows.Forms.ListBox();
            this.lbIngresarPalabra = new System.Windows.Forms.Label();
            this.txtIngresarPalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btidentificar
            // 
            this.btidentificar.BackColor = System.Drawing.Color.Thistle;
            this.btidentificar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btidentificar.Location = new System.Drawing.Point(57, 352);
            this.btidentificar.Name = "btidentificar";
            this.btidentificar.Size = new System.Drawing.Size(110, 38);
            this.btidentificar.TabIndex = 0;
            this.btidentificar.Text = "Identificar";
            this.btidentificar.UseVisualStyleBackColor = false;
            this.btidentificar.Click += new System.EventHandler(this.btidentificar_Click);
            // 
            // listbVocales
            // 
            this.listbVocales.BackColor = System.Drawing.Color.LavenderBlush;
            this.listbVocales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbVocales.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbVocales.FormattingEnabled = true;
            this.listbVocales.ItemHeight = 18;
            this.listbVocales.Location = new System.Drawing.Point(473, 132);
            this.listbVocales.Name = "listbVocales";
            this.listbVocales.Size = new System.Drawing.Size(103, 146);
            this.listbVocales.TabIndex = 1;
            this.listbVocales.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbIngresarPalabra
            // 
            this.lbIngresarPalabra.AutoSize = true;
            this.lbIngresarPalabra.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresarPalabra.Location = new System.Drawing.Point(53, 155);
            this.lbIngresarPalabra.Name = "lbIngresarPalabra";
            this.lbIngresarPalabra.Size = new System.Drawing.Size(180, 21);
            this.lbIngresarPalabra.TabIndex = 2;
            this.lbIngresarPalabra.Text = "Ingrese una palabra: ";
            this.lbIngresarPalabra.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngresarPalabra
            // 
            this.txtIngresarPalabra.Location = new System.Drawing.Point(48, 189);
            this.txtIngresarPalabra.MaxLength = 35;
            this.txtIngresarPalabra.Name = "txtIngresarPalabra";
            this.txtIngresarPalabra.Size = new System.Drawing.Size(243, 22);
            this.txtIngresarPalabra.TabIndex = 3;
            this.txtIngresarPalabra.Validating += new System.ComponentModel.CancelEventHandler(this.txtIngresarPalabra_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificador de Vocales";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btSiguiente
            // 
            this.btSiguiente.BackColor = System.Drawing.Color.Thistle;
            this.btSiguiente.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSiguiente.Location = new System.Drawing.Point(604, 352);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(110, 38);
            this.btSiguiente.TabIndex = 5;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = false;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngresarPalabra);
            this.Controls.Add(this.lbIngresarPalabra);
            this.Controls.Add(this.listbVocales);
            this.Controls.Add(this.btidentificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btidentificar;
        private System.Windows.Forms.ListBox listbVocales;
        private System.Windows.Forms.Label lbIngresarPalabra;
        private System.Windows.Forms.TextBox txtIngresarPalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSiguiente;
    }
}

