using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tarea6_preg1
{
    public partial class Form1 : Form
    {
        private Faro faro;
        private float angle = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Glut.glutInit();
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, 1.0f, 1.0f, 500.0f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            //float[] grey = { 1.75f, 0.75f, 0.75f, 1.0f };
            //Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, grey);


            float[] light_ambient  = { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] light_diffuse = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light_specular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light_position = { -5.0f, .0f, 0.0f, 0.0f };
            float[] light_dir= { 5.0f, .0f, .0f};

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, light_ambient);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, light_specular);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPOT_DIRECTION, light_dir);
            Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_SPOT_EXPONENT, 0.0f);
            Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_SPOT_CUTOFF, 50.0f);
            Gl.glLightf(Gl.GL_LIGHT0, Gl.GL_QUADRATIC_ATTENUATION, 1.0f);

            //float[] lmodel_ambient = { 0.2f, 0.2f, 0.2f, 1.0f };
            //Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, lmodel_ambient);
            //Gl.glLightModeli(Gl.GL_LIGHT_MODEL_LOCAL_VIEWER, Gl.GL_TRUE);

          
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            //Gl.glEnable(Gl.GL_COLOR_MATERIAL);

            faro = new Faro();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0.0f, 0.0f, -40.0f);

            //Gl.glRotatef(120, 0.0f, 1.0f, 0.0f);
            //Gl.glRotatef(10, 0.0f, 0.0f, 1.0f);
            
            Gl.glRotatef(angle, 0.0f, 1.0f, 0.0f);
            

            Gl.glPushMatrix();
            faro.dibujar();
            Gl.glPopMatrix();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 3;

            if (angle > 360)
                angle = 0;

            faro.girar();

            simpleOpenGlControl1.Refresh();
        }

    }
}
