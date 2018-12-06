using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea1_preg2
{
    public class Figura
    {
        public List<Punto> listaPuntos = new List<Punto>();
        public Color color = new Color();
        private Linea linea;


        public Figura(float pescala)
        {
            linea = new Linea(pescala);
        }

        public void Dibujar()
        {
            linea.color = color;
            if (listaPuntos.Count >= 2)
            {
                linea.p0 = listaPuntos[0];
                var temp = linea.p0;

                for (int i = 1; i < listaPuntos.Count; i++)
                {
                    linea.p1 = listaPuntos[i];
                    linea.DDA();
                    linea.p0 = listaPuntos[i];
                }

                linea.p1 = temp;
                linea.DDA();
            }

        }

    }

}
