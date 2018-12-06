using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta3
    {
        Random ran = new Random();

        private float[][] c = new float[][] { new float[]{0.0f, 0.0f, 0.0f},  // 0
                                              new float[]{0.3f, 0.3f, 0.3f},  // 1
                                              new float[]{0.6f, 0.6f, 0.6f},  // 2
                                              new float[]{1.0f, 1.0f, 1.0f},  // 3
                                            };
        private float[] tamano = new float[] { 0.01f, 0.02f, 0.03f, 0.04f, 0.05f, 0.06f,
            0.07f, 0.08f, 0.09f, 0.10f, 0.11f, 0.12f, 0.13f, 0.14f, 0.15f, 0.16f};

        public void dibujar()
        {
            int i = -1, j, color;
            float x, y = 0.85f;

            while (++i < 9)
            {
                x = -0.85f;
                j = -1;

                while (++j < 12)
                {
                    color = ran.Next(4);
                    Gl.glLoadIdentity();
                    //Gl.glScaled(0.9f, 0.9f, 0);
                    Gl.glTranslated(x, y, 0);
                    cuadrado(c[color]);
                    x += 0.16f;
                }

                y -= 0.16f;
            }
        }

        private void cuadrado(float[] color)
        {
            int dim = ran.Next(16);

            Gl.glScalef(tamano[dim], tamano[dim], 0);
            Gl.glColor3fv(color);            
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(0.5f, 0.5f);
                Gl.glVertex2f(-0.5f, 0.5f);
                Gl.glVertex2f(-0.5f, -0.5f);
                Gl.glVertex2f(0.5f, -0.5f);
            Gl.glEnd();
        }
    }
}
