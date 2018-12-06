using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;

namespace Tarea3_preg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glColor3f(1.0f, 1.0f, 0.0f);

            Gl.glPushMatrix();
            figureBase();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
                Gl.glPushMatrix();
                Gl.glTranslatef(-0.58f, 0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.58f, 0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.58f, -0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-0.58f, -0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glPushMatrix();
                Gl.glTranslatef(-0.58f, 0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.58f, 0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.58f, -0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-0.58f, -0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
                Gl.glRotatef(120, 0.0f, 0.0f, 1.0f);
                Gl.glPushMatrix();
                Gl.glTranslatef(-0.58f, 0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.58f, 0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0.58f, -0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-0.58f, -0.58f, 0.0f);
                Gl.glRotatef(60, 0.0f, 0.0f, 1.0f);
                Gl.glScalef(1 / 6.0f, 1 / 6.0f, 0.0f);
                figureBase();
                Gl.glPopMatrix();
            Gl.glPopMatrix();
        }

        private void figureBase()
        {
            Gl.glPushMatrix();
            triangle();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glRotatef(180, 0.0f, 0.0f, 1.0f);
            triangle();
            Gl.glPopMatrix();
        }

        private void triangle()
        {
            Gl.glBegin(Gl.GL_TRIANGLES);
            for (int i = 0; i < 360; i += 120)
            {
                float angle = i * (float)Math.PI / 180.0f;
                float x = (float) Math.Sin(angle);
                float y = (float) Math.Cos(angle);
                Gl.glVertex2f(x, y);
            }
            
            //Gl.glVertex2f(0.0f, 1.0f);
            //Gl.glVertex2f(1.0f, -0.5f);
            //Gl.glVertex2f(-1.0f, -0.5f);
            Gl.glEnd();
        }

    }
}
