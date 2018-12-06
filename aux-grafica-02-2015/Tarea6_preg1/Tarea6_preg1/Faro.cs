using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;
using Tao.FreeGlut;

namespace Tarea6_preg1
{
    class Faro
    {
        private float angulo;

        public Faro()
        {
            angulo = 0;
        }

        private void material()
        {

        }


        public void dibujar()
        {


            float[] grey = { 1.75f, 0.75f, 0.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey);
            Gl.glPushMatrix();
            figura();
            Gl.glPopMatrix();


            float[] grey1 = { 0.75f, 0.75f, 1.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey1);
            Gl.glPushMatrix();
            Gl.glTranslatef(-8.0f, 0.0f, 0.0f);
            //Gl.glRotatef(45.0f, 1.0f, 1.0f, 0.0f);
            figura();
            Gl.glPopMatrix();

            float[] grey2 = { 1.75f, 0.75f, 1.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey2);
            Gl.glPushMatrix();
            Gl.glTranslatef(-4.0f, 6.0f, 0.0f);
            //Gl.glRotatef(45.0f, 1.0f, 1.0f, 0.0f);
            figura();
            Gl.glPopMatrix();

            float[] grey3 = { 1.75f, 1.75f, 0.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey3);
            Gl.glPushMatrix();
            Gl.glTranslatef(-4.0f, 0.0f, -6.0f);
            //Gl.glRotatef(45.0f, 1.0f, 1.0f, 0.0f);
            figura();
            Gl.glPopMatrix();


            float[] grey4 = { 0.75f, 1.75f, 1.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey4);
            Gl.glPushMatrix();
            Gl.glTranslatef(-4.0f, 0.0f, 6.0f);
            //Gl.glRotatef(45.0f, 1.0f, 1.0f, 0.0f);
            figura();
            Gl.glPopMatrix();


            float[] grey5 = { 1.75f, 1.75f, 1.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey5);
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.0f, -11.0f);
            Gl.glRotatef(45.0f, 1.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 1.6f, 0.0f);
            figura();
            Gl.glPopMatrix();

            float[] grey6 = { 0.0f, .0f, 0.7f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey6);
            //Gl.glColor3f(1.0f, 1.0f, 1.0f);
            // base
            //Gl.glColor3f(.0f, .0f, 1.0f);
            Gl.glPushMatrix();
            //Gl.glRotatef(-90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, -6.0f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(20.0f, 0.0f, 20.0f);
            Gl.glVertex3f(-20.0f, 0.0f, 20.0f);
            Gl.glVertex3f(-20.0f, 0.0f, -20.0f);
            Gl.glVertex3f(20.0f, 0.0f, -20.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //Gl.glTranslatef(0.0f, 2.1f, 0.0f);
            //Gl.glRotatef(angulo, 0.0f, 1.0f, 0.0f);
            //cabeza();
            //Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //cuerpo();
            //Gl.glPopMatrix();
        }

        private void figura()
        {
            Gl.glColor3f(1.0f, 1.0f, 15.0f);

            Gl.glPushMatrix();
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();
            
            Gl.glPushMatrix();
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glRotatef(90, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, -5f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, -5f, 0.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            // gfjgjdag
            Gl.glPushMatrix();
            Gl.glTranslatef(5f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.0f, 5.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            // gfjgjdag
            Gl.glPushMatrix();
            Gl.glTranslatef(5f, -5.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, -5.0f, 5.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            // ultimo
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.0f, 5.0f);
            Gl.glRotatef(90, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();


            Gl.glPushMatrix();
            Gl.glTranslatef(5.0f, 0.0f, 0.0f);
            Gl.glRotatef(90, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(5.0f, 0.0f, 5.0f);
            Gl.glRotatef(90, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 5, 32, 32);
            Gl.glPopMatrix();


            // bolitas
            Gl.glPushMatrix();
            Gl.glTranslatef(5.0f, 0.0f, 5.0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            //Gl.glTranslatef(5.0f, 0.0f, 5.0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(.0f, 0.0f, 5.0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(5.0f, 0.0f, .0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(.0f, -5.0f, .0f);
            Gl.glTranslatef(5.0f, 0.0f, 5.0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(.0f, -5.0f, .0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(.0f, -5.0f, .0f);
            Gl.glTranslatef(.0f, 0.0f, 5.0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(.0f, -5.0f, .0f);
            Gl.glTranslatef(5.0f, 0.0f, .0f);
            Glut.glutSolidSphere(0.7f, 32, 32);
            Gl.glPopMatrix();
        }

        private void cabeza()
        {
            // frente
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.0f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, -.50f, 0.0f);
            Gl.glVertex3f(0.5f, -.50f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();


            // derecha
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glPushMatrix();
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, -.50f, 0.0f);
            Gl.glVertex3f(0.5f, -.50f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            // atras
            Gl.glColor3f(1.0f, .0f, 1.0f);
            Gl.glPushMatrix();
            Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, -.50f, 0.0f);
            Gl.glVertex3f(0.5f, -.50f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            // izuierda
            Gl.glColor3f(.0f, .0f, 1.0f);
            Gl.glPushMatrix();
            Gl.glRotatef(-90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, .50f, 0.0f);
            Gl.glVertex3f(-0.5f, -.50f, 0.0f);
            Gl.glVertex3f(0.5f, -.50f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();
        }

        private void cuerpo()
        {
            // frente
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.0f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.7f, -1.50f, 0.20f);
                Gl.glVertex3f(0.7f, -1.50f, 0.20f);
            Gl.glEnd();
            Gl.glPopMatrix();


            // derecha
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glPushMatrix();
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.7f, -1.50f, 0.20f);
                Gl.glVertex3f(0.7f, -1.50f, 0.20f);
            Gl.glEnd();
            Gl.glPopMatrix();

            // atras
            Gl.glColor3f(1.0f, .0f, 1.0f);
            Gl.glPushMatrix();
                Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
                Gl.glTranslatef(0.0f, 0.0f, 0.5f);
                Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.7f, -1.50f, 0.20f);
                Gl.glVertex3f(0.7f, -1.50f, 0.20f);
            Gl.glEnd();
            Gl.glPopMatrix();

            // izuierda
            Gl.glColor3f(.0f, .0f, 1.0f);
            Gl.glPushMatrix();
                Gl.glRotatef(-90, 0.0f, 1.0f, 0.0f);
                Gl.glTranslatef(0.0f, 0.0f, 0.5f);
                Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.5f, 1.50f, 0.0f);
                Gl.glVertex3f(-0.7f, -1.50f, 0.20f);
                Gl.glVertex3f(0.7f, -1.50f, 0.20f);
            Gl.glEnd();
            Gl.glPopMatrix();
        }

        public void girar()
        {
            angulo += 5;

            if (angulo > 360)
                angulo = 0;
        }

    }

}
