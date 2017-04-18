using System;
using Tao.OpenGl;
namespace Grafika
{
    class Primityvai
    {
        static int plotis, aukstis;
        static void Main(string[] args)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize(400, 400);
            Glut.glutInitWindowPosition(400, 300);
            Glut.glutCreateWindow("Grafiniai primityvai");
            Init();
            Glut.glutDisplayFunc(new Glut.DisplayCallback(figura));
            Glut.glutCreateMenu(new Glut.CreateMenuCallback(Menu));
            Glut.glutAddMenuEntry("(1)I Ketvirtis", 1);
            Glut.glutAddMenuEntry("(2)II Ketvirtis", 2);
            Glut.glutAddMenuEntry("(3)III Ketvirtis", 3);
            Glut.glutAddMenuEntry("(4)IV Ketvirtis", 4);
            Glut.glutAddMenuEntry("(5)Sumazint, pasukt ir pastumt", 5);
            Glut.glutAttachMenu(Glut.GLUT_RIGHT_BUTTON);
            Glut.glutReshapeFunc(new Glut.ReshapeCallback(Reshape));
            Glut.glutMainLoop();                  //pradedamas vykdyti grafinės programos ciklas
        }
        static void Init()
        {
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
        }

        static void Vaizdavimas1()
        {

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT); //išvalomas ekramas
            Gl.glColor3f(102 / 256f, 225 / 256f, 118 / 256f); //nustatoma piešimo spalva
            //IV lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(0, aukstis / 2, plotis / 2, aukstis / 2);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1.0, 1.0, -1.0, 1.0); //Nustatomas naujas iškirpimo langas
            Gl.glRectd(-1, -1, 1, 1);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glColor3f(191 / 256f, 250 / 256f, 190 / 256f);
            figura(); //vaizduojama figūra



        }

        static void Vaizdavimas2()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT); //išvalomas ekramas
            Gl.glColor3f(102 / 256f, 225 / 256f, 118 / 256f); //nustatoma piešimo spalva
            Gl.glLineWidth(1);   //nustatomas piešiamos atkarpos storis
            //I lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(plotis - plotis / 4, aukstis - aukstis / 2, plotis / 4, aukstis / 4);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Gl.glRectd(-1, -1, 1, 1);
            Glu.gluOrtho2D(0, 1, -1, 0);   //Nustatomas naujas iškirpimo langas
            Gl.glScaled(0.5, 0.5, 0);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
            Gl.glColor3f(0 / 256f, 250 / 256f, 0 / 256f);
            figura(); //vaizduojama figūra     
        }


        static void Vaizdavimas3()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT); //išvalomas ekramas
            Gl.glColor3f(102 / 256f, 225 / 256f, 118 / 256f); //nustatoma piešimo spalva
            Gl.glLineWidth(1);   //nustatomas piešiamos atkarpos storis
            //II lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(plotis / 2, 0, plotis / 2, aukstis / 2);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1.0, 1.0, -1.0, 1.0); //Nustatomas naujas iškirpimo langas  
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            figura();
            //Gl.glViewport(plotis / 2, 0, plotis / 2, aukstis / 2);  
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
            figura();//vaizduojama figūra
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glLoadIdentity();
            Gl.glTranslatef(0.333f, 0.833f, 0);
            Gl.glRotated(20, 0, 0, 1);
            Gl.glScalef(0.5f, 0.5f, 0);
            Gl.glTranslatef(-0.333f, -0.833f, 0);
            figura();
            Gl.glFlush();
        }

        static void Vaizdavimas4()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT); //išvalomas ekramas
            Gl.glColor3f(102 / 256f, 225 / 256f, 118 / 256f); //nustatoma piešimo spalva
            Gl.glLineWidth(1);   //nustatomas piešiamos atkarpos storis
            //III lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(0, 0, plotis / 2, aukstis / 2);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1, 1, -1.0, 1.0);  //Nustatomas naujas iškirpimo langas
            Gl.glColor3f(50 / 256f, 200 / 256f, 190 / 256f);
            Gl.glRectd(-1.0, -1.0, 1, 1);
            Gl.glScaled(0.5, 0.5, 0);
            figura();//vaizduojama figūra

        }


        static void Vaizdavimas5()
        {

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT); //išvalomas ekramas
            Gl.glColor3f(102 / 256f, 225 / 256f, 118 / 256f); //nustatoma piešimo spalva
            Gl.glViewport(0, 0, aukstis, plotis);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();
            //nupiešiamas lango fonas
            //IV lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(0, aukstis / 2, plotis / 2, aukstis / 2);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1.0, 1.0, -1.0, 1.0); //Nustatomas naujas iškirpimo langas
            Gl.glRectd(-1, -1, 1, 1);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glColor3f(191 / 256f, 250 / 256f, 190 / 256f);
            figura(); //vaizduojama figūra
            //I lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(plotis - plotis / 4, aukstis - aukstis / 2, plotis / 4, aukstis / 4);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Gl.glRectd(-1, -1, 1, 1);
            Glu.gluOrtho2D(0, 1, -1, 0);   //Nustatomas naujas iškirpimo langas
            Gl.glScaled(0.5, 0.5, 0);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
            Gl.glColor3f(0 / 256f, 250 / 256f, 0 / 256f);
            figura(); //vaizduojama figūra
            //III lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(0, 0, plotis / 2, aukstis / 2);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1.0, 1.0, -1.0, 1.0);  //Nustatomas naujas iškirpimo langas
            Gl.glColor3f(50 / 256f, 200 / 256f, 190 / 256f);
            Gl.glRectd(-1, -1, 1, 1);
            Gl.glScaled(0.5, 0.5, 0);
            figura();//vaizduojama figūra
            //II lango ketvirtis
            //Nustatomas vaizdavimo plokštumos dydis ir padėtis lango koordinatėmis
            Gl.glViewport(plotis / 2, 0, plotis / 2, aukstis / 2);
            Gl.glMatrixMode(Gl.GL_PROJECTION);    //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                  //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1.0, 1.0, -1, 1); //Nustatomas naujas iškirpimo langas  
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            figura();
            //Gl.glViewport(plotis / 2, 0, plotis / 2, aukstis / 2);  
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
            figura();//vaizduojama figūra
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glLoadIdentity();
            Gl.glTranslatef(0.333f, 0.833f, 0);
            Gl.glRotated(20, 0, 0, 1);
            Gl.glScalef(0.5f, 0.5f, 0);
            Gl.glTranslatef(-0.333f, -0.833f, 0);
            figura();
            Gl.glFlush();
        }


        static void Reshape(int w, int h)
        {
            if (w > h)                   // tam, kad keičiant programos lango dydį nebūtų
            {                            // iškraipomas vaizdas, nustatomas vienodas
                plotis = aukstis = h;    // vaizdavimo plokštumos aukštis ir plotis
            }
            else
                plotis = aukstis = w;
            //Nustatomas vaizdavimo plokštumos dydis ir pozicija
            Gl.glViewport(0, 0, plotis, aukstis);
            Gl.glMatrixMode(Gl.GL_PROJECTION);     //Nustatoma einamoji matrica
            Gl.glLoadIdentity();                   //Išvaloma projekcijų matrica
            Glu.gluOrtho2D(-1.0, 1.0, -1.0, 1.0); //Nustatomas naujas iškirpimo langas
        }

        static void figura()
        {


            Gl.glLineWidth(3);   //nustatomas piešiamos atkarpos storis
            //aktyvuojama galimybė naudoti viršūnių masyvą
            Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY);
            //aktyvuojama galimybė naudoti spalvų masyvą
            Gl.glEnableClientState(Gl.GL_COLOR_ARRAY);
            //aprašomas viršūnių masyvas
            float[] koordinates = {
                         0.0f,  0.6f,    //0
                        -0.4f,  1.0f,    //1
                        -0.4f,  0.6f,    //2
                         0.0f,  0.4f,    //3
                         0.4f,  0.6f,    //4
                         0.4f,  1.0f,    //5
                         0.6f,  0.4f,    //6
                         0.4f,  0.0f,    //7
                         0.6f,  0.0f,    //8
                         1.0f,  0.4f,    //9
                         1.0f, -0.4f,    //10
                         0.6f, -0.4f,    //11
                         0.4f, -0.6f,    //12
                         0.0f, -0.4f,    //13
                         0.0f, -0.6f,    //14
                         0.4f, -1.0f,    //15
                        -0.4f, -0.6f,    //16
                        -0.4f, -1.0f,    //17
                        -0.4f,  0.0f,    //18
                        -0.6f, -0.4f,    //19
                        -0.6f,  0.0f,    //20
                        -1.0f, -0.4f,    //21
                        -1.0f,  0.4f,    //22
                        -0.6f,  0.4f,    //23
                      };
            //aprašomas spalvų masyvas

            float[] spalvos = {

                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,
                                     0 / 256f, 0 / 256f, 139 / 256f,

                                 };

            //sudaromas viršūnių indeksų masyvas figūros piešimui
            byte[] trikampiai = { 1,2,3, 1,3,0, 0,3,5, 5,3,4, 3,4,6, 3,6,7, 6,7,9,
                      7,9,8, 7,8,10, 7,10,11, 7,12,11, 12,13,7,
                       13,14,15, 14,13,17, 13,16,17, 16,13,19,
                    19,18,13, 19,18,21, 18,20,21, 20,18,22, 23,22,18, 23,18,2, 12,13,15, 18,2,3, };
            //sudaromas viršūnių indeksų masyvas kontūro apie figūrą piešimui
            byte[] konturas = { 0, 5, 4, 6, 9, 8, 10, 11, 12, 15, 14, 17, 16, 19, 21, 20, 22, 23, 2, 1, 0 };
            byte[] konturas1 = { 3, 7, 13, 18 };
            //aprašoma nuoroda į figūros viršūnes
            Gl.glVertexPointer(2, Gl.GL_FLOAT, 0, koordinates);
            //aprašoma nuoroda į viršūnių spalvas 
            Gl.glColorPointer(3, Gl.GL_FLOAT, 0, spalvos);
            //nustatoma, kad spalvos nebus interpoliuojamos
            Gl.glShadeModel(Gl.GL_FLAT);
            //piešiama figūra
            Gl.glDrawElements(Gl.GL_TRIANGLES, 77, Gl.GL_UNSIGNED_BYTE, trikampiai);
            Gl.glDisableClientState(Gl.GL_COLOR_ARRAY);         //išjungiamas spalvų masyvas
            //nustatoma figūros kontūro spalva
            Gl.glColor3f(255 / 256f, 0 / 256f, 0 / 256f);
            //piešiamas figūros kontūras
            Gl.glDrawElements(Gl.GL_LINE_LOOP, 24, Gl.GL_UNSIGNED_BYTE, konturas);
            Gl.glDrawElements(Gl.GL_LINE_LOOP, 4, Gl.GL_UNSIGNED_BYTE, konturas1);
            Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY);        //išjungiamas viršūnių masyvas
            Gl.glFlush(); //Aprašyti objektai piešiami į ekraną
        }
        static void Menu(int i)
        {
            switch (i)
            {
                case 1:
                    Vaizdavimas1();
                    break;
                case 2:
                    Vaizdavimas2();
                    break;
                case 3:
                    Vaizdavimas3();
                    break;
                case 4:
                    Vaizdavimas4();
                    break;
                case 5:
                    Vaizdavimas5();
                    break;

            }
        }

    }
}



