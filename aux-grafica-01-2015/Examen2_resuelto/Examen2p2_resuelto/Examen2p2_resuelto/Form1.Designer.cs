namespace Examen2p2_resuelto
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtDp = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtBp = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(399, 176);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtDp
            // 
            this.txtDp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDp.Enabled = false;
            this.txtDp.Location = new System.Drawing.Point(454, 121);
            this.txtDp.Name = "txtDp";
            this.txtDp.Size = new System.Drawing.Size(65, 20);
            this.txtDp.TabIndex = 27;
            // 
            // txtCp
            // 
            this.txtCp.BackColor = System.Drawing.Color.Blue;
            this.txtCp.Enabled = false;
            this.txtCp.Location = new System.Drawing.Point(454, 93);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(65, 20);
            this.txtCp.TabIndex = 26;
            // 
            // txtBp
            // 
            this.txtBp.BackColor = System.Drawing.Color.Yellow;
            this.txtBp.Enabled = false;
            this.txtBp.Location = new System.Drawing.Point(454, 65);
            this.txtBp.Name = "txtBp";
            this.txtBp.Size = new System.Drawing.Size(65, 20);
            this.txtBp.TabIndex = 25;
            // 
            // txtAp
            // 
            this.txtAp.BackColor = System.Drawing.Color.Red;
            this.txtAp.Enabled = false;
            this.txtAp.Location = new System.Drawing.Point(454, 37);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(65, 20);
            this.txtAp.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "B :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "D :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "C :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "A : ";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(385, 120);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(67, 20);
            this.txtD.TabIndex = 19;
            this.txtD.Text = "40";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(385, 92);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(67, 20);
            this.txtC.TabIndex = 18;
            this.txtC.Text = "30";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(385, 64);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(67, 20);
            this.txtB.TabIndex = 17;
            this.txtB.Text = "20";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(385, 36);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(67, 20);
            this.txtA.TabIndex = 16;
            this.txtA.Text = "10";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
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
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(0, 0);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(350, 350);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 29;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 350);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtDp);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtBp);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtDp;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtBp;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
    }
}

