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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            //Nivel1 llamarN1 = new Nivel1();
            //llamarN1.Show();
            Nivel2 llamarN2 = new Nivel2();
            llamarN2.Show();
            this.Visible = false;
            
        }

        private void instruccion(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDOS A LA AVENTURA"+
                            "\n"+
                            "\n" +
                            "\nINSTRUCCIONES:" +
                            "\n" +
                            "\n1.- Para seleccionar una letra dar click izquierdo" +
                            "\n" +
                            "\n2.- Para deseleccionar dar doble click izquierdo");
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
