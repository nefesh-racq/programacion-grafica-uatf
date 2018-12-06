using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;

namespace Tarea5_preg1
{
    public partial class Form1 : Form
    {
        private int piso = 0;
        private int pared = 0;
        private int pared1 = 0;
        private int techo = 0;
        private int escalona = 0;
        private int escalonb = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(60, 1, 0, 100);

            cargarTexturas(@"piso.jpg", out piso);
            cargarTexturas(@"pared3.jpg", out pared);
            cargarTexturas(@"pared1.jpg", out pared1);
            cargarTexturas(@"pared3.jpg", out techo);
            cargarTexturas(@"escalonb.png", out escalona);
            cargarTexturas(@"escalona.jpg", out escalonb);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Glu.gluLookAt(20, 5, 20, 0, 0, 0, 0, 1, 0);
            //Glu.gluLookAt(0, 0, 30, 0, 0, 0, 0, 1, 0);
            Gl.glEnable(Gl.GL_CULL_FACE);

            Cuarto();

            CentroCuarto();
            Gl.glPushMatrix();
            Gl.glTranslatef(-2, -2f, 0);
            Escalera();
            Gl.glPopMatrix();
        }

        private void Television()
        {

        }


        private void Cuarto()
        {
            #region "cuarto"
            // piso
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, piso);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(20, -10, -20);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(-20, -10, -20);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-20, -10, 20);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(20, -10, 20);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);


            // techo
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, techo);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(20, 10, 20);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(-20, 10, 20);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-20, 10, -20);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(20, 10, -20);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);


            // pared
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, pared);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(20, -10, -20);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(20, 10, -20);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-20, 10, -20);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(-20, -10, -20);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);


            // pared
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, pared);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(-20, -10, -20);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(-20, 10, -20);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-20, 10, 20);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(-20, -10, 20);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            // pared
            //Gl.glColor3f(1, 0, 1);
            //Gl.glBegin(Gl.GL_QUADS);
            //    Gl.glVertex3f(20, -10, 20);
            //    Gl.glVertex3f(20, 10, 20);
            //    Gl.glVertex3f(20, 10, -20);
            //    Gl.glVertex3f(20, -10, -20);
            //Gl.glEnd();
            #endregion
        }


        private void CentroCuarto()
        {
            #region "cubo"
            // alto
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, pared1);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(10, 2, -10);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(-10, 2, -10);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-10, 2, 10);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(10, 2, 10);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            // frente
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, pared1);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(10, -10, 10);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(10, 2, 10);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-10, 2, 10);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(-10, -10, 10);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            // frente
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, pared1);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(10, -10, -10);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(10, 2, -10);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(10, 2, 10);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(10, -10, 10);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            #endregion
        }


        private void Escalon()
        {
            // alto
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, escalona);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(0, 1, -2);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(0, 1, 2);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(0, 0, 2);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(0, 0, -2);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);


            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, escalonb);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(0, 1, -2);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(-1, 1, -2);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-1, 1, 2);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(0, 1, 2);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

        private void Escalera()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(10, -10, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(9, -9, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(8, -8, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(7, -7, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(6, -6, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(5, -5, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(4, -4, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(3, -3, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, -2, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(1, -1, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-1, 1, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 2, 10);
            Escalon();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-3, 2, 10);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, escalonb);
            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord2d(0, 0); Gl.glVertex3f(0, 1, -2);
                Gl.glTexCoord2d(0, 1); Gl.glVertex3f(-4, 1, -2);
                Gl.glTexCoord2d(1, 1); Gl.glVertex3f(-4, 1, 2);
                Gl.glTexCoord2d(1, 0); Gl.glVertex3f(0, 1, 2);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();
        }


        /*
         * metodo para cargar las texturas, parametros el nombre del archivo y el entero para guardar sus bit
         * */
        private void cargarTexturas(string archivo, out int nuevo)
        {
            Bitmap imagen = cargarImagen(archivo);

            if (imagen != null)
            {
                //imagen.RotateFlip(RotateFlipType.RotateNoneFlipX);                                                          

                Rectangle rectangulo = new Rectangle(0, 0, imagen.Width, imagen.Height);                                                                // marco para la imagen
                BitmapData mapaDeBit = imagen.LockBits(rectangulo, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);                                 // mapa de bit para almacenar la imagen en forma de bit

                Gl.glGenTextures(1, out nuevo);                                                                                                         // reserva identificadores para las texturas
                Gl.glEnable(Gl.GL_COLOR_MATERIAL);                                                                                                      // habilita los colores del material
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, nuevo);                                                                                              // creamos el objeto textura -> nuevo
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);                                                          // definimos los parametros del texturizado
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);                                                          // definimos los parametros del texturizado
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB8, imagen.Width, imagen.Height,
                    0, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, mapaDeBit.Scan0);      // definimos la textura
            }
            else
                nuevo = 0;
        }

        /*
         * metodo cargarArchivo, instancia el objeto BitMap imagen
         * */
        private Bitmap cargarImagen(string archivo)
        {
            if (archivo == null || archivo == string.Empty) return null;
            if (!File.Exists(archivo)) return null;
            if (File.Exists(archivo)) return new Bitmap(archivo);
            return null;
        }

    }
}
