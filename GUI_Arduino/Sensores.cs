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
    public partial class Sensores : Form
    {
        //Objeto de la clase conexion
        private Conexion Con;
        //Objeto de la clase sensado
        private Sensado Sensado;
        //Arreglo de los valores de los sensores
        private int[] sensores;

        //Constructor
        public Sensores(Conexion con)
        {
            InitializeComponent();
            //Establece el objeto conexion
            Con = con;
            Sensado = new Sensado(Con);
            //Inicia el timer para mandar salidas
            tm_Sensores.Start();
        }

        //Eventos para saber si hay un chbox selecionado y así inicar el timer
        private void chb_Left_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Left.Checked == true || chb_Center.Checked == true || chb_Right.Checked == true)
                tm_Sensores.Start();
        }

        private void chb_Central_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Left.Checked == true || chb_Center.Checked == true || chb_Right.Checked == true)
                tm_Sensores.Start();
        }

        private void chb_Right_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Left.Checked == true || chb_Center.Checked == true || chb_Right.Checked == true)
                tm_Sensores.Start();
        }

        //Manda un comando al arduino para obtener la distancia de la combinacion de sensores escogidos
        private void Seleccion()
        {
            if (chb_Left.Checked && chb_Center.Checked && chb_Right.Checked)
            {
                Sensado.llamar("7");
            }
            else
            {
                if (chb_Left.Checked && chb_Center.Checked)
                {
                    Sensado.llamar("4");

                }
                else
                {
                    if (chb_Left.Checked && chb_Right.Checked)
                    {
                        Sensado.llamar("5");

                    }
                    else
                    {
                        if (chb_Center.Checked && chb_Right.Checked)
                        {
                            Sensado.llamar("6");

                        }
                        else
                        {
                            if (chb_Left.Checked)
                            {
                                Sensado.llamar("1");

                            }
                            else
                            {
                                if (chb_Center.Checked)
                                {
                                    Sensado.llamar("2");

                                }
                                else
                                {
                                    if (chb_Right.Checked)
                                    {
                                        Sensado.llamar("3");

                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }

                    }
                }
            }

        }

        //Evento que ejecuta el timer
        private void tm_Sensores_Tick(object sender, EventArgs e)
        {
            //Obtinene la salidas de los sensores y los establece en labels
            sensores = Sensado.serial();
            lbl_Izq.Text = sensores[0].ToString();
            lbl_Cen.Text = sensores[1].ToString();
            lbl_Right.Text = sensores[2].ToString();

            //Verifica que al menos un chbox este seleccionado
            if (chb_Left.Checked == true || chb_Center.Checked == true || chb_Right.Checked == true)
            {
                //Llama al metodo que manda un input a la clase sensado
                Seleccion();

                /*If's que establecen el valor de las progressbar, esto se calcula de rango maximo
                 de operacion del sensor, el maximo del progressbar y el valor dado por el sensor*/
                if (sensores[0] == 0)
                {

                    pgb_Izq.Value = 0;
                }
                else
                {
                    int tam = (sensores[0] * 100) / 250;
                    if (tam > 100)
                        tam = 100;
                    pgb_Izq.Value = tam;

                }

                if (sensores[2] == 0)
                {
                    pgb_Der.Value = 0;

                }
                else
                {
                    int tam = (sensores[2] * 100) / 250;
                    if (tam > 100)
                        tam = 100;
                    pgb_Der.Value = tam;

                }

                if (sensores[1] == 0)
                {
                    pgb_Cen.Value = 0;
                }
                else
                {
                    int tam = (sensores[1] * 100) / 250;
                    if (tam > 100)
                        tam = 100;
                    pgb_Cen.Value = tam;

                }


            }
            else
            {
                //Si no hay ningún sensor seleccionado se termina la ejecucion de timer
                tm_Sensores.Stop();
                pgb_Izq.Value = 0;
                pgb_Cen.Value = 0;
                pgb_Der.Value = 0;

                lbl_Izq.Text = "0";
                lbl_Cen.Text = "0";
                lbl_Right.Text = "0";

                Console.WriteLine("Se detuvo");
            }

        }
    }
    
}
