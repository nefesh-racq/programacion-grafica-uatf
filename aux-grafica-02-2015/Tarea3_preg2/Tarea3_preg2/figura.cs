using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Tarea3_preg2
{
    public class figura
    {
        private float px, py;
        private Random rand;
        private float r, g, b;
        private float angle = 0;
        private float inc = 1;
        private float scale = 1;

        public figura(Random rd)
        {
            rand = rd;
            px = rand.Next(-100, 100) / 10.0f;
            py = rand.Next(-100, 100) / 10.0f;
            r = rand.Next(-100, 100) / 10.0f;
            g = rand.Next(-100, 100) / 10.0f;
            b = rand.Next(-100, 100) / 10.0f;
            scale = rand.Next(5, 15)/10.0f;

            if (rand.Next(1, 100) < 50)
                inc = -1;
            else
                inc = 1;
        }

        public void draw()
        {
            Gl.glColor3f(r, g, b);
            Gl.glTranslatef(0.0f, py, 0.0f);
            Gl.glPushMatrix();
            Gl.glTranslatef(px, 0.0f, 0.0f);
            Gl.glRotatef(angle, 0.0f, 0.0f, 1.0f);
            Gl.glScalef(scale, scale, 0.0f);
//            Gl.glRotatef(1, 0.0f, 0.0f, 1.0f);
                figureBase();
            Gl.glPopMatrix();
        }

        public void setPx(float px)
        {
            this.px = px;
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
                float x = (float)Math.Sin(angle);
                float y = (float)Math.Cos(angle);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
        }

        public void caer()
        {
            py -= 0.1f;
            angle += inc;

            if (py < -10)
            {
                py = 10;
                px = rand.Next(-100, 100) / 10.0f;
                r = rand.Next(-100, 100) / 10.0f;
                g = rand.Next(-100, 100) / 10.0f;
                b = rand.Next(-100, 100) / 10.0f;
                angle = 0;
                this.py = 10;// r.Next(0, 100) / 10.0f;
                if (rand.Next(1, 100) < 50)
                    inc = -1;
                else
                    inc = 1;

                scale = rand.Next(5, 15) / 10.0f;
            }
        }
    }
}
