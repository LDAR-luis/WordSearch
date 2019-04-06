using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;


namespace SopaDeLetras
{
    public partial class Nivel1 : Form
    {
        Random letras = new Random();
        bool p1 = false, p2 = false, p3 = false, p4 = false, p5 = false, p6 = false;
         int segundos;
         int   minutos;
        public Nivel1()
        {
            InitializeComponent();
           pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            SigNivel.Visible = false;
            Tabla.RowCount = 16;
            Tabla.ColumnCount = 17;
            timer1.Interval = 1000;
            timer1.Start();


            Tabla.ColumnHeadersVisible = true;

            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    Tabla[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    inicializarPalabras();
                }
            }
           

        }


        private void Color_click(object sender, EventArgs e)
        {
            Tabla.CurrentCell.Style.BackColor = Color.YellowGreen;
            validacion();
            JuegoTerminado();
        }

        private void RegresarColor_Doclick(object sender, EventArgs e)
        {
           Tabla.CurrentCell.Style.BackColor = Color.White;
        }
       
        public void inicializarPalabras()
        {
            Tabla[8, 9].Value = 'S';
            Tabla[9, 9].Value = 'I';
            Tabla[10, 9].Value = 'M';
            Tabla[11, 9].Value = 'B';
            Tabla[12, 9].Value = 'O';
            Tabla[13, 9].Value = 'L';
            Tabla[14, 9].Value = 'O';

            Tabla[2, 1].Value = 'E';
            Tabla[3, 2].Value = 'S';
            Tabla[4, 3].Value = 'T';
            Tabla[5, 4].Value = 'A';
            Tabla[6, 5].Value = 'D';
            Tabla[7, 6].Value = 'O';
            Tabla[8, 7].Value = 'S';


            Tabla[0, 1].Value = 'I';
            Tabla[0, 2].Value = 'N';
            Tabla[0, 3].Value = 'I';
            Tabla[0, 4].Value = 'C';
            Tabla[0, 5].Value = 'I';
            Tabla[0, 6].Value = 'A';
            Tabla[0, 7].Value = 'L';


            Tabla[16, 15].Value = 'F';
            Tabla[15, 14].Value = 'I';
            Tabla[14, 13].Value = 'N';
            Tabla[13, 12].Value = 'A';
            Tabla[12, 11].Value = 'L';


            Tabla[15, 2].Value = 'C';
            Tabla[14, 2].Value = 'A';
            Tabla[13, 2].Value = 'D';
            Tabla[12, 2].Value = 'E';
            Tabla[11, 2].Value = 'N';
            Tabla[10, 2].Value = 'A';
            


            Tabla[4, 5].Value = 'A';
            Tabla[4, 6].Value = 'U';
            Tabla[4, 7].Value = 'T';
            Tabla[4, 8].Value = 'O';
            Tabla[4, 9].Value = 'M';
            Tabla[4, 10].Value = 'A';
            Tabla[4, 11].Value = 'T';
            Tabla[4, 12].Value = 'A';

        }




