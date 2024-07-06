using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace GUI_Arduino
{
    public partial class form_Principal : Form
    {
        //Objeto de la clase conexión
        private Conexion conexion;
        //Colores para la interfaz
        private Color MoradoClaro = Color.FromArgb(103, 78, 132);
        private Color DefaultBotones = Color.FromArgb(43, 32, 55);
        private Color ColorRojo = Color.FromArgb(219, 50, 101);
        private Color ColorVerde = Color.FromArgb(185, 240, 77);
        //Objeto para reproducir un audio
        SoundPlayer player = new SoundPlayer();
        
        public form_Principal()
        {
            InitializeComponent();
            pnl_Forms.TabStop = true;
            DesactivarButtons();
            pb_Conexion.BackColor = ColorRojo;
        }
        //Metodo para descativar el uso de las flechas en la interfaz
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Desactivar el procesamiento de las teclas de flecha
            if (keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Down)
            {
                return true; // No procesar la tecla de flecha
            }

            // Llamar al método base para el procesamiento normal de otras teclas
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Abre un WindowsForm dentro de otro y lo cierra si esta otro abierto
        private Form FormActivo = null;

        private void AbrirForm(Form Form)
        {
            if (FormActivo != null)
                FormActivo.Close();

            FormActivo = Form;
            Form.TopLevel = false;
            Form.FormBorderStyle= FormBorderStyle.None;
            Form.Dock= DockStyle.Fill;
            pnl_Forms.Controls.Add(Form);
            pnl_Forms.Tag = Form;
            Form.BringToFront();
            Form.Show();
        }

        //Metodo para abrir la ventana del control, ya que si se abre dentro de otro form, no se podran usar la teclas
        private void AbrirControl(Form Form)
        {
            if (FormActivo != null)
                FormActivo.Close();

            FormActivo = Form;
            Form.Show();
        }
        //Abre el form control
        private void btn_Control_Click(object sender, EventArgs e)
        {
            ControlRemoto ConRem=new ControlRemoto(conexion);
            AbrirControl(ConRem);
            ColorDefault();
            btn_Control.BackColor = MoradoClaro;
        
        }

        //Desactiva los botones
        private void DesactivarButtons()
        {
            btn_Automatic.Enabled = false;
            btn_Control.Enabled = false;
            btn_Motores.Enabled = false;
            btn_Sensores.Enabled = false;
            btn_Conectar.Enabled = false;

            btn_Automatic.BackColor =DefaultBotones;
            btn_Control.BackColor = DefaultBotones;
            btn_Motores.BackColor = DefaultBotones;
            btn_Sensores.BackColor = DefaultBotones;
        }

        //Cambia los colores de los botones a el color por defecto.
        private void ColorDefault()
        {
            btn_Automatic.BackColor = DefaultBotones;
            btn_Control.BackColor = DefaultBotones;
            btn_Motores.BackColor = DefaultBotones;
            btn_Sensores.BackColor = DefaultBotones;
        }

        //Activa los botones
        private void ActivarButtons()
        {
            btn_Automatic.Enabled = true;
            btn_Control.Enabled = true;
            btn_Motores.Enabled = true;
            btn_Sensores.Enabled = true;
            btn_Conectar.Enabled = true;
        }
        //Activa el boton de conectar si se selcciona algo en el combobox

        private void cmb_Conexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Conectar.Enabled = true;
        }

        //EInicia la conexión
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            //El boton inicia verifica si ya esta conectado a una Serial, si es así la cierra.
            if (conexion.EstaAbierto() == true)
                conexion.Cerrar();
            //Abre la conexión en la clase Conexion
            conexion.Abrir(cmb_Conexion.Text);

            //Habilita los botones de las opciones y reproduce la música
            if (conexion.EstaAbierto() == true)
            {
                pb_Conexion.BackColor = ColorVerde;
                btn_Desconectar.Visible = true;
                btn_Conectar.Visible = false;
                cmb_Conexion.Enabled = false;

                ActivarButtons();
                
                player.SoundLocation = @"Music\LadyGaga.wav";
                player.PlayLooping();

            }
            else
                pb_Conexion.BackColor = ColorRojo;
        }
        //Llama a los puertos de la clase conexion para meterlo en la coleccion del combobox
        private void cmb_Conexion_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();

            if (conexion.EstaAbierto() == true)
                conexion.Cerrar();
            cmb_Conexion.Items.Clear();
            cmb_Conexion.Items.AddRange(conexion.CargarPuertos());
        }

        //Evento para que al cerrar el form principal cierre la conexión con la serial
        private void form_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si la conexion esta abierta ejecuta el código para dejar de mover al Auto y cerrar la conexión
            if(conexion!=null)
                if (conexion.EstaAbierto() == true)
                {
                    pb_Conexion.BackColor = ColorRojo;
                    conexion.Escribir('9');
                    conexion.Escribir('N');
                    conexion.DetenerLectura();
                    conexion.Cerrar();
                    btn_Conectar.Visible = false;
                    btn_Conectar.Visible = true;
                    cmb_Conexion.Enabled = true;
                    btn_Control.Enabled = false;
                    DesactivarButtons();
                    btn_Desconectar.Visible = false;

                }
                
        }
        //Evento para desconectar el puerto COM y deshabilitar los botones de opciones
        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            if (conexion.EstaAbierto() == true)
            {
                pb_Conexion.BackColor = ColorRojo;
                conexion.Escribir('9');
                conexion.Escribir('N');
                conexion.DetenerLectura();
                conexion.Cerrar();
                btn_Conectar.Visible = false;
                btn_Conectar.Visible = true;
                cmb_Conexion.Enabled = true;
                cmb_Conexion.Items.Clear();
                btn_Control.Enabled = false;
                DesactivarButtons();
                btn_Desconectar.Visible = false;
                if(FormActivo!=null)
                    FormActivo.Close();

                if (player != null)
                {
                    player.Dispose();
                    player.Stop();
                }
                conexion.Cerrar();
            }
        }
        //sensores
        private void btn_Sensores_Click(object sender, EventArgs e)
        {
            Sensores Sen = new Sensores(conexion);
            AbrirForm(Sen);
            ColorDefault();
            btn_Sensores.BackColor = MoradoClaro;
        }
        //Motores
        private void btn_Motores_Click(object sender, EventArgs e)
        {
            Actuadores Act = new Actuadores(conexion);
            AbrirForm(Act);
            ColorDefault();
            btn_Motores.BackColor = MoradoClaro;
        }
        //Autonomo
        private void btn_Automatic_Click(object sender, EventArgs e)
        {
            Automatico automatico= new Automatico(conexion);
            AbrirForm(automatico);
            ColorDefault();
            btn_Automatic.BackColor = MoradoClaro;
        }


    }
}
