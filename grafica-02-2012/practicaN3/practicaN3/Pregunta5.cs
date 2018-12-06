using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta5
    {
        private float[][] c = new float[][] { new float[]{0.0f, 0.0f, 0.0f},  // 0
                                              new float[]{0.2f, 0.2f, 0.2f},  // 1
                                              new float[]{0.4f, 0.4f, 0.4f},  // 2
                                              new float[]{0.6f, 0.6f, 0.6f},  // 3
                                              new float[]{0.8f, 0.8f, 0.8f},  // 4
                                              new float[]{1.0f, 1.0f, 1.0f},  // 5
                                              new float[]{0.8f, 0.8f, 0.8f},  // 6 
                                              new float[]{0.6f, 0.6f, 0.6f},  // 7
                                              new float[]{0.4f, 0.4f, 0.4f},  // 8
                                              new float[]{0.2f, 0.2f, 0.2f},  // 9 
                                              new float[]{0.0f, 0.0f, 0.0f}   // 10
                                            };

        public void dibujar()
        {
            Gl.glTranslatef(10, 10, 0);

            int i = -1, j;
            float x, y = 0.85f;

            while (++i < 6)
            {
                x = -0.85f;
                j = -1;

                while (++j < 6)
                {
                    Gl.glLoadIdentity();
                    Gl.glScaled(0.3f, 0.3f, 0);
                    Gl.glTranslated(x, y, 0);
                    cuadrado(c[i + j]);
                    x += 0.33f;
                }

                y -= 0.33f;
            }
        }

        private void cuadrado(float[] color)
        {
            Gl.glScalef(0.33f, 0.33f, 0);
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
