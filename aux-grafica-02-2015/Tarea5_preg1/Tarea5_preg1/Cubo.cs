using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Tarea5_preg1
{
    public class Cubo
    {
        private int rojo_id;
        private int verde_id;
        private int azul_id;
        private int amarillo_id;
        private int naranja_id ;
        private int blanco_id;
        private float angulo;

        public Cubo()
        {
            Textura.cargarTexturas(@"rojo.png", out rojo_id);
            Textura.cargarTexturas(@"verde.png", out verde_id);
            Textura.cargarTexturas(@"azul.png", out azul_id);
            Textura.cargarTexturas(@"amarillo.png", out amarillo_id);
            Textura.cargarTexturas(@"naranja.png", out naranja_id);
            Textura.cargarTexturas(@"blanco.png", out blanco_id);
            angulo = 0;
        }

        public void dibujar()
        {
            //for (int i = -2; i < 3; i += 2)
            //{
            //    for (int j = -2; j < 3; j += 2)
            //    {
            //        for (int k = -2; k < 3; k += 2)
            //        {
            //            Gl.glPushMatrix();
            //            Gl.glTranslatef(i, j, k);
            //            cubo();
            //            Gl.glPopMatrix();
            //        }
            //    }
            //}

            Gl.glPushMatrix();
                Gl.glRotatef(angulo, 1.0f, 0.0f, 0.0f);
                // abajo izquierda
                Gl.glPushMatrix();
                Gl.glTranslatef(-2, -2, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-2, -2, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-2, -2, 2);
                cubo();
                Gl.glPopMatrix();


                // izquierda medio
                Gl.glPushMatrix();
                Gl.glTranslatef(-2, 0, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-2, 0, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-2, 0, 2);
                cubo();
                Gl.glPopMatrix();

                // izquierda arriba
                Gl.glPushMatrix();
                Gl.glTranslatef(-2, 2, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-2, 2, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(-2, 2, 2);
                cubo();
                Gl.glPopMatrix();
            Gl.glPopMatrix();


            Gl.glPushMatrix();
                Gl.glRotatef(-angulo, 1.0f, 0.0f, 0.0f);
                // medio abajo
                Gl.glPushMatrix();
                Gl.glTranslatef(0, -2, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0, -2, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0, -2, 2);
                cubo();
                Gl.glPopMatrix();


                // medio medio
                Gl.glPushMatrix();
                Gl.glTranslatef(0, 0, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0, 0, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0, 0, 2);
                cubo();
                Gl.glPopMatrix();


                // medio arriba
                Gl.glPushMatrix();
                Gl.glTranslatef(0, 2, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0, 2, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(0, 2, 2);
                cubo();
                Gl.glPopMatrix();
            Gl.glPopMatrix();


            Gl.glPushMatrix();
            Gl.glRotatef(angulo, 1.0f, 0.0f, 0.0f);
                // deracha abajo
                Gl.glPushMatrix();
                Gl.glTranslatef(2, -2, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(2, -2, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(2, -2, 2);
                cubo();
                Gl.glPopMatrix();

                // derecha medio
                Gl.glPushMatrix();
                Gl.glTranslatef(2, 0, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(2, 0, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(2, 0, 2);
                cubo();
                Gl.glPopMatrix();


                // derecha medio
                Gl.glPushMatrix();
                Gl.glTranslatef(2, 2, -2);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(2, 2, 0);
                cubo();
                Gl.glPopMatrix();

                Gl.glPushMatrix();
                Gl.glTranslatef(2, 2, 2);
                cubo();
                Gl.glPopMatrix();
            Gl.glPopMatrix();
        }


        public void cubo()
        {
            float tam = 0.991f;
            material();

            // frente
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, rojo_id);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glNormal3f(0.0f, 0.0f, 1.0f);
                Gl.glTexCoord3f(1,0 ,0); Gl.glVertex3f(tam, tam, 0);
                Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, tam, 0);
                Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -tam, 0);
                Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -tam, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // atras
            Gl.glPushMatrix();
            Gl.glRotatef(180, 0, 1, 0);
            Gl.glTranslatef(0, 0, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, verde_id);
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glNormal3f(0.0f, 0.0f, 1.0f);
                Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, tam, 0);
                Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, tam, 0);
                Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -tam, 0);
                Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -tam, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // izquierda
            Gl.glPushMatrix();
            Gl.glRotatef(90, 0, 1, 0);
            Gl.glTranslatef(0, 0, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, azul_id);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, tam, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, tam, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -tam, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -tam, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();


            // derecha
            Gl.glPushMatrix();
            Gl.glRotatef(-90, 0, 1, 0);
            Gl.glTranslatef(0, 0, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, amarillo_id);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, tam, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, tam, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -tam, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -tam, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // abajo
            Gl.glPushMatrix();
            Gl.glRotatef(90, 1, 0, 0);
            Gl.glTranslatef(0, 0, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, naranja_id);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, tam, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, tam, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -tam, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -tam, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();

            // arriba
            Gl.glPushMatrix();
            Gl.glRotatef(-90, 1, 0, 0);
            Gl.glTranslatef(0, 0, tam);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, blanco_id);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glTexCoord3f(1, 0, 0); Gl.glVertex3f(tam, tam, 0);
            Gl.glTexCoord3f(0, 0, 0); Gl.glVertex3f(-tam, tam, 0);
            Gl.glTexCoord3f(0, 1, 0); Gl.glVertex3f(-tam, -tam, 0);
            Gl.glTexCoord3f(1, 1, 0); Gl.glVertex3f(tam, -tam, 0);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();
        }

        private void material()
        {
            float[] mat_specular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] mat_shininess = { 50.0f };
            float[] light_position = { 0.0f, 0.0f, 0.0f, 1.0f };
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, mat_specular);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, mat_shininess);
            //Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
        }

    }
}
