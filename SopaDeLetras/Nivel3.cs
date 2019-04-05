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
        int segundos;
        int minutos;
        public Nivel3()
        {
            InitializeComponent();
            N3PIC1.Visible = false;
            N3PIC2.Visible = false;
            N3PIC3.Visible = false;
            N3PIC4.Visible = false;
            N3PIC5.Visible = false;
            N3PIC6.Visible = false;
            N3PIC7.Visible = false;
            N3PIC8.Visible = false;
            N3PIC9.Visible = false;
            N3PIC10.Visible = false;
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
            TablaN3[23, 2].Value = 'L';
            TablaN3[22, 3].Value = 'D';
            TablaN3[21, 4].Value = 'O';

            TablaN3[7, 0].Value = 'M';
            TablaN3[6, 1].Value = 'E';
            TablaN3[5, 2].Value = 'L';
            TablaN3[4, 3].Value = 'C';
            TablaN3[3, 4].Value = 'H';
            TablaN3[2, 5].Value = 'O';
            TablaN3[1, 6].Value = 'R';


            TablaN3[8, 21].Value = 'F';
            TablaN3[9, 20].Value = 'E';
            TablaN3[10, 19].Value = 'R';
            TablaN3[11, 18].Value = 'N';
            TablaN3[12, 17].Value = 'A';
            TablaN3[13, 16].Value = 'N';
            TablaN3[14, 15].Value = 'D';
            TablaN3[15, 14].Value = '0';

            TablaN3[8, 12].Value = 'F';
            TablaN3[7, 11].Value = 'A';
            TablaN3[6, 10].Value = 'B';
            TablaN3[5, 9].Value = 'R';
            TablaN3[4, 8].Value = 'I';
            TablaN3[3, 7].Value = 'Z';
            TablaN3[2, 6].Value = 'I';
            TablaN3[1, 5].Value = 'O';


            TablaN3[12, 0].Value = 'D';
            TablaN3[13, 0].Value = 'I';
            TablaN3[14, 0].Value = 'E';
            TablaN3[15, 0].Value = 'G';
            TablaN3[16, 0].Value = 'O';

            TablaN3[0, 15].Value = 'M';
            TablaN3[1, 16].Value = 'I';
            TablaN3[2, 17].Value = 'G';
            TablaN3[3, 18].Value = 'U';
            TablaN3[4, 19].Value = 'E';
            TablaN3[5, 20].Value = 'L';

            TablaN3[9, 2].Value = 'B';
            TablaN3[9, 3].Value = 'A';
            TablaN3[9, 4].Value = 'R';
            TablaN3[9, 5].Value = 'D';
            TablaN3[9, 6].Value = 'O';

            TablaN3[21, 1].Value = 'M';
            TablaN3[22, 2].Value = 'A';
            TablaN3[23, 3].Value = 'Y';
            TablaN3[24, 4].Value = 'O';


            TablaN3[18, 5].Value = 'K';
            TablaN3[18, 6].Value = 'E';
            TablaN3[18, 7].Value = 'V';
            TablaN3[18, 8].Value = 'I';
            TablaN3[18, 9].Value = 'N';


            TablaN3[19, 16].Value = 'I';
            TablaN3[20, 15].Value = 'V';
            TablaN3[21, 14].Value = 'A';
            TablaN3[22, 13].Value = 'N';
        }

        private void Color_click(object sender, EventArgs e)
        {
            TablaN3.CurrentCell.Style.BackColor = Color.Pink;
            validacion();
            JuegoTerminado();
        }

        public void validacion()
        {
            if (TablaN3[24, 1].Style.BackColor == Color.Pink && TablaN3[23, 2].Style.BackColor == Color.Pink && TablaN3[22, 3].Style.BackColor == Color.Pink &&
                TablaN3[21, 4].Style.BackColor == Color.Pink)
            {

                N3PIC1.Visible = true;

            }

            if (TablaN3[7, 0].Style.BackColor == Color.Pink && TablaN3[6, 1].Style.BackColor == Color.Pink && TablaN3[5, 2].Style.BackColor == Color.Pink &&
                TablaN3[4, 3].Style.BackColor == Color.Pink &&
                TablaN3[3, 4].Style.BackColor == Color.Pink &&
                TablaN3[2, 5].Style.BackColor == Color.Pink &&
                TablaN3[1, 6].Style.BackColor == Color.Pink)
            {

                N3PIC2.Visible = true;

            }

            if (TablaN3[8, 21].Style.BackColor == Color.Pink && TablaN3[9, 20].Style.BackColor == Color.Pink && TablaN3[10, 19].Style.BackColor == Color.Pink &&
               TablaN3[11, 18].Style.BackColor == Color.Pink &&
               TablaN3[12, 17].Style.BackColor == Color.Pink &&
               TablaN3[13, 16].Style.BackColor == Color.Pink &&
               TablaN3[14, 15].Style.BackColor == Color.Pink &&
               TablaN3[15, 14].Style.BackColor == Color.Pink)
            {

                N3PIC3.Visible = true;

            }

            if (TablaN3[8, 12].Style.BackColor == Color.Pink && TablaN3[7, 11].Style.BackColor == Color.Pink && TablaN3[6, 10].Style.BackColor == Color.Pink &&
              TablaN3[5, 9].Style.BackColor == Color.Pink &&
              TablaN3[4, 8].Style.BackColor == Color.Pink &&
              TablaN3[3, 7].Style.BackColor == Color.Pink &&
              TablaN3[2, 6].Style.BackColor == Color.Pink &&
              TablaN3[1, 5].Style.BackColor == Color.Pink)
            {

                N3PIC4.Visible = true;

            }
            if (TablaN3[12, 0].Style.BackColor == Color.Pink && TablaN3[13, 0].Style.BackColor == Color.Pink && TablaN3[14, 0].Style.BackColor == Color.Pink &&
                TablaN3[15, 0].Style.BackColor == Color.Pink &&
                TablaN3[16, 0].Style.BackColor == Color.Pink)
            {

                N3PIC5.Visible = true;

            }

            if (TablaN3[0, 15].Style.BackColor == Color.Pink && TablaN3[1, 16].Style.BackColor == Color.Pink && TablaN3[2, 17].Style.BackColor == Color.Pink &&
                TablaN3[3, 18].Style.BackColor == Color.Pink &&
                TablaN3[4, 19].Style.BackColor == Color.Pink &&
                TablaN3[5, 20].Style.BackColor == Color.Pink)
            {

                N3PIC6.Visible = true;

            }

            if (TablaN3[9, 2].Style.BackColor == Color.Pink && TablaN3[9, 3].Style.BackColor == Color.Pink && TablaN3[9, 4].Style.BackColor == Color.Pink &&
               TablaN3[9, 5].Style.BackColor == Color.Pink &&
               TablaN3[9, 6].Style.BackColor == Color.Pink)
            {

                N3PIC7.Visible = true;

            }

            if (TablaN3[21, 1].Style.BackColor == Color.Pink && TablaN3[22, 2].Style.BackColor == Color.Pink && TablaN3[23, 3].Style.BackColor == Color.Pink &&
               TablaN3[24, 4].Style.BackColor == Color.Pink)
            {

                N3PIC8.Visible = true;

            }

            if (TablaN3[18, 5].Style.BackColor == Color.Pink && TablaN3[18, 6].Style.BackColor == Color.Pink && TablaN3[18, 7].Style.BackColor == Color.Pink &&
               TablaN3[18, 8].Style.BackColor == Color.Pink &&
               TablaN3[18, 9].Style.BackColor == Color.Pink)
            {

                N3PIC9.Visible = true;

            }

            if (TablaN3[19, 16].Style.BackColor == Color.Pink && TablaN3[20, 15].Style.BackColor == Color.Pink && TablaN3[21, 14].Style.BackColor == Color.Pink &&
               TablaN3[22, 13].Style.BackColor == Color.Pink)
            {

                N3PIC10.Visible = true;
            }
        }
        

        public void JuegoTerminado()
        {

            if (N3PIC1.Visible && N3PIC2.Visible && N3PIC3.Visible && N3PIC4.Visible && N3PIC5.Visible && N3PIC6.Visible & N3PIC7.Visible & N3PIC8.Visible
                & N3PIC9.Visible & N3PIC10.Visible)
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
    }
}

