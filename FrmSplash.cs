using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurosLaFija
{
    public partial class FrmSplash : Form
    {
        //Determina el tiempo transcurrido
        int tiempo=0;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //El evento load se ejecuta al momento de mostrar el 
        //formulario en pantalla
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            //Inicializamos el tiempo de conteo del temporizador
            timer1.Interval = 10;
            //Iniciamos el temporizador
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //mientras no se cumplan los 4 segundos
            if(tiempo<4000)
            {
                tiempo += 40;
                progressBar1.Value += 1;
            }
            else
            {
                this.Close();
                timer1.Stop();

            }
        }
    }
}
