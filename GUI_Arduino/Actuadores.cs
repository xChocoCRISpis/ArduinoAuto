using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Arduino
{
    public partial class Actuadores : Form
    {
        //Objeto de la clase conexion
        private Conexion Con;
        //Colores para los botones
        private Color AzulClaro = Color.FromArgb(133, 242, 239);
        private Color ColorDef = Color.FromArgb(80, 80, 80);
        //Salida a conexion
        private char seleccion;
        //Contructor para iniciar la clase conexión
        public Actuadores(Conexion conexion)
        {
            InitializeComponent();
            Con = conexion;
        }
        //Establece los colores por default de los botones
        private void ColorDefault()
        {
            btn_Delante.BackColor = ColorDef;
            btn_Atras.BackColor = ColorDef;
            btn_Parar.BackColor = ColorDef;
            btn_IzqDelante.BackColor = ColorDef;
            btn_IzqAtras.BackColor = ColorDef;
            btn_DerDelante.BackColor = ColorDef;
            btn_DerAtras.BackColor = ColorDef;

        }
        //Parar
        private void btn_Parar_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_Parar.BackColor = AzulClaro;
            Con.Escribir('N');
            seleccion = 'N';
        }
        //Avanzar
        private void btn_Delante_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_Delante.BackColor = AzulClaro;
            Con.Escribir('N');

            Con.Escribir('W');
            seleccion = 'W';
        }
        //Retroceder
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_Atras.BackColor= AzulClaro;
            Con.Escribir('N');

            Con.Escribir('S');
            seleccion = 'S';
        }
        //Izquierda adelante
        private void btn_IzqDelante_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_IzqDelante.BackColor= AzulClaro;
            Con.Escribir('N');

            Con.Escribir('U');
            seleccion = 'U';
        }
        //Izquierda átras
        private void btn_IzqAtras_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_IzqAtras.BackColor = AzulClaro;
            Con.Escribir('N');

            Con.Escribir('I');
            seleccion = 'I';
        }
        //Derecha adelante
        private void btn_DerDelante_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_DerDelante.BackColor = AzulClaro;
            Con.Escribir('N');

            Con.Escribir('T');
            seleccion = 'T';
        }
        //Derecha atrás
        private void btn_DerAtras_Click(object sender, EventArgs e)
        {
            ColorDefault();
            btn_DerAtras.BackColor= AzulClaro;
            Con.Escribir('N');

            Con.Escribir('Y');
            seleccion = 'Y';
        }

        /*Distancias
         * xyz
         * 
         * Velocidades
         * dbc
         */

        //Cambiar velocidad a "LENTO"
        private void rdb_Lento_CheckedChanged(object sender, EventArgs e)
        {
            Con.Escribir('d');
            Con.Escribir(seleccion);
        }
        //Cambiar velocidad a "STANDARD"
        private void rdb_Standard_CheckedChanged(object sender, EventArgs e)
        {
            Con.Escribir('b');
            Con.Escribir(seleccion);
        }
        //Cambiar velocidad a "RAPIDO"
        private void rdb_Rapido_CheckedChanged(object sender, EventArgs e)
        {
            Con.Escribir('c');
            Con.Escribir(seleccion);
        }
    }
}
