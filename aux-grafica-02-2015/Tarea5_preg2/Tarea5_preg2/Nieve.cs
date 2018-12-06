using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Tao.OpenGl;
using Tao.FreeGlut;

namespace Tarea5_preg2
{
    public class Nieve
    {
        private float cx, cy, cz;
        private Random ran;

        public Nieve()
        {
            ran = new Random();
            cx = cy = cz = 0;
        }

        public Nieve(Random r)
        {
            ran = r;
            cx = ran.Next(-35, 35) / 10.0f;
            cy = ran.Next(-35, 35) / 10.0f;
            cz = ran.Next(-35, 35) / 10.0f;
        }

        public void dibujar()
        {
            float ec = (float) Math.Pow(cx, 2) + (float) Math.Pow(cy, 2) + (float) Math.Pow(cz, 2);
            if (ec > -16f && ec < 16f)
            {
                Gl.glPushMatrix();
                Gl.glTranslatef(cx, cy, cz);
                Gl.glColor3f(1.0f, 1.0f, 1.0f);
                Glut.glutSolidSphere(0.05f, 14, 14);
                Gl.glPopMatrix();
            }
        }

        public void caer()
        {
            // funcion de coseno
            cy -= 0.05f;
            cx += (float) Math.Cos(cy*10)/100;

            if (cy < -3.5f)
            {
                cy = 4f; //ran.Next(-40, 40) / 10.0f;
                cx = ran.Next(-35, 35) / 10.0f;
                cz = ran.Next(-35, 35) / 10.0f;
            }
        }

    }
}
