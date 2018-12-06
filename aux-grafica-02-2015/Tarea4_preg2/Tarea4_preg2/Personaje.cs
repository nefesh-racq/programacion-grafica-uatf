using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea4_preg2
{
    public class Personaje
    {
        private float mMuslo;
        private float mPie1;
        private float mPie2;

        public Personaje()
        {
            mMuslo = 0;
            mPie1 = 0;
            mPie2 = 0;
        }

        public void dibujar()
        {
            // movimiento del brazo
            Gl.glPushMatrix();
                Gl.glPushMatrix();
                Gl.glTranslatef(0.0f, 0.55f, 0.0f);
                Gl.glRotatef(mMuslo, 0.0f, 0.0f, 1.0f);
                anteBrazo();
                //Gl.glPopMatrix();

                //Gl.glPushMatrix();
                Gl.glTranslatef(0.0f, -0.33f, 0.0f);
                Gl.glRotatef(-45, 0.0f, 0.0f, 1.0f);
                brazo();
                Gl.glPopMatrix();
                Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.7f, 0.0f);
            cabeza();
            Gl.glPopMatrix();


            // movimiento del pie
            Gl.glPushMatrix();
                Gl.glRotatef(-mMuslo, 0.0f, 0.0f, 1.0f);
                Gl.glPushMatrix();
                muslo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.0f, -0.4f, 0.0f);
                Gl.glRotatef(mPie1, 0.0f, 0.0f, 1.0f);
                pie();
                Gl.glTranslatef(0.0f, -0.4f, 0.0f);
                antePie();
                Gl.glPopMatrix();
            Gl.glPopMatrix();

            // tronco del cuerpo
            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.3f, 0.0f);
            tronco();
            Gl.glPopMatrix();

            // movimiento del pie segundo
            Gl.glPushMatrix();
                Gl.glRotatef(mMuslo, 0.0f, 0.0f, 1.0f);
                Gl.glPushMatrix();
                muslo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.0f, -0.4f, 0.0f);
                Gl.glRotatef(mPie2, 0.0f, 0.0f, 1.0f);
                pie();
                Gl.glTranslatef(0.0f, -0.4f, 0.0f);
                antePie();
                Gl.glPopMatrix();
            Gl.glPopMatrix();

            // movimiento del brazo segundo
            Gl.glPushMatrix();
                Gl.glPushMatrix();
                Gl.glTranslatef(0.0f, 0.55f, 0.0f);
                Gl.glRotatef(-mMuslo, 0.0f, 0.0f, 1.0f);
                anteBrazo();
                //Gl.glPopMatrix();

                //Gl.glPushMatrix();
                Gl.glTranslatef(0.0f, -0.33f, 0.0f);
                Gl.glRotatef(-45, 0.0f, 0.0f, 1.0f);
                brazo();
                Gl.glPopMatrix();
                Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.7f, 0.0f);
            cabeza();
            Gl.glPopMatrix();
        }

        private float incM = 5;
        private float incP1 = 5f;
        private float incP2 = 5f;

        public void mover()
        {
            mMuslo += incM;

            if (mMuslo < -45 || mMuslo > 45)
                incM = -incM;

            // movimiento del antepie
            mPie1 += incP1;

            if (mPie1 < .45 || mPie1 > 45)
                incP1 = -incP1;

            mPie2 += incP2;

            if (mPie2 < .45 || mPie2 > 45)
                incP2 = -incP2;
        }

        private void cabeza()
        {
            float x, y, angulo;
            float tam = 0.1f;

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
            for (int i = 0; i < 361; i++)
            {
                angulo = i*(float) Math.PI/180.0f;
                x = (float)Math.Cos(angulo) * tam;
                y = (float)Math.Sin(angulo) * tam;

                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
        }

        private void tronco()
        {
            Gl.glColor3f(0.0f, 0.4f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.0f, 0.35f);
                Gl.glVertex2f(-0.1f, 0.0f);
                Gl.glVertex2f(0.0f, -0.35f);
                Gl.glVertex2f(0.1f, 0.0f);
            Gl.glEnd();
        }

        private void muslo()
        {
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.08f, 0.0f);
                Gl.glVertex2f(-0.08f, 0.0f);
                Gl.glVertex2f(0.0f, -0.5f);
            Gl.glEnd();
        }

        private void pie()
        {
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.07f, 0.0f);
                Gl.glVertex2f(-0.07f, 0.0f);
                Gl.glVertex2f(0.0f, -0.5f);
            Gl.glEnd();
        }

        private void antePie()
        {
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.0f, 0.00f);
                Gl.glVertex2f(-0.26f, -0.15f);
                Gl.glVertex2f(0.06f, -0.15f);
            Gl.glEnd();
        }

        private void anteBrazo()
        {
            Gl.glColor3f(0.0f, 1.0f, 1.0f);
                Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.08f, 0.0f);
                Gl.glVertex2f(-0.08f, 0.0f);
                Gl.glVertex2f(0.0f, -0.4f);
            Gl.glEnd();
        }

        private void brazo()
        {
            Gl.glColor3f(1.0f, 0.0f, 1.0f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.07f, 0.0f);
                Gl.glVertex2f(-0.07f, 0.0f);
                Gl.glVertex2f(0.0f, -0.4f);
            Gl.glEnd();
        }

    }
}

