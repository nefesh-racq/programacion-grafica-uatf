using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tarea5_preg2
{
    public class Esfera
    {
        private int caja_id;
        private int caja_base_id;
        private int esfera_id;

        public Esfera()
        {
            Textura.cargarTexturas(@"caja.png", out caja_id);
            Textura.cargarTexturas(@"caja_base.png", out caja_base_id);
            Textura.cargarTexturas(@"esfera6.png", out esfera_id);
        }

        public void dibujar()
        {

            float tam = 3.2f;

            //Gl.glColor4f(0.5f, 0.50f, 0.50f, 1.0f);
            //Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            //Glut.glutSolidTeapot(1);


            Gl.glColor4f(1.0f, 1.0f, 1.0f, 1.0f);
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, -0.5f, 0.0f);
            // frente
            Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            Gl.glTranslatef(0.0f, 0.0f, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, caja_id);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -4f, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -4f, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // atras
            Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, caja_id);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -4f, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -4f, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // izquierda
            Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, caja_id);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -4f, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -4f, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // derecha
            Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            Gl.glRotatef(-90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, caja_id);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, -2.0f, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -4f, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -4f, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // base
            Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, caja_base_id);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 1.0f, 0.0f);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -2.0f, tam);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, -2.0f, -tam);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, -2.0f, -tam);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -2.0f, tam);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();
            Gl.glPopMatrix();


            Gl.glColor4f(1f, 1f, 1.0f, 0.15f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, esfera_id);
            Glu.GLUquadric obj = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(obj, esfera_id);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Glu.gluSphere(obj, 4, 32, 32);
            //Glut.glutSolidSphere(4, 32, 32);
            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }

    }
}
