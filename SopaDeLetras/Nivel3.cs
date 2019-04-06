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
    public partial class Nivel3 : Form
    {
        Random letras = new Random();
        bool p1 = false, p2 = false, p3 = false, p4 = false;
        int segundos;
        int minutos;
        public Nivel3()
        {
            InitializeComponent();
            N3PIC1.Visible = false;
            N3PIC2.Visible = false;
            N3PIC3.Visible = false;
            N3PIC4.Visible = false;
            terminar.Visible = false;

            TablaN3.RowCount = 22;
            TablaN3.ColumnCount = 25;

            timer1.Interval = 1000;
            timer1.Start();


            TablaN3.ColumnHeadersVisible = true;

            for (int i = 0; i < TablaN3.RowCount; i++)
            {
                for (int j = 0; j < TablaN3.ColumnCount; j++)
                {
                    TablaN3[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                   inicializarPalabras();
                }
            }
        }


        public void inicializarPalabras() {

            TablaN3[24, 1].Value = 'A';
            TablaN3[23, 2].Value = 'F';
            TablaN3[22, 3].Value = 'N';
            TablaN3[21, 4].Value = 'D';

            TablaN3[12, 8].Value = 'A';
            TablaN3[11, 9].Value = 'F';
            TablaN3[10, 10].Value = 'D';


            TablaN3[8, 21].Value = 'Q';
            TablaN3[9, 20].Value = 'U';
            TablaN3[10, 19].Value = 'I';
            TablaN3[11, 18].Value = 'N';
            TablaN3[12, 17].Value = 'T';
            TablaN3[13, 16].Value = 'U';
            TablaN3[14, 15].Value = 'P';
            TablaN3[15, 14].Value = 'L';
            TablaN3[16, 13].Value = 'A';


            TablaN3[8, 12].Value = 'S';
            TablaN3[7, 11].Value = 'E';
            TablaN3[6, 10].Value = 'P';
            TablaN3[5, 9].Value = 'T';
            TablaN3[4, 8].Value = 'U';
            TablaN3[3, 7].Value = 'P';
            TablaN3[2, 6].Value = 'L';
            TablaN3[1, 5].Value = 'A';


            TablaN3[8, 0].Value = 'G';
            TablaN3[9, 0].Value = 'R';
            TablaN3[10, 0].Value = 'A';
            TablaN3[11, 0].Value = 'M';
            TablaN3[12, 0].Value = 'A';
            TablaN3[13, 0].Value = 'T';
            TablaN3[14, 0].Value = 'I';
            TablaN3[15, 0].Value = 'C';
            TablaN3[16, 0].Value = 'A';

            
        }

        private void Color_click(object sender, EventArgs e)
        {
            TablaN3.CurrentCell.Style.BackColor = Color.Pink;
            validacion();
            JuegoTerminado();
        }

        public void validacion()
        {
            if (!p1 && TablaN3[24, 1].Style.BackColor == Color.Pink && 
                TablaN3[23, 2].Style.BackColor == Color.Pink && 
                TablaN3[22, 3].Style.BackColor == Color.Pink &&
                TablaN3[21, 4].Style.BackColor == Color.Pink)
            {
                p1 = true;
                N3PIC1.Visible = true;
                if (MessageBox.Show("AFND: es un autómata finito que, a diferencia de los autómatas finitos deterministas (AFD)," +
                    " posee al menos un estado q ∈ Q, tal que para un símbolo a ∈ Σ del alfabeto, existe más de una " +
                    "transición δ(q,a) posible.",
                   "¿Quieres saber más?",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Aut%C3%B3mata_finito_no_determinista");
                }
            }

            if (!p2 && TablaN3[12, 8].Style.BackColor == Color.Pink && 
                TablaN3[11, 9].Style.BackColor == Color.Pink && 
                TablaN3[10, 10].Style.BackColor == Color.Pink)
            {
                p2 = true;
                N3PIC2.Visible = true;
                if (MessageBox.Show("AFD: es un autómata finito que además es un sistema determinista; es decir, para cada " +
                    "estado en que se encuentre el autómata, y con cualquier símbolo del alfabeto leído, existe siempre " +
                    "no más de una transición posible desde ese estado y con ese símbolo.",
                   "¿Quieres saber más?",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Aut%C3%B3mata_finito_determinista");
                }
            }

            if (!p3 && TablaN3[8, 21].Style.BackColor == Color.Pink && 
                TablaN3[9, 20].Style.BackColor == Color.Pink && 
                TablaN3[10, 19].Style.BackColor == Color.Pink &&
                TablaN3[11, 18].Style.BackColor == Color.Pink &&
                TablaN3[12, 17].Style.BackColor == Color.Pink &&
                TablaN3[13, 16].Style.BackColor == Color.Pink &&
                TablaN3[14, 15].Style.BackColor == Color.Pink &&
                TablaN3[15, 14].Style.BackColor == Color.Pink &&
                TablaN3[16, 13].Style.BackColor == Color.Pink)
            {
                p3 = true;
                N3PIC3.Visible = true;
                if (MessageBox.Show("Quintupla: Formalmente, se define como una 5-tupla (Q, Σ, q0, δ, F) donde:" +
                    "Q => es un conjunto de estados;" +
                    "Σ =>  es un alfabeto;" +
                    "q0 => es el estado inicial;" +
                    "δ => es una función de transición;" +
                    "F =>  es un conjunto de estados finales o de aceptación.",
                   "¿Quieres saber más?",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Aut%C3%B3mata_finito_determinista");
                }
            }

            if (!p4 && TablaN3[8, 12].Style.BackColor == Color.Pink && 
                TablaN3[7, 11].Style.BackColor == Color.Pink && 
                TablaN3[6, 10].Style.BackColor == Color.Pink &&
                TablaN3[5, 9].Style.BackColor == Color.Pink &&
                TablaN3[4, 8].Style.BackColor == Color.Pink &&
                TablaN3[3, 7].Style.BackColor == Color.Pink &&
                TablaN3[2, 6].Style.BackColor == Color.Pink &&
                TablaN3[1, 5].Style.BackColor == Color.Pink)
            {
                p4 = true;
                N3PIC4.Visible = true;
                if (MessageBox.Show("Septupla: Formalmente, un autómata con pila puede ser descrito como una séptupla M=(S,Σ,Γ,δ,q0,Z,F) donde:" +
                    "S => es un conjunto finito de estados;" +
                    "Σ => es alfabeto de símbolos de entrada;" +
                    "Γ => es alfabeto de símbolos de pila;" +
                    "δ => es una función de transición;" +
                    "q0 => es el estado inicial;" +
                    "Z => es el símbolo inicial de la pila;" +
                    "F =>  es un conjunto de estados finales o de aceptación.",
                   "¿Quieres saber más?",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Aut%C3%B3mata_con_pila");
                }
            }

           
        }
        

        public void JuegoTerminado()
        {

            if (N3PIC1.Visible && N3PIC2.Visible && N3PIC3.Visible && N3PIC4.Visible)
            {
                timer1.Stop();
                MessageBox.Show("¡¡FELICIDADES HAS TERMINADO EL JUEGO!!" +
                           "\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text+ " minutos");
                terminar.Visible = true;
            }
        }

        private void Regresar_color_click(object sender, EventArgs e)
        {
            TablaN3.CurrentCell.Style.BackColor = Color.White;
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

        private void terminar_Click(object sender, EventArgs e)
        {
          
            this.Close();
           

        }

        private void Nivel3_Load(object sender, EventArgs e)
        {

        }
    }
}

