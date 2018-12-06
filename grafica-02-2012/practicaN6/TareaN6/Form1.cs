using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace TareaN6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] nombres = new string[] { "img1.png", "img2.png", "img3.png", 
                                                  "img4.png", "img5.png", "img6.png", 
                                                  "img7.png", "img8.png", "img9.png"};
        private int[] imagenes = new int[9];
        private int num = 0; 

        private void cargarTextura()
        {
            Bitmap imagen = null;
            int i;

            for (i = 0; i < 9; i++) {
                try {
                    imagen = new Bitmap(nombres[i]);
                }
                catch (System.ArgumentException) {
                    MessageBox.Show("A ocurrido un error al cargar la imagen..!!");
                }

                if (imagen != null) {
                    System.Drawing.Imaging.BitmapData bitData;
                    Rectangle rect = new Rectangle(0, 0, imagen.Width, imagen.Height);
                    bitData = imagen.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Gl.glGenTextures(1, out imagenes[i]);
                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, imagenes[i]);

                    Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
                    Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);

                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, imagen.Width, imagen.Height, 0, Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitData.Scan0);

                    imagen.UnlockBits(bitData);
                    imagen.Dispose();
                }
            }
        }

        private void colocarImagenes()
        {
           Gl.glBindTexture(Gl.GL_TEXTURE_2D, imagenes[num]);
           Gl.glBegin(Gl.GL_QUADS); // despues de inicializar la textura
           Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.96f, -0.96f, 1.0f);
           Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(0.96f, -0.96f, 1.0f);
           Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(0.96f, 0.96f, 1.0f);
           Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.96f, 0.96f, 1.0f);
           Gl.glEnd();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            cargarTextura();
            num = 0;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            colocarImagenes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;

            if (num > 8)
                num = 0;

            simpleOpenGlControl1.Refresh();
        }
    }
}
