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
    public partial class Login : Form
    {
        //definimos la cantida de intentos permitidos
        int intentos = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. Confirmar que si desea cerra el sistema

            //Ventana de dialogo

            var Result = MessageBox.Show("Esta seguro que quiere salir?","Confirmar", MessageBoxButtons.YesNo);

            //cerramos el formulario
            if(Result==DialogResult.Yes)
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Verificamos la cantidad de intentos disponibles
            if(intentos>1)
            {
                //Asignamos los valores que el usuario digito en las 
                //cajas de texto
                string user = txtUser.Text;
                string pass = txtPass.Text;

                //Valido las credenciales
                if(user=="Juan" && pass=="123456")
                {
                    MessageBox.Show("Se logueo con exito, Bienvenido");
                }
                else
                {
                    intentos--;
                    MessageBox.Show("Credenciales no validas \n le quedan "+intentos+" intentos");
                    
                }

            }else
            {
                MessageBox.Show("La cantidad de intentos se acabo");
                //cerramos el sistema
                this.Close();
            }    
        }
    }
}
