using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6_DOBLE
{
    public partial class Form1 : Form
    {
        ListaCirc<int> lista = new ListaCirc<int>();
        Timer timer = new Timer();
        Nodo<int> nodoEnAnimacion;
        int numNodos = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 50; // Intervalo de 50 ms para la animación
            timer.Tick += Timer_Tick;

            // Suscribirse al evento Paint del control "cuadernito"
            cuadernito.Paint += Cuadernito_Paint;
        }

        private void btnColorLiga_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColorLigaView.BackColor = colorDialog1.Color;
        }

        private void btnColorVerificar_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            BtnColorVerView.BackColor = colorDialog2.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnColorLigaView.BackColor = Color.Green;
            BtnColorVerView.BackColor = Color.Aquamarine;
        }

       


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (nodoEnAnimacion != null)
            {
                nodoEnAnimacion.py += 5; // Mover el nodo hacia abajo

                // Detener el timer si el nodo llega a su posición final
                if (nodoEnAnimacion.py >= 100) // Y final deseada
                {
                    timer.Stop();
                    nodoEnAnimacion = null;
                }

                // Redibujar el control "cuadernito"
                cuadernito.Invalidate();
            }
        }

        private void InsertarNodo(int valor)
        {
            lista.Insertar(ref lista, valor);
            nodoEnAnimacion = lista.Fin; // Nodo a animar

            // Define la posición inicial para el nuevo nodo
            if (lista.Fin == lista.Inicio)
            {
                nodoEnAnimacion.px = 50; // Posición X inicial del primer nodo
            }
            else
            {
                nodoEnAnimacion.px = lista.Fin.Liga.px + 100 * numNodos; // Nueva posición X a la derecha del último nodo
            }

            nodoEnAnimacion.py = 0;   // Inicia en la parte superior para la animación
            timer.Start(); // Iniciar animación
        }

        private void Cuadernito_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Nodo<int> actual = lista.Inicio;

            if (actual != null)
            {
                do
                {
                    // Dibujar nodo como rectángulo
                    Rectangle rect = new Rectangle(actual.px, actual.py, 70, 40); // Tamaño de nodo rectangular
                    g.FillRectangle(Brushes.LightBlue, rect);
                    g.DrawRectangle(Pens.Black, rect);
                    g.DrawString(actual.Dato.ToString(), Font, Brushes.Black, actual.px + 30, actual.py + 15);

                    // Dibujar flecha entre nodos
                    if (actual.Liga != null && actual.Liga != lista.Inicio)
                    {
                        int startX = actual.px + 70; // Punto final del rectángulo
                        int startY = actual.py + 20;
                        int endX = actual.Liga.px;
                        int endY = actual.Liga.py + 20;
                        DrawArrow(g, startX, startY, endX, endY);
                    }

                    actual = actual.Liga;
                } while (actual != lista.Inicio);

                // Dibujar flecha de retorno en líneas rectas
                if (lista.Fin != null && lista.Fin.Liga == lista.Inicio)
                {
                    int startX = lista.Fin.px + 70;
                    int startY = lista.Fin.py + 20;
                    int endX = lista.Inicio.px;
                    int endY = lista.Inicio.py + 20;
                    DrawStraightArrow(g, startX, startY, endX, endY);
                }
            }

        }

        private void DrawStraightArrow(Graphics g, int startX, int startY, int endX, int endY)
        {
            // Definir posiciones intermedias para la flecha en L invertida
            int middleX = startX + 50;   // Se mueve a la derecha desde el último nodo
            int bottomY = startY + 80;  // Baja por debajo de los nodos
            int leftX = endX - 50;       // Punto en la izquierda antes de regresar al nodo inicial

            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Línea hacia la derecha
                g.DrawLine(pen, startX, startY, middleX, startY);

                // Línea hacia abajo
                g.DrawLine(pen, middleX, startY, middleX, bottomY);

                // Línea hacia la izquierda
                g.DrawLine(pen, middleX, bottomY, leftX, bottomY);

                // Línea hacia arriba
                g.DrawLine(pen, leftX, bottomY, leftX, bottomY - 80); // Ajusta la altura según sea necesario

                // Línea hacia la derecha hasta el primer nodo
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(pen, leftX, bottomY - 80, endX, endY);
            }
        }

        private void DrawArrow(Graphics g, int startX, int startY, int endX, int endY)
        {
            // Dibuja la línea
            g.DrawLine(Pens.Black, startX, startY, endX, endY);

            // Dibuja la punta de flecha
            double angle = Math.Atan2(endY - startY, endX - startX);
            int arrowSize = 5;
            PointF[] arrowHead = {
            new PointF(endX, endY),
            new PointF(
                endX - arrowSize * (float)Math.Cos(angle - Math.PI / 6),
                endY - arrowSize * (float)Math.Sin(angle - Math.PI / 6)),
            new PointF(
                endX - arrowSize * (float)Math.Cos(angle + Math.PI / 6),
                endY - arrowSize * (float)Math.Sin(angle + Math.PI / 6))
        };
            g.FillPolygon(Brushes.Black, arrowHead);
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int valor = (int)(numericUpDown1.Value);
            InsertarNodo(valor);
            numNodos++;
        }

        private void BtnDesplegar_Click(object sender, EventArgs e)
        {
            lista.Desplegar(lista, listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInserD_Click(object sender, EventArgs e)
        {

        }
    }
}