        public void validacion()
        {
            // Verifico en la tabla si las palabra esta iluminada si es asi entonces hago visible la palomita
            
            if (! p1 && Tabla[8, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[9, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[10, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[11, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[12, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[13, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[14, 9].Style.BackColor == Color.YellowGreen )
            {
                pic1.Visible = true;
                p1 = true;
                if (MessageBox.Show("Simbolo: Un dato arbitrario que tiene algún significado o efecto en la máquina." +
                    " A estos símbolos también se les llama 'letras' o 'átomos'", 
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Teor%C3%ADa_de_aut%C3%B3matas");
                }
            }

            if (!p2 && Tabla[2, 1].Style.BackColor == Color.YellowGreen &&
                Tabla[3, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 3].Style.BackColor == Color.YellowGreen &&
                Tabla[5, 4].Style.BackColor == Color.YellowGreen &&
                Tabla[6, 5].Style.BackColor == Color.YellowGreen &&
                Tabla[7, 6].Style.BackColor == Color.YellowGreen &&
                Tabla[8, 7].Style.BackColor == Color.YellowGreen)

            {

                pic2.Visible = true;
                p2 = true;
                if (MessageBox.Show("Estados: Son las fases que puede llegar a tomar un automata durante un proceso" +
                    "de validacion de una cadena",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.matesfacil.com/automatas-lenguajes/automata-finito-y-su-lenguaje.html");
                }
            }

            if (!p3 && Tabla[0, 1].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 3].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 4].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 5].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 6].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 7].Style.BackColor == Color.YellowGreen)

            {
                pic3.Visible = true;
                p3 = true;
                if (MessageBox.Show("Estado inicial: estado o estados en los que debe de iniciar un automata",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.matesfacil.com/automatas-lenguajes/automata-finito-y-su-lenguaje.html");
                }
            }

            if (!p4 && Tabla[16, 15].Style.BackColor == Color.YellowGreen && 
                Tabla[15, 14].Style.BackColor == Color.YellowGreen &&
                Tabla[14, 13].Style.BackColor == Color.YellowGreen &&
                Tabla[13, 12].Style.BackColor == Color.YellowGreen &&
                Tabla[12, 11].Style.BackColor == Color.YellowGreen)
               
            {
                pic4.Visible = true;
                p4 = true;
                if (MessageBox.Show("Estado final(aceptacion): estado o estados en los que debe de terminar " +
                    "la lectura de una cadena para decir que esta es aceptada",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.matesfacil.com/automatas-lenguajes/automata-finito-y-su-lenguaje.html");
                }
            }

            if (!p5 && Tabla[15, 2].Style.BackColor == Color.YellowGreen && 
                Tabla[14, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[13,2].Style.BackColor == Color.YellowGreen &&
                Tabla[12, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[11, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[10, 2].Style.BackColor == Color.YellowGreen)
            {
                p5 = true;
                pic5.Visible = true;
                if (MessageBox.Show("Cadena:Una cadena o palabra es una secuencia finita de símbolos " +
                    "que pertenecen a un alfabeto y comunmente se denota con la letra w. " +
                    "La cadena vacía se denota como ε y es una secuencia vacía de símbolos tomados " +
                    "de cualquier alfabeto Σ",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://delta.cs.cinvestav.mx/~mcintosh/comun/summer2006/algebraPablo_html/node4.html");
                }
            }

            if (!p6 && Tabla[4, 5].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 6].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 7].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 8].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 10].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 11].Style.BackColor == Color.YellowGreen  &&
                Tabla[4,12].Style.BackColor == Color.YellowGreen)
            {
                p6 = false;
                pic6.Visible = true;
                if (MessageBox.Show("Automata: es un modelo matemático para una máquina. Es una máquina que, dada una " +
                    "entrada de símbolos, 'salta' a través de una serie de estados de acuerdo a una función de " +
                    "transición ",
                    "¿Quieres saber más?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Teor%C3%ADa_de_aut%C3%B3matas");
                }
            }
        }


        public void JuegoTerminado() {

            if (pic1.Visible && pic2.Visible && pic3.Visible && pic4.Visible && pic5.Visible && pic6.Visible) {
                timer1.Stop();
                MessageBox.Show("FELICIDADES!!" +
                           "\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text + " minutos" );
                
                SigNivel.Visible = true;
            }
          }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Visible = true;

            segundos += 1;
            string seg = segundos.ToString();
            if (segundos<10) { seg = "0" + segundos.ToString(); }
   
            if (segundos == 59) {

                minutos += 1;
                segundos = 0;
            }
           
            Tiempo.Text = minutos.ToString() + ":" + seg.ToString();
        }

        private void SigNivel_Click(object sender, EventArgs e)
        {
            Nivel2 llamarN2 = new Nivel2();
            llamarN2.Visible = true;
            Visible = false;
        }

        private void Pa1_Click(object sender, EventArgs e)
        {

        }

        private void Nivel1_Load(object sender, EventArgs e)
        {

        }
    }
}
