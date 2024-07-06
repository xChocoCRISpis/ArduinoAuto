using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Arduino
{
    internal class Controles
    {
        //Atributo para verificar que el control esta encendido
        private bool encendido = false;
        //Objeto de la clase conexion
        private Conexion Conexion;

        //Constructor para pasarle un objeto de la clase Conexion
        public Controles(Conexion conexion)
        {
            Conexion = conexion;
        }

        //Metodo para verificar si la tecla que se presiono es válida para mandar Inputs a Arduino
        public bool TeclaFlecha(Keys tecla)
        {
            if (encendido == true)
                switch (tecla)
                {
                    case Keys.W:
                        return true;
                    case Keys.S:
                        return true;
                    case Keys.D:
                        return true;
                    case Keys.A:
                        return true;
                    default:
                        return false;
                }
            else
                return false;
        }

        //Metodo para encenedr el control
        public bool Encender(Keys tecla)
        {
            if (tecla == Keys.Space)
            {
                encendido = !encendido;
                return encendido;
            }
            return false;
        }
        //Metodo para mandar los inputs a la clase conexion y que esta a su vez mande los inputs a Arduino

        public void Salida(Keys tecla)
        {
            if (Conexion.EstaAbierto() == true)
                if (encendido == true)
                    switch (tecla)
                    {
                        case Keys.W:
                            Conexion.Escribir('W');
                            break;
                        case Keys.S:
                            Conexion.Escribir('S');
                            break;
                        case Keys.A:
                            Conexion.Escribir('A');
                            break;
                        case Keys.D:
                            Conexion.Escribir('D');
                            break;
                        case Keys.N:
                            Conexion.Escribir('N');
                            break;
                    }
                else
                    Console.WriteLine("Apagado");
            else
                Console.WriteLine("Cerrado");
        }
       
    }
}
