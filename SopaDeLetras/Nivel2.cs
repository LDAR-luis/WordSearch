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

            TablaN2[2, 12].Value = 'F';
            TablaN2[2, 11].Value = 'U';
            TablaN2[2, 10].Value = 'N';
            TablaN2[2, 9].Value = 'C';
            TablaN2[2, 8].Value = 'I';
            TablaN2[2, 7].Value = 'O';
            TablaN2[2, 6].Value = 'N';

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
            if (TablaN2[1, 2].Style.BackColor == Color.Aqua &&
                TablaN2[2, 3].Style.BackColor == Color.Aqua &&
                TablaN2[3, 4].Style.BackColor == Color.Aqua &&
                TablaN2[4, 5].Style.BackColor == Color.Aqua &&
                TablaN2[5, 6].Style.BackColor == Color.Aqua &&
                TablaN2[6, 7].Style.BackColor == Color.Aqua &&
                TablaN2[7, 8].Style.BackColor == Color.Aqua &&
                TablaN2[8, 9].Style.BackColor == Color.Aqua &&
                TablaN2[9, 10].Style.BackColor == Color.Aqua)
            {

                N2pic1.Visible = true;
            }

            if (TablaN2[11, 4].Style.BackColor == Color.Aqua &&
                TablaN2[11, 5].Style.BackColor == Color.Aqua &&
                TablaN2[11, 6].Style.BackColor == Color.Aqua &&
                TablaN2[11, 7].Style.BackColor == Color.Aqua &&
                TablaN2[11, 8].Style.BackColor == Color.Aqua)

            {
                N2PIC2.Visible = true;
            }

            if (TablaN2[0, 14].Style.BackColor == Color.Aqua &&
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
                N2PIC3.Visible = true;
            }

            if (TablaN2[2, 11].Style.BackColor == Color.Aqua &&
                TablaN2[2, 10].Style.BackColor == Color.Aqua &&
                TablaN2[2, 9].Style.BackColor == Color.Aqua &&
                TablaN2[2, 8].Style.BackColor == Color.Aqua &&
                TablaN2[2, 7].Style.BackColor == Color.Aqua &&
                TablaN2[2, 6].Style.BackColor == Color.Aqua)
            {
                N2PIC4.Visible = true;
            }

            if (TablaN2[9, 13].Style.BackColor == Color.Aqua &&
                TablaN2[10, 12].Style.BackColor == Color.Aqua &&
                TablaN2[11, 11].Style.BackColor == Color.Aqua &&
                TablaN2[12, 10].Style.BackColor == Color.Aqua &&
                TablaN2[13, 9].Style.BackColor == Color.Aqua &&
                TablaN2[14, 8].Style.BackColor == Color.Aqua &&
                TablaN2[15, 7].Style.BackColor == Color.Aqua )
            {
                N2PIC5.Visible = true;
            }

            if (TablaN2[4, 3].Style.BackColor == Color.Aqua &&
                TablaN2[5, 3].Style.BackColor == Color.Aqua &&
                TablaN2[5, 3].Style.BackColor == Color.Aqua &&
                TablaN2[6, 3].Style.BackColor == Color.Aqua &&
                TablaN2[7, 3].Style.BackColor == Color.Aqua &&
                TablaN2[8, 3].Style.BackColor == Color.Aqua &&
                TablaN2[9, 3].Style.BackColor == Color.Aqua &&
                TablaN2[10, 3].Style.BackColor == Color.Aqua)
            {
                N2PIC6.Visible = true;
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
