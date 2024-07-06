using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Arduino
{
    public partial class ControlRemoto : Form
    {
        //Tecla que se presiono
        private Keys TeclaPresionada = Keys.None;
        //Encendido del control
        private bool On = false;
        //Objeto de la clase de controles
        private Controles ObjControles;
        //Objeto de la clase conexion
        private Conexion Con;
        //Colores para los botones.
        private Color ColorClick = Color.FromArgb(162, 123, 208);
        private Color ColorRojo = Color.FromArgb(219, 50, 101);
        private Color ColorVerde = Color.FromArgb(185, 240, 77);

        //Mover ventana con el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Constructor para inciar el objeto conexión con el obtenido del menú principal
        public ControlRemoto(Conexion Conexion)
        {
            InitializeComponent();
            Con = Conexion;
            ObjControles = new Controles(Conexion);
            pb_On.BackColor = ColorRojo;
        }
        //Evento que se ejectua al mantener presionada una tecla
        private void ControlRemoto_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica si esta encendido el control remoto
            if (On == true)
                //Verifica que la tecla actualmente presionada es diferente a la anterior, para no mandar el comando varias veces
                if (e.KeyCode != TeclaPresionada)
                    //Verifica que las teclas presionadas estan dentro de la teclas posibles
                    if (ObjControles.TeclaFlecha(e.KeyCode) == true)
                    {
                        TeclaPresionada = e.KeyCode;
                        //Llama al metódo salida de la clase Controles, para mandar una intruccion a arduino 
                        ObjControles.Salida(e.KeyCode);
                        Console.WriteLine("Tecla Presionada: " + TeclaPresionada);
                        //Ejecuta un codigo para cambiar el color del PB, correspondiente a cada tecla
                        switch (TeclaPresionada)
                        {
                            case Keys.W:
                                pb_Up.BackColor = ColorClick;
                                break;
                            case Keys.S:
                                pb_Down.BackColor = ColorClick;
                                break;
                            case Keys.A:
                                pb_Left.BackColor = ColorClick;
                                break;
                            case Keys.D:
                                pb_Right.BackColor = ColorClick;
                                break;
                        }
                    }
        }
        // Evento que se ejecuta al dejar de presionar una tecla
        private void ControlRemoto_KeyUp(object sender, KeyEventArgs e)
        {
            //Verifica que este encendido y que se este presionando una tecla de las opciones
            if (On == true && ObjControles.TeclaFlecha(e.KeyCode) == true)
            {
                //Manda un input N, para detener el auto
                ObjControles.Salida(Keys.N);
                //Cambia todos los Pb a un color transparente, ya que no se esta presionando ninguna tecla
                pb_Up.BackColor = Color.Transparent;
                pb_Down.BackColor = Color.Transparent;
                pb_Left.BackColor = Color.Transparent;
                pb_Right.BackColor = Color.Transparent;

            }
            //Manda un input N, para detener el auto
            TeclaPresionada = Keys.N;
        }

        //Evento que se ejecuta al presionar y soltar una tecla
        private void ControlRemoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string C = e.KeyChar.ToString();
            Console.WriteLine("Press: " + C);
            //Verifica que la tecla presionada sea la q, esto puede ser con Q(Mayúsucula) o q(Minúscula)
            if (C == "Q" || C=="q")
            {
                Keys key;
                key = Keys.Space;
                //Enciende o apaga el control remoto
                On = ObjControles.Encender(key);

                if (On == true)
                {
                    On = true;
                    pb_On.BackColor = ColorVerde;
                }
                else
                {
                    ObjControles.Salida(Keys.N);
                    On = false;
                    pb_On.BackColor = ColorRojo;

                }

            }
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para que al dar click en el PB de minimizar, la pestaña se minimicé
        private void pb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento para que al manter el click sobre el pnl de despazamiento este se mueva con el mouse 
        private void pnl_Arriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
