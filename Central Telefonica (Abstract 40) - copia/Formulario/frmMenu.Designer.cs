namespace Formulario
{
    partial class frmMenu
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
            this.buttonGrarLlamada = new System.Windows.Forms.Button();
            this.buttonFactTotal = new System.Windows.Forms.Button();
            this.buttonFacLocal = new System.Windows.Forms.Button();
            this.buttonFactProvincial = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGrarLlamada
            // 
            this.buttonGrarLlamada.Location = new System.Drawing.Point(11, 12);
            this.buttonGrarLlamada.Name = "buttonGrarLlamada";
            this.buttonGrarLlamada.Size = new System.Drawing.Size(242, 55);
            this.buttonGrarLlamada.TabIndex = 0;
            this.buttonGrarLlamada.Text = "Generar Llamada";
            this.buttonGrarLlamada.UseVisualStyleBackColor = true;
            this.buttonGrarLlamada.Click += new System.EventHandler(this.buttonGrarLlamada_Click);
            // 
            // buttonFactTotal
            // 
            this.buttonFactTotal.Location = new System.Drawing.Point(11, 73);
            this.buttonFactTotal.Name = "buttonFactTotal";
            this.buttonFactTotal.Size = new System.Drawing.Size(242, 55);
            this.buttonFactTotal.TabIndex = 0;
            this.buttonFactTotal.Text = "Facturacion Total";
            this.buttonFactTotal.UseVisualStyleBackColor = true;
            this.buttonFactTotal.Click += new System.EventHandler(this.buttonFactTotal_Click);
            // 
            // buttonFacLocal
            // 
            this.buttonFacLocal.Location = new System.Drawing.Point(11, 134);
            this.buttonFacLocal.Name = "buttonFacLocal";
            this.buttonFacLocal.Size = new System.Drawing.Size(242, 55);
            this.buttonFacLocal.TabIndex = 0;
            this.buttonFacLocal.Text = "Facturacion Local";
            this.buttonFacLocal.UseVisualStyleBackColor = true;
            this.buttonFacLocal.Click += new System.EventHandler(this.buttonFacLocal_Click);
            // 
            // buttonFactProvincial
            // 
            this.buttonFactProvincial.Location = new System.Drawing.Point(11, 195);
            this.buttonFactProvincial.Name = "buttonFactProvincial";
            this.buttonFactProvincial.Size = new System.Drawing.Size(242, 55);
            this.buttonFactProvincial.TabIndex = 0;
            this.buttonFactProvincial.Text = "Facturacion Provincial";
            this.buttonFactProvincial.UseVisualStyleBackColor = true;
            this.buttonFactProvincial.Click += new System.EventHandler(this.buttonFactProvincial_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(11, 256);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(242, 55);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 324);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonFactProvincial);
            this.Controls.Add(this.buttonFacLocal);
            this.Controls.Add(this.buttonFactTotal);
            this.Controls.Add(this.buttonGrarLlamada);
            this.Name = "frmMenu";
            this.Text = "Central Telefónica";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGrarLlamada;
        private System.Windows.Forms.Button buttonFactTotal;
        private System.Windows.Forms.Button buttonFacLocal;
        private System.Windows.Forms.Button buttonFactProvincial;
        private System.Windows.Forms.Button buttonSalir;
    }
}