using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea5_preg2
{
    public class Fondo
    {
        public Fondo()
        {
        }

        public void dibujar()
        {
            float tam = 10;
            //// frente
            //Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            //Gl.glTranslatef(0.0f, 0.0f, tam);
            //Gl.glBegin(Gl.GL_POLYGON);
            //Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            //Gl.glVertex3f(10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, -10.0f, 0.0f);
            //Gl.glVertex3f(1.0f, -10.0f, 0.0f);
            //Gl.glEnd();
            //Gl.glPopMatrix();

            // atras
            Gl.glPushMatrix();
            Gl.glColor4f(0.0f, 0.2f, 0.0f, 1.0f);
            //Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, -10);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(10.0f, 10.0f, 0.0f);
            Gl.glVertex3f(-10.0f, 10.0f, 0.0f);
            Gl.glVertex3f(-10.0f, -10.0f, 0.0f);
            Gl.glVertex3f(10.0f, -10.0f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            // izquierda
            Gl.glPushMatrix();
//            Gl.glColor4f(0.0f, 0.0f, .3f, 1.0f);
            Gl.glRotatef(-90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, -10);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(10.0f, 10.0f, 0.0f);
            Gl.glVertex3f(-10.0f, 10.0f, 0.0f);
            Gl.glVertex3f(-10.0f, -10.0f, 0.0f);
            Gl.glVertex3f(10.0f, -10.0f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            //// derecha
            //Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            //Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            //Gl.glTranslatef(0.0f, 0.0f, -10);
            //Gl.glBegin(Gl.GL_POLYGON);
            //Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            //Gl.glVertex3f(10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, -10.0f, 0.0f);
            //Gl.glVertex3f(10.0f, -10.0f, 0.0f);
            //Gl.glEnd();
            //Gl.glPopMatrix();

            //// base
            //Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            //Gl.glRotatef(-90, 1.0f, 0.0f, 0.0f);
            //Gl.glTranslatef(0.0f, 0.0f, -10);
            //Gl.glBegin(Gl.GL_POLYGON);
            //Gl.glNormal3f(0.0f, 0.0f, -1.0f);
            //Gl.glVertex3f(10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, -10.0f, 0.0f);
            //Gl.glVertex3f(10.0f, -10.0f, 0.0f);
            //Gl.glEnd();
            //Gl.glPopMatrix();
            //Gl.glPopMatrix();

            //// base
            //Gl.glPushMatrix();
            //Gl.glColor4f(1.0f, 1.0f, 0.0f, 1.0f);
            //Gl.glRotatef(90, 1.0f, 0.0f, 0.0f);
            //Gl.glTranslatef(0.0f, 0.0f, -10);
            //Gl.glBegin(Gl.GL_POLYGON);
            //Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            //Gl.glVertex3f(10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, 10.0f, 0.0f);
            //Gl.glVertex3f(-10.0f, -10.0f, 0.0f);
            //Gl.glVertex3f(10.0f, -10.0f, 0.0f);
            //Gl.glEnd();
            //Gl.glPopMatrix();
            //Gl.glPopMatrix();
        }

    }
}
