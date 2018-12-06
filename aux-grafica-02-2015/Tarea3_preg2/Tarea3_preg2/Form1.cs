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

namespace Tarea3_preg2
{
    public partial class Form1 : Form
    {
//        figura ff = new figura(0.0f)
        Random r = new Random();
        private float px, py;
        private float down = 10f;
        private float angle = 0;
        List<figura> lf = new List<figura>();

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.4f, 0.0f, 0.4f, 1.0f);

            for (int i = 0; i < 20; i++)
            {
                lf.Add(new figura(r));
            }
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glScalef(0.1f, 0.1f, 0.1f);
            //for (int i = 0; i < 20; i++)
            foreach (figura f in lf)
            {
                //Gl.glTranslatef(px, down, 0.0f);
                Gl.glPushMatrix();
                //Gl.glRotatef(angle, 0.0f, 0.0f, 1.0f);
                f.draw();
                Gl.glPopMatrix();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (figura f in lf)
            {
                f.caer();
            }

            simpleOpenGlControl1.Refresh();
        }

        
    }
}
