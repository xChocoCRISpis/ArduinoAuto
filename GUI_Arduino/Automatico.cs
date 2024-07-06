using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Arduino
{
    public partial class Automatico : Form
    {
        /*Distancias
         * xyz
         * 
         * Velocidades
         * dbc
         */

        //Objeto de conexion
        private Conexion con;
        //Bool para saber si esta encendido
        private bool encendido=false;
        //Hilo para lectura
        private Thread thread;
        //Atributo para saber si se necesita leer la serial
        private bool isRunning = true;

        //Constructor
        public Automatico(Conexion conexion)
        {
            InitializeComponent();
            //Inicializacion del objeto de conexion
            con = conexion;
            //Establece los radiobutton por default
            rdb_Dis2.Checked = true;
            rdb_Standard.Checked = true;
        }

        //Enciende el modo automatico
        private void btn_Encender_Click(object sender, EventArgs e)
        {
            btn_Apagar.Visible = true;
            btn_Encender.Visible = false;
            encendido = true;
            //envia la intruccion de encender el modo automatico a la clase conexion
            con.Escribir('0');
            //Inicia a leer la serial
            thread = new Thread(Salida);
            //inica el hilo para leer
            thread.Start();
            //establece la condicion de lectura como true
            isRunning = true;

        }
        //Atributo para saber la salida del Arduino
        private string salida;

        //Metodo para leer el serial del Arduino
        private void Salida()
        {
            if (con.EstaAbierto())
                while (isRunning)
                {
                    //If para saber si el thread esta invocado o no
                    if (this.lbl_Salida.InvokeRequired)
                    {
                        //Si no esta invocado lo invoca y crea un delagado
                        this.lbl_Salida.Invoke((MethodInvoker)delegate
                        {
                            //Lee la serial de Arduino a traves de la clase conexion
                            this.lbl_Salida.Text = con.GetSerial();
                            salida = con.GetSerial();
                        });
                    }
                    else
                    {
                        //Si ya esta invocado solo lee la serial de Arduino
                        this.lbl_Salida.Text = con.GetSerial();
                        salida= con.GetSerial();
                    }
                    Thread.Sleep(300);

                    //Establece la imagen que vera el usuario dependiendo de la accion que este indicando el arduino
                    switch (salida.Trim())
                    {
                        case "Detener":
                            pb_Salida.Image = GUI_Arduino.Properties.Resources.AmloPalomaStop;
                            break;
                        case "Derecha":
                            pb_Salida.Image = GUI_Arduino.Properties.Resources.AmloPalomaRight;
                            break;
                        case "Izquierda":
                            pb_Salida.Image = GUI_Arduino.Properties.Resources.AmloPalomaLeft;
                            break;
                        case "Avanzar":
                            pb_Salida.Image = GUI_Arduino.Properties.Resources.AmloPalomaFront;
                            break;
                        case "Retroceder":
                            pb_Salida.Image = GUI_Arduino.Properties.Resources.AmloRetroceder;
                            break;
                    }  
                }
            else
            {
                //Detiene el hilo
                isRunning = false;
                if (thread != null)
                    if (thread.IsAlive)
                        thread.Join();
            }
                  
        }


        //Apaga el modo Autonomo
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            btn_Encender.Visible = true;
            btn_Apagar.Visible = false;
            encendido = false;
            //Manda los comados de modo autonomo = false y para el auto
            con.Escribir('9');
            con.Escribir('N');
            //Detiene el hilo de lectura
            isRunning = false;
            if (thread.IsAlive)
                thread.Join();

            
        }
        //Radiobuttons de seleccion de distancia minima
        private void rdb_Dis1_CheckedChanged(object sender, EventArgs e)
        {
            con.Escribir('x');
            if (encendido == true)
                con.Escribir('0');
            else
                con.Escribir('9');

        }

        private void rdb_Dis2_CheckedChanged(object sender, EventArgs e)
        {
            con.Escribir('y');
            if (encendido == true)
                con.Escribir('0');
            else
                con.Escribir('9');
        }

        private void rdb_Dis3_CheckedChanged(object sender, EventArgs e)
        {
            con.Escribir('z');
            if (encendido == true)
                con.Escribir('0');
            else
                con.Escribir('9');
        }
        //Radiobuttons de seleccion de velocidades
        private void rdb_Lento_CheckedChanged(object sender, EventArgs e)
        {
            con.Escribir('d');
            if (encendido == true)
                con.Escribir('0');
            else
                con.Escribir('9');
        }

        private void rdb_Standard_CheckedChanged(object sender, EventArgs e)
        {
            con.Escribir('b');
            if (encendido == true)
                con.Escribir('0');
            else
                con.Escribir('9');
        }

        private void rdb_Rapido_CheckedChanged(object sender, EventArgs e)
        {
            con.Escribir('c');
            if (encendido == true)
                con.Escribir('0');
            else
                con.Escribir('9');
        }

        private void Automatico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(con.EstaAbierto()==true)
            {
                con.Escribir('9');
                con.Escribir('N');
            }
            
            isRunning = false;
            if(thread!=null)
                if (thread.IsAlive)
                    thread.Join();
        }
    }
}
