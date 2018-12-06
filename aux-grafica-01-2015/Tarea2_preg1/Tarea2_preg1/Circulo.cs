using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Tarea2_preg1
{
    public class Circulo
    {
        public Punto punto;
        public Color color;
        public float radio;

        public Circulo()
        {
            punto = new Punto(0, 0);
            color = new Color(1, 1, 1);
            radio = 1;
        }

        public Circulo(Punto punto, Color color, float radio)
        {
            this.punto = punto;
            this.color = color;
            this.radio = radio;
        }


        public void Dibujar()
        {
            float angulo;
            float x, y;

            Gl.glColor3f(color.rojo, color.verde, color.azul);
            Gl.glBegin(Gl.GL_POLYGON);

            for (int i = 0; i < 360; i++)
            {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo) * radio;
                y = (float)Math.Sin(angulo) * radio;

                Gl.glVertex2f((x + punto.x) , (y + punto.y) );
            }

            Gl.glEnd();
        }

    }
}
