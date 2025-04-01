namespace Rectangulos
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
            this.txtCoordenadaX = new System.Windows.Forms.TextBox();
            this.txtCoordenadaY = new System.Windows.Forms.TextBox();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCoordenadaX
            // 
            this.txtCoordenadaX.Location = new System.Drawing.Point(98, 80);
            this.txtCoordenadaX.Name = "txtCoordenadaX";
            this.txtCoordenadaX.Size = new System.Drawing.Size(139, 26);
            this.txtCoordenadaX.TabIndex = 0;
            this.txtCoordenadaX.Text = "Coordenada X";
            // 
            // txtCoordenadaY
            // 
            this.txtCoordenadaY.Location = new System.Drawing.Point(98, 171);
            this.txtCoordenadaY.Name = "txtCoordenadaY";
            this.txtCoordenadaY.Size = new System.Drawing.Size(139, 26);
            this.txtCoordenadaY.TabIndex = 1;
            this.txtCoordenadaY.Text = "Coordenada Y";
            // 
            // picColor
            // 
            this.picColor.Location = new System.Drawing.Point(238, 261);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(89, 103);
            this.picColor.TabIndex = 3;
            this.picColor.TabStop = false;
            this.picColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Indigo;
            this.btnCrear.Location = new System.Drawing.Point(97, 249);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(135, 39);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelDibujo.Location = new System.Drawing.Point(374, 74);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(347, 345);
            this.panelDibujo.TabIndex = 5;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Indigo;
            this.lblContador.Location = new System.Drawing.Point(33, 343);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(96, 38);
            this.lblContador.TabIndex = 6;
            this.lblContador.Text = "label1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Indigo;
            this.btnLimpiar.Location = new System.Drawing.Point(479, 444);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 39);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Panel";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(213, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Creación de rectangulos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.txtCoordenadaY);
            this.Controls.Add(this.txtCoordenadaX);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoordenadaX;
        private System.Windows.Forms.TextBox txtCoordenadaY;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}

