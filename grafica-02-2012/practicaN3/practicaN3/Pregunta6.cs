using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta6
    {
        public void dibujar()
        {
            cuerpo(0.05f, 0.0f, 1);  // dibuja el circulo del centro
            cuerpo(0.25f, 0.6f, 12); // dibuja los 12 circulo grandes
            cuerpo(0.03f, 0.9f, 24); // dibuja los 24 circulos pequeños
            cuerpo(0.12f, 0.2f, 4);  // dibuja los 4 cirulos del centro
            esquinas();              // dibuja las 4 esquinas jejeje    
        }

        private void circulo(float escala)
        {
            float x, y, rad;
            int grados;

            Gl.glScalef(escala, escala, 0);
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glBegin(Gl.GL_LINE_STRIP);

            for (grados = 0; grados <= 360; grados++) {
                rad = grados * (float)Math.PI / 180;
                y = (float)Math.Sin(rad);
                x = (float)Math.Cos(rad);
                Gl.glVertex2f(x, y);
            }

            Gl.glEnd();
        }

        private void esquinas()
        {
            Gl.glLoadIdentity();
            Gl.glTranslatef(-0.8f, 0.8f, 0);
            circulo(0.12f);

            Gl.glLoadIdentity();
            Gl.glTranslatef(-0.8f, -0.8f, 0);
            circulo(0.12f);

            Gl.glLoadIdentity();
            Gl.glTranslatef(0.8f, -0.8f, 0);
            circulo(0.12f);

            Gl.glLoadIdentity();
            Gl.glTranslatef(0.8f, 0.8f, 0);
            circulo(0.12f);

        }

    /***** cuerpo(float, float, int); se reutiliza para dibujar los diferentes 
     * niveles de circulos recibe como parametro la escala, el radio,
     * y la cantidad de circulos a dibujar  ******/
        private void cuerpo(float escala, float radio, int cant)
        {
            float x, y, rad, inc, grados;
            
            inc = 360 / cant;

            for (grados = 0; grados <= 360; grados += inc) {
                rad = grados * (float)Math.PI / 180;
                y = (float)Math.Sin(rad);
                x = (float)Math.Cos(rad);
                Gl.glTranslatef(x * radio, y * radio, 1);
                circulo(escala);
                Gl.glLoadIdentity();
            }
        }
    }
}
