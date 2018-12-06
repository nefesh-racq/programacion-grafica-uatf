namespace Parcial2_2_2013
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.txtBarraRoja = new System.Windows.Forms.TextBox();
            this.txtBarraAmarilla = new System.Windows.Forms.TextBox();
            this.txtBarraVerde = new System.Windows.Forms.TextBox();
            this.txtBarraAzul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(9, 6);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(350, 350);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // txtBarraRoja
            // 
            this.txtBarraRoja.Location = new System.Drawing.Point(381, 26);
            this.txtBarraRoja.Name = "txtBarraRoja";
            this.txtBarraRoja.Size = new System.Drawing.Size(100, 20);
            this.txtBarraRoja.TabIndex = 1;
            this.txtBarraRoja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarraRoja_KeyUp);
            // 
            // txtBarraAmarilla
            // 
            this.txtBarraAmarilla.Location = new System.Drawing.Point(381, 52);
            this.txtBarraAmarilla.Name = "txtBarraAmarilla";
            this.txtBarraAmarilla.Size = new System.Drawing.Size(100, 20);
            this.txtBarraAmarilla.TabIndex = 2;
            this.txtBarraAmarilla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarraAmarilla_KeyUp);
            // 
            // txtBarraVerde
            // 
            this.txtBarraVerde.Location = new System.Drawing.Point(381, 78);
            this.txtBarraVerde.Name = "txtBarraVerde";
            this.txtBarraVerde.Size = new System.Drawing.Size(100, 20);
            this.txtBarraVerde.TabIndex = 3;
            // 
            // txtBarraAzul
            // 
            this.txtBarraAzul.Location = new System.Drawing.Point(381, 104);
            this.txtBarraAzul.Name = "txtBarraAzul";
            this.txtBarraAzul.Size = new System.Drawing.Size(100, 20);
            this.txtBarraAzul.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 368);
            this.Controls.Add(this.txtBarraAzul);
            this.Controls.Add(this.txtBarraVerde);
            this.Controls.Add(this.txtBarraAmarilla);
            this.Controls.Add(this.txtBarraRoja);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.TextBox txtBarraRoja;
        private System.Windows.Forms.TextBox txtBarraAmarilla;
        private System.Windows.Forms.TextBox txtBarraVerde;
        private System.Windows.Forms.TextBox txtBarraAzul;
    }
}

