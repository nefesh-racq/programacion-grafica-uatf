using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using  Tao.OpenGl;
using Tao.Platform.Windows;

namespace Tarea2_preg1
{
    public partial class Form1 : Form
    {
        private List<Points> listPoints = new List<Points>();
        private int index = 0;
        private float[][] color = {new float[3]{1.0f, 0.0f, 0.0f},
                                  new float[3]{1.0f, 1.0f, 0.0f}
                                 };
        private int colorIndex = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, .0f, 1.0f, 0.0f);

            load_circle(1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            foreach (Points p in listPoints)
                p.setPixel();
        }


        private void load_circle(int lados)
        {
            float x, y, i = 360 * 5;
            float angle;
            float b = 0.03f;
            float radius = 0;
            int mod0 = 1, mod1 = 1;
            switch (lados)
            {
                case 0: mod0 = 180; mod1 = 360; break;  //2 lados
                case 1: mod0 = 90; mod1 = 180; break;  // 4 lados
                case 2: mod0 = 60; mod1 = 120; break;    // 6 lados
            }

            for (i = 360*4; i > 0; i--)
            {
                angle = i * (float)Math.PI / 180.0f;
                radius = b * angle;
                y = (float) Math.Sin(angle) *radius;
                x = (float) Math.Cos(angle)*radius;
                Gl.glVertex2f(x, y);

                if (i % mod0 == 0)
                    colorIndex = 0;
                if (i % mod1 == 0)
                    colorIndex = 1;

                listPoints.Add(new Points(x, y, 
                               new Color(color[colorIndex][0], color[colorIndex][1], color[colorIndex][2]))
                               );
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++index > listPoints.Count)
                index = 0;

            simpleOpenGlControl1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_circle(comboBox1.SelectedIndex);
            simpleOpenGlControl1.Refresh();
        }


    }
}
