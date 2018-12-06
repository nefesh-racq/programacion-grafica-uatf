using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea5_preg2
{
    public class Casa
    {
        private int techoId;
        private int frenteId;
        private int espaldaId;
        private int costadoId;

        public Casa()
        {
            Textura.cargarTexturas(@"techo.png", out techoId);
            Textura.cargarTexturas(@"frente.png", out frenteId);
            Textura.cargarTexturas(@"espalda.png", out espaldaId);
            Textura.cargarTexturas(@"costado.png", out costadoId);
        }

        public void dibujar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(1.0f, -3.0f, 0.0f);
            casita();
            Gl.glPopMatrix();
        }

        private void casita()
        {
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.0f, 1.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, frenteId);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0.4f, 0); Gl.glVertex3f(1.0f, 1.0f, 0.0f);
            Gl.glTexCoord3f(0.5f, 0f, 0); Gl.glVertex3f(0.0f, 2.0f, 0.0f);
            Gl.glTexCoord3f(0, 0.4f, 0); Gl.glVertex3f(-1.0f, 1.0f, 0.0f);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-1.0f, 0.0f, 0.0f);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(1.0f, 0.0f, 0.0f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(0.0f, 0.0f, 1.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, espaldaId);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0.4f, 0); Gl.glVertex3f(1.0f, 1.0f, 0.0f);
            Gl.glTexCoord3f(0.5f, 0f, 0); Gl.glVertex3f(0.0f, 2.0f, 0.0f);
            Gl.glTexCoord3f(0, 0.4f, 0); Gl.glVertex3f(-1.0f, 1.0f, 0.0f);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-1.0f, 0.0f, 0.0f);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(1.0f, 0.0f, 0.0f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            //Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(1.0f, 0.0f, 0.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, costadoId);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(1.0f, 0.0f, 0.0f);
            Gl.glTexCoord3f(0, 0f, 0); Gl.glVertex3f(0.0f, 1.0f, 1.0f);
            Gl.glTexCoord3f(0, 1f, 0); Gl.glVertex3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 1f, 0); Gl.glVertex3f(0.0f, 0.0f, -1.0f);
            Gl.glTexCoord3f(1, 0f, 0); Gl.glVertex3f(0.0f, 1.0f, -1.0f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glRotatef(180, 0.0f, 1.0f, 0.0f);
            Gl.glTranslatef(1.0f, 0.0f, 0.0f);
            //Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, costadoId);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(1.0f, 0.0f, 0.0f);
            Gl.glTexCoord3f(0, 0f, 0); Gl.glVertex3f(0.0f, 1.0f, 1.0f);
            Gl.glTexCoord3f(0, 1f, 0); Gl.glVertex3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 1f, 0); Gl.glVertex3f(0.0f, 0.0f, -1.0f);
            Gl.glTexCoord3f(1, 0f, 0); Gl.glVertex3f(0.0f, 1.0f, -1.0f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, techoId);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(1.0f, 0.0f, 0.0f);
            Gl.glTexCoord3f(1, 0f, 0); Gl.glVertex3f(0.0f, 2.0f, -1.0f);
            Gl.glTexCoord3f(0, 0f, 0); Gl.glVertex3f(0.0f, 2.0f, 1.0f);
            Gl.glTexCoord3f(0, 1f, 0); Gl.glVertex3f(1.0f, 1.0f, 1.0f);
            Gl.glTexCoord3f(1, 1f, 0); Gl.glVertex3f(1.0f, 1.0f, -1.0f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, techoId);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glNormal3f(-1.0f, 0.0f, 0.0f);
            Gl.glTexCoord3f(1, 0f, 0); Gl.glVertex3f(0.0f, 2.0f, 1.0f);
            Gl.glTexCoord3f(0, 0f, 0); Gl.glVertex3f(0.0f, 2.0f, -1.0f);
            Gl.glTexCoord3f(0, 1f, 0); Gl.glVertex3f(-1.0f, 1.0f, -1.0f);
            Gl.glTexCoord3f(1, 1f, 0); Gl.glVertex3f(-1.0f, 1.0f, 1.0f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();
        }

    }
}
