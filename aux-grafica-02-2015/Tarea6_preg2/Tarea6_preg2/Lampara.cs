using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;
using Tao.FreeGlut;

namespace Tarea6_preg2
{
    public class Lampara
    {
        public void dibujar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(-5.0f, .0f, 0.0f);
            cuerpo();
            Gl.glPopMatrix();


            float[] grey = { 1.75f, .75f, 1.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey);
            // base
            //Gl.glColor3f(.0f, .0f, 1.0f);
            Gl.glPushMatrix();
            Gl.glRotatef(-90, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, -11.0f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(40.0f, 0.0f, 40.0f);
            Gl.glVertex3f(-40.0f, 0.0f, 40.0f);
            Gl.glVertex3f(-40.0f, 0.0f, -40.0f);
            Gl.glVertex3f(40.0f, 0.0f, -40.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            float[] grey1 = { 1.75f, 1.75f, .75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey1);
            // base
            Gl.glPushMatrix();
            Gl.glTranslatef(4.0f, -8.0f, 5.0f);
            Glut.glutSolidSphere(1, 32, 32);

            Gl.glTranslatef(5.0f, 0.0f, .0f);
            Glut.glutSolidSphere(1, 32, 32);

            Gl.glTranslatef(.0f, 0.0f, 5.0f);
            Glut.glutSolidSphere(1, 32, 32);

            Gl.glTranslatef(-10.0f, 0.0f, .0f);
            Glut.glutSolidSphere(1, 32, 32);
            Gl.glPopMatrix();
        }

        private void cuerpo()
        {
            float[] grey = { 1.75f, 1.75f, 0.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey);

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, -10.0f, 0.0f);
            Gl.glRotatef(-120, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 10, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.8f, 8.5f, 6.0f);
            Gl.glRotatef(140, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 14, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-0.8f, 8.5f, 6.0f);
            Gl.glRotatef(140, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(0.4f, 14, 32, 32);
            Gl.glPopMatrix();

            float[] grey3 = { .75f, 1.75f, 0.75f, 1.0f };
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey3);
            // rotacion arriba
            Gl.glPushMatrix();
            Gl.glTranslatef(-1.25f, 8.5f, 6.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.8f, 2.5f, 32, 32);
            Gl.glPopMatrix();

            // rotacion medio
            Gl.glPushMatrix();
            Gl.glTranslatef(-1.25f, -.8f, -5.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.8f, 2.5f, 32, 32);
            Gl.glPopMatrix();

            // rotacion base
            Gl.glPushMatrix();
            Gl.glTranslatef(-1.25f, -10f, 0.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidCylinder(0.8f, 2.5f, 32, 32);
            Gl.glPopMatrix();

            // base
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, -15f, 0.0f);
            Gl.glRotatef(90, 0.0f, 1.0f, 0.0f);
            Glut.glutSolidSphere(5, 32, 32);
            Gl.glPopMatrix();

            // rotacion lampara
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 10.5f, 7.0f);
            Gl.glRotatef(80, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCylinder(1.2f, 3f, 32, 32);
            Gl.glPopMatrix();
            
            // lamparita de la lampara jejeje
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 6f, 7.8f);
            Gl.glRotatef(263, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCone(3, 4, 32, 32);
            Gl.glPopMatrix();
        }

    }
}
