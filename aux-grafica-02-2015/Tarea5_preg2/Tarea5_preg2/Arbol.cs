using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tarea5_preg2
{
    public class Arbol
    {
        private int ramasId;
        private int troncoId;

        public Arbol()
        {
            Textura.cargarTexturas(@"hojas.png", out ramasId);
            Textura.cargarTexturas(@"tronco.png", out troncoId);
        }

        public void dibujar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(-1.0f, -1.50f, 0.0f);
            Gl.glScalef(0.5f, 0.5f, 0.5f);
            arbol();
            Gl.glPopMatrix();
        }

        private void arbol()
        {
            Gl.glPushMatrix();
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glRotatef(-90, 1.0f, 0.0f, 0.0f);
            
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ramasId);
            Glu.GLUquadric h1 = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(h1, ramasId);
            Glu.gluCylinder(h1, 2f, 0, 3f, 16, 16);
            //Glut.glutSolidCone(2, 3, 32, 32);
            Gl.glTranslatef(0.0f, 0.0f, -1.0f);
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            Gl.glRotatef(45, 0.0f, 0.0f, 1.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ramasId);
            Glu.GLUquadric h3 = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(h3, ramasId);
            Glu.gluCylinder(h3, 2.2f, 0, 3.2f, 16, 16);
            //Glut.glutSolidCone(2.2f, 3.2f, 32, 32);
            Gl.glDisable(Gl.GL_TEXTURE_2D);

            Gl.glTranslatef(0.0f, 0.0f, -1.0f);
            Gl.glRotatef(45, 0.0f, 0.0f, 1.0f);

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ramasId);
            Glu.GLUquadric obj = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(obj, ramasId);
            Glu.gluCylinder(obj, 2.4f, 0, 3.4f,16, 16);
            //Glut.glutSolidCone(2.4f, 3.4f, 32, 32);
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            //Glut.glutSolidCone(1, 5, 32, 32);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, troncoId);
            Gl.glRotatef(90, 1.0f, 0.0f, 0.0f);
            Glu.GLUquadric t = Glu.gluNewQuadric();
            Glu.gluQuadricTexture(t, ramasId);
            Glu.gluCylinder(t, 0.7f, 0.7f, 5, 16, 16);
            //Glut.glutSolidCylinder(0.7f, 5, 16, 16);
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();
        }

    }
}
