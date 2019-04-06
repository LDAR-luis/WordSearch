using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SopaDeLetras
{
    public partial class Nivel2 : Form
    {
        Random letras = new Random();
        bool p1 = false, p2 = false, p3 = false, p4 = false, p5 = false, p6 = false;
        int segundos;
        int minutos;
        public Nivel2()
        {
            InitializeComponent();
           
            N2pic1.Visible = false;
            N2PIC2.Visible = false;
            N2PIC3.Visible = false;
            N2PIC4.Visible = false;
            N2PIC5.Visible = false;
            N2PIC6.Visible = false;
            SigNivelFinal.Visible = false;
            TablaN2.RowCount = 16;
            TablaN2.ColumnCount = 17;
            timer1.Interval = 1000;
            timer1.Start();


            TablaN2.ColumnHeadersVisible = true;

            for (int i = 0; i < TablaN2.RowCount; i++)
            {
                for (int j = 0; j < TablaN2.ColumnCount; j++)
                {
                    TablaN2[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    inicializarPalabras();
                }
            }
        }


        public void inicializarPalabras()
        {

            TablaN2[1, 2].Value = 'C';
            TablaN2[2, 3].Value = 'E';
            TablaN2[3, 4].Value = 'R';
            TablaN2[4, 5].Value = 'R';
            TablaN2[5, 6].Value = 'A';
            TablaN2[6, 7].Value = 'D';
            TablaN2[7, 8].Value = 'U';
            TablaN2[8, 9].Value = 'R';
            TablaN2[9, 10].Value = 'A';


            TablaN2[11, 4].Value = 'G';
            TablaN2[11, 5].Value = 'R';
            TablaN2[11, 6].Value = 'A';
            TablaN2[11, 7].Value = 'F';
            TablaN2[11, 8].Value = 'O';


            TablaN2[0, 14].Value = 'T';
            TablaN2[1, 14].Value = 'R';
            TablaN2[2, 14].Value = 'A';
            TablaN2[3, 14].Value = 'N';
            TablaN2[4, 14].Value = 'S';
            TablaN2[5, 14].Value = 'I';
            TablaN2[6, 14].Value = 'C';
            TablaN2[7, 14].Value = 'I';
            TablaN2[8, 14].Value = 'O';
            TablaN2[9, 14].Value = 'N';
            TablaN2[10, 14].Value = 'E';
            TablaN2[11, 14].Value = 'S';

            TablaN2[2, 12].Value = 'E';
            TablaN2[2, 11].Value = 'X';
            TablaN2[2, 10].Value = 'P';
            TablaN2[2, 9].Value = 'R';
            TablaN2[2, 8].Value = 'E';
            TablaN2[2, 7].Value = 'C';
            TablaN2[2, 6].Value = 'I';
            TablaN2[2, 5].Value = 'O';
            TablaN2[2, 4].Value = 'N';


            TablaN2[9, 13].Value = 'C';
            TablaN2[10, 12].Value = 'H';
            TablaN2[11, 11].Value = 'O';
            TablaN2[12, 10].Value = 'M';
            TablaN2[13, 9].Value = 'S';
            TablaN2[14, 8].Value = 'K';
            TablaN2[15, 7].Value = 'Y';


            TablaN2[4, 3].Value = 'A';
            TablaN2[5, 3].Value = 'C';
            TablaN2[6, 3].Value = 'E';
            TablaN2[7, 3].Value = 'P';
            TablaN2[8, 3].Value = 'T';
            TablaN2[9, 3].Value = 'A';
            TablaN2[10, 3].Value = 'R';

        }

        private void Color_click(object sender, EventArgs e)
        {
            TablaN2.CurrentCell.Style.BackColor = Color.Aqua;
            validacion();
            JuegoTerminado();
        }

        private void RegresarColor_doble_click(object sender, EventArgs e)
        {
            TablaN2.CurrentCell.Style.BackColor = Color.White;
        }


        public void validacion() {
            if (!p1 && TablaN2[1, 2].Style.BackColor == Color.Aqua &&
                TablaN2[2, 3].Style.BackColor == Color.Aqua &&
                TablaN2[3, 4].Style.BackColor == Color.Aqua &&
                TablaN2[4, 5].Style.BackColor == Color.Aqua &&
                TablaN2[5, 6].Style.BackColor == Color.Aqua &&
                TablaN2[6, 7].Style.BackColor == Color.Aqua &&
                TablaN2[7, 8].Style.BackColor == Color.Aqua &&
                TablaN2[8, 9].Style.BackColor == Color.Aqua &&
                TablaN2[9, 10].Style.BackColor == Color.Aqua)
            {
                p1 = true;
                N2pic1.Visible = true;
                if (MessageBox.Show("Cerradura o Clausura: Es cuando un el diseño de un automata se puede regresar " +
                    "al mismo estado realizando una o varias transiciones",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Teor%C3%ADa_de_aut%C3%B3matas");
                }
            }

            if (!p2 && TablaN2[11, 4].Style.BackColor == Color.Aqua &&
                TablaN2[11, 5].Style.BackColor == Color.Aqua &&
                TablaN2[11, 6].Style.BackColor == Color.Aqua &&
                TablaN2[11, 7].Style.BackColor == Color.Aqua &&
                TablaN2[11, 8].Style.BackColor == Color.Aqua)

            {
                p2 = true;
                N2PIC2.Visible = true;
                if (MessageBox.Show("Grafo: es un conjunto de objetos llamados vértices o nodos(estados) unidos por enlaces " +
                    "llamados aristas o arcos(transiciones), que permiten representar relaciones binarias entre elementos " +
                    "de un conjunto(automata).",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Grafo");
                }
            }

            if (!p3 && TablaN2[0, 14].Style.BackColor == Color.Aqua &&
                TablaN2[1, 14].Style.BackColor == Color.Aqua &&
                TablaN2[2, 14].Style.BackColor == Color.Aqua &&
                TablaN2[3, 14].Style.BackColor == Color.Aqua &&
                TablaN2[4, 14].Style.BackColor == Color.Aqua &&
                TablaN2[5, 14].Style.BackColor == Color.Aqua &&
                TablaN2[6, 14].Style.BackColor == Color.Aqua &&
                TablaN2[7, 14].Style.BackColor == Color.Aqua &&
                TablaN2[8, 14].Style.BackColor == Color.Aqua &&
                TablaN2[9, 14].Style.BackColor == Color.Aqua &&
                TablaN2[10, 14].Style.BackColor == Color.Aqua &&
                TablaN2[11, 14].Style.BackColor == Color.Aqua)
            {
                p3 = true;
                N2PIC3.Visible = true;
                if (MessageBox.Show("Función de Transición: Determina el comportamiento del autómata, indicando el cambio de estado " +
                    "y lo que se consume de la cadena a validar",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.matesfacil.com/automatas-lenguajes/automata-finito-y-su-lenguaje.html");
                }
            }

            if (!p4 && TablaN2[2, 11].Style.BackColor == Color.Aqua &&
                TablaN2[2, 10].Style.BackColor == Color.Aqua &&
                TablaN2[2, 9].Style.BackColor == Color.Aqua &&
                TablaN2[2, 8].Style.BackColor == Color.Aqua &&
                TablaN2[2, 7].Style.BackColor == Color.Aqua &&
                TablaN2[2, 6].Style.BackColor == Color.Aqua &&
                TablaN2[2, 5].Style.BackColor == Color.Aqua &&
                TablaN2[2, 4].Style.BackColor == Color.Aqua)
            {
                p4 = true;
                N2PIC4.Visible = true;
                if (MessageBox.Show("Expresión Regular: Definien de forma declarativa las cadenas que queremos aceptar",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://antares.sip.ucm.es:8180/webtalf/index.jsp?submenu=temas/submenuRegulares&contenido=temas/exprRegulares");
                }
            }

            if (!p5 && TablaN2[9, 13].Style.BackColor == Color.Aqua &&
                TablaN2[10, 12].Style.BackColor == Color.Aqua &&
                TablaN2[11, 11].Style.BackColor == Color.Aqua &&
                TablaN2[12, 10].Style.BackColor == Color.Aqua &&
                TablaN2[13, 9].Style.BackColor == Color.Aqua &&
                TablaN2[14, 8].Style.BackColor == Color.Aqua &&
                TablaN2[15, 7].Style.BackColor == Color.Aqua )
            {
                p5 = true;
                N2PIC5.Visible = true;
                if (MessageBox.Show("Jerarquía de Chomsky: es una clasificación jerárquica de distintos " +
                    "tipos de gramáticas formales que generan lenguajes formales",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Jerarqu%C3%ADa_de_Chomsky");
                }
            }

            if (!p6 && TablaN2[4, 3].Style.BackColor == Color.Aqua &&
                TablaN2[5, 3].Style.BackColor == Color.Aqua &&
                TablaN2[5, 3].Style.BackColor == Color.Aqua &&
                TablaN2[6, 3].Style.BackColor == Color.Aqua &&
                TablaN2[7, 3].Style.BackColor == Color.Aqua &&
                TablaN2[8, 3].Style.BackColor == Color.Aqua &&
                TablaN2[9, 3].Style.BackColor == Color.Aqua &&
                TablaN2[10, 3].Style.BackColor == Color.Aqua)
            {
                p6 = true;
                N2PIC6.Visible = true;
                if (MessageBox.Show("Aceptación de una cadena: Es cuando el automata llega a un estado final o de aceptación" +
                    " validando toda la cadena que se esta evaluando",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://antares.sip.ucm.es:8180/webtalf/index.jsp?submenu=temas/submenuRegulares&contenido=temas/afd");
                }
            }
        }

        public void JuegoTerminado() {

            if (N2pic1.Visible&&N2PIC2.Visible&&N2PIC3.Visible&& N2PIC4.Visible && N2PIC5.Visible&&N2PIC6.Visible) {
                timer1.Stop();
                MessageBox.Show("FELICIDADES!!" +
                           "\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text + " minutos"+
                           "\n¡¡Ahora estas listo para el último desafio!!");

                SigNivelFinal.Visible = true;
            }
        }

        private void SigNivelFinal_Click(object sender, EventArgs e)
        {
            Nivel3 op = new Nivel3();
            op.Visible = true;
            Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Visible = true;

            segundos += 1;
            string seg = segundos.ToString();
            if (segundos < 10) { seg = "0" + segundos.ToString(); }

            if (segundos == 59)
            {

                minutos += 1;
                segundos = 0;
            }

            Tiempo.Text = minutos.ToString() + ":" + seg.ToString();
        }

        private void Nivel2_Load(object sender, EventArgs e)
        {

        }

        private void N2PA6_Click(object sender, EventArgs e)
        {

        }
    }
}
