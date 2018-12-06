using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class Punto
    {
        public float x, y;
        public ColorOpenGL c;
        public Punto(float coor_x,float coor_y,ColorOpenGL color)
        {
            x = coor_x;
            y = coor_y;
            c = color;
        }
    }
}
