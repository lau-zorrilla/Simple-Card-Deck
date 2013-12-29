using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FormsAppBaraja
{
    public partial class FormBaraja : Form
    {
        public FormBaraja()
        {
            InitializeComponent();
        }

        Baraja b = new Baraja(12);
        ArrayList posiciones;
        string mensaje;
        int num, num1, num2, num3, num4, numCartas, 
            contador1, contador2, suma1, suma2;

        private int Posiciones()
        {
            //Extraccion de cartas y borrado de la lista
            num = b.Extraer(); 
            posiciones = b.GetLista();

            return num;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
           //asegura que hay suficientes cartas para jugar una partida
            numCartas = b.Cantidad();

            if (numCartas > 0)
            {
                num1 = Posiciones();
                num2 = Posiciones();
                lbPlayer1.Text = num1 + ", " + num2;

                suma1 = (num1 + num2);
                contador1 += suma1;
                tbScore1.Text = suma1.ToString();
                tbPlayer1.Text = contador1.ToString();

                num3 = Posiciones();
                num4 = Posiciones();
                lbPlayer2.Text = num3 + ", " + num4;

                suma2 = (num3 + num4);
                contador2 += suma2;
                tbScore2.Text = suma2.ToString();
                tbPlayer2.Text = contador2.ToString();

                tbBaraja.Text = Mensaje(posiciones);
            }
            else
            {
                tbBaraja.Text = "Empiece una nueva partida";
                if (contador1 > contador2)
                    MessageBox.Show("Has ganado, Jugador 1!");
                else
                    MessageBox.Show("Has ganado, Jugador 2!");
            }            
        }

        private string Mensaje(ArrayList posiciones)
        {
            mensaje = "";
            lbCantidad.Text = b.Cantidad().ToString();
           
            foreach (int i in posiciones)
                mensaje += i.ToString() + "  ";

            return mensaje;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            posiciones = b.Inicializar();
            tbBaraja.Text = Mensaje(posiciones);
            btPlay.Enabled = true;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
