using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_preg3
{
    public class Figura
    {
        public List<Punto> listaRuta = new List<Punto>();
        public List<Punto> listaPuntos = new List<Punto>();
        public Color color = new Color();
        public Linea linea;
        private int escala;

        public Figura(float pescala)
        {
            linea = new Linea(pescala);
            escala = (int)pescala;

            // cargamos el camino
            CargarCamino();
        }

        public void CargarCamino()
        {
            // primero limpiamos la lista si exite alguna
            listaPuntos = new List<Punto>();
            linea.listaRuta = new List<Punto>();

            var aleatorio = new Random();
            int j = -1;

            Color[] colores = { new Color(1, 1, 0), 
                                new Color(1, 0, 1), 
                                new Color(0, 1, 1), 
                                new Color(0, 0, 1), 
                                new Color(0, 1, 0) 
                              };

            while (++j < 5)
            {
                listaPuntos.Add(new Punto(aleatorio.Next(-escala, escala), 
                                          aleatorio.Next(-escala, escala),
                                          colores[j]
                                          ));

                //listaPuntos[j].DibujarPunto();
            }

            // ahroa llamamos al metodo linea y cargamos la lista de la ruta
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
