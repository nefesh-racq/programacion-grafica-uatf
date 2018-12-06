using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_preg3
{
    public class Linea
    {
        public Color color = new Color();
        public Punto p0 = new Punto();
        public Punto p1 = new Punto();
        public List<Punto> listaRuta = new List<Punto>();
        public float escala;

        public Linea(float pescala)
        {
            p0 = new Punto(0, 0);
            p1 = new Punto(0, 0);
            escala = pescala;
        }

        public Linea(Punto pp0, Punto pp1, float pescala)
        {
            p0 = pp0;
            p1 = pp1;
            escala = pescala;
        }

        public void DDA()
        {
            float dx = (p1.X - p0.X);
            float dy = (p1.Y - p0.Y);

            float pasos = (Math.Abs(dx) > Math.Abs(dy)) ? Math.Abs(dx) : Math.Abs(dy);
            float incX = dx / pasos;
            float incY = dy / pasos;

            float x = p0.X;
            float y = p0.Y;

            bool cargar = true;

            for (int i = 0; i < pasos; i++)
            {
                if (i % 3 == 0)
                {
                    listaRuta.Add(new Punto(x/escala, y/escala));
                }

                x += incX;
                y += incY;
            }
        }
    }

}
