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

namespace Tarea1_preg4
{
    public partial class Form1 : Form
    {
        private float coorX, coorY;
        private float size;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0, 0, 0, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            drawCircle();
        }

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.X.ToString() + "\n" + e.Y.ToString());
            float px, py;
            float width = simpleOpenGlControl1.Width / 2.0f,
                  height = simpleOpenGlControl1.Height / 2.0f;

            px = (e.X - width) / width;
            py = (e.Y - height) / -height;

            textBox1.Text = px.ToString();
            textBox2.Text = py.ToString();

            if (px <= (coorX + size) && px >= (coorX - size)
                && py <= (coorY + size) && py >= (coorY - size))
                simpleOpenGlControl1.Refresh();
        }

        private void drawCircle()
        {
            float x, y;
            float ang;
            int i;
            var random = new Random();
            size = random.Next(1, 3) / 6.0f;
            coorX = random.Next(-10, 10) / 10.0f;
            coorY = random.Next(-10, 10) / 10.0f;

            textBox3.Text = coorX.ToString();
            textBox4.Text = coorY.ToString();


            Gl.glColor3f(random.Next(1, 10) / 10.0f, 
                         random.Next(1, 10) / 10.0f, 
                         random.Next(1, 10) / 10.0f
                         );

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(coorX, coorY);

            for (i = 0; i <= 360; i++)
            {
                ang = i*(float) Math.PI / 180.0f;
                x = (float)Math.Sin(ang);
                y = (float)Math.Cos(ang);

                Gl.glVertex2f(x * size + coorX, y * size + coorY);
                
                textBox5.Text = (size).ToString();
                textBox6.Text = (y * size + coorY).ToString();
            }

            Gl.glEnd();

            //Gl.glColor3f(1, 0, 0);
            //Gl.glPointSize(2);
            //Gl.glBegin(Gl.GL_POINTS);
            //Gl.glVertex2f(coorX, coorY);
            //Gl.glEnd();
        }

    }
}
