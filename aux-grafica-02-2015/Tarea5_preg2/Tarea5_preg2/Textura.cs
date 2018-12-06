using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea5_preg2
{
    public class Textura
    {
        public static void cargarTexturas(string archivo, out int nuevo)
        {
            Bitmap imagen = cargarImagen(archivo);

            if (imagen != null)
            {
                //imagen.RotateFlip(RotateFlipType.RotateNoneFlipX);                                                          

                Rectangle rectangulo = new Rectangle(0, 0, imagen.Width, imagen.Height);                                                                // marco para la imagen
                BitmapData mapaDeBit = imagen.LockBits(rectangulo, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);                                 // mapa de bit para almacenar la imagen en forma de bit

                Gl.glGenTextures(1, out nuevo);                                                                                                         // reserva identificadores para las texturas
                Gl.glEnable(Gl.GL_COLOR_MATERIAL);                                                                                                      // habilita los colores del material
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, nuevo);                                                                                              // creamos el objeto textura -> nuevo
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);                                                          // definimos los parametros del texturizado
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);                                                          // definimos los parametros del texturizado
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB8, imagen.Width, imagen.Height,
                    0, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, mapaDeBit.Scan0);      // definimos la textura
            }
            else
                nuevo = 0;
        }

        private static Bitmap cargarImagen(string archivo)
        {
            if (archivo == null || archivo == string.Empty) return null;
            if (!File.Exists(archivo)) return null;
            if (File.Exists(archivo)) return new Bitmap(archivo);
            return null;
        }

    }
}
