using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Arduino
{
    public class Conexion
    {
        //Atributos para puerto de coexión
        SerialPort Puerto;
        SerialPort Arduino = new SerialPort();
        //Atributo para saber si se esta leyendo la serial de Arduino
        private bool isReading = false;
        //Atributo para guardar la consola de Arduino
        private string line="";
       

        //Carga los nombres de los puertos COM
        public string[] CargarPuertos()
        {
            string[] PuertosSerial = SerialPort.GetPortNames();
            return PuertosSerial;
        }

        //Abre la conexión, verifica la misma e incia la lectura de la consola de Arduino
        public void Abrir(string puerto_seleccionado)
        {
            try
            {
                Arduino.PortName = puerto_seleccionado;
                Arduino.BaudRate = 9600;
                Arduino.Open();
                Console.WriteLine("Conectando....");

                Arduino.WriteTimeout = 10000;
                Arduino.ReadTimeout = 20000;
                Console.WriteLine("Escribiendo...");
                Arduino.Write("N");
                Console.WriteLine("Leyendo...");
                Arduino.ReadLine();
                isReading = true;
                Thread thread = new Thread(LeerDatosArduino);
                thread.Start();
                Console.WriteLine("Conectado");

            }
            catch (System.TimeoutException ex)
            {
                Arduino.Close();
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Cierra la conexión con Arduino
        public void Cerrar()
        {
            if (Arduino.IsOpen)
                Arduino.Close();
        }

        //Metódo para verificar si es que se esta conetado a un puerto COM
        public bool EstaAbierto()
        {
            if (Arduino.IsOpen)
                return true;
            else
                return false;
        }

        //Metódo para devolver un objeto de tipo SerialPort, es decir, el puerto del Arduino al que se esta coenctado

        public SerialPort PuertoArduino()
        {
            if (Arduino.IsOpen)
            {
                SerialPort PortArduino = Arduino;
                return PortArduino;
            }
            else
                return null;
        }

        //Función para mandar instrucciones de escritura a la serial de Arduino, funcionando como Inputs en Arduino
        public void Escribir(char Accion)
        {
            /*Distancias
            * ìîí
            * 
            * Velocidades
            * èêé
            */
            try
            {
                switch (Accion)
                {
                    case 'T':
                        Arduino.Write("T");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'Y':
                        Arduino.Write("Y");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'U':
                        Arduino.Write("U");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'I':
                        Arduino.Write("I");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'W':
                        Arduino.Write("W");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'A':
                        Arduino.Write("A");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'S':
                        Arduino.Write("S");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'D':
                        Arduino.Write("D");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '1':
                        Arduino.Write("1");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '2':
                        Arduino.Write("2");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '3':
                        Arduino.Write("3");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '4':
                        Arduino.Write("4");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '5':
                        Arduino.Write("5");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '6':
                        Arduino.Write("6");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '7':
                        Arduino.Write("7");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '0':
                        Arduino.Write("0");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'x':
                        Arduino.Write("x");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'y':
                        Arduino.Write("y");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'z':
                        Arduino.Write("z");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'd':
                        Arduino.Write("d");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'b':
                        Arduino.Write("b");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case 'c':
                        Arduino.Write("c");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    case '9':
                        Arduino.Write("9");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                    default:
                        Arduino.Write("N");
                        Console.WriteLine("Se realizo la accion: " + Accion);
                        break;
                }
           
            }
            catch (System.TimeoutException ex)
            {
                Arduino.Close();
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                form_Principal form_Principal = new form_Principal();
            }

        }

        //Metódo para devolver la salida de Arduino
        public string GetSerial()
        {
            return line;
        }

        //Hilo que lee la consola serial de Arduino
        private void LeerDatosArduino()
        {
            if(Arduino.IsOpen)
                while (isReading)
                {
                    try
                    {
                        string linea = Arduino.ReadLine();
                        Console.WriteLine("Datos recibidos: " + linea);
                        line = linea;
                    
                    }
                    catch (TimeoutException tm)
                    {
                        Console.WriteLine(tm);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al leer datos: " + ex.Message);
                    
                    }
                }
            else
            {
               DetenerLectura();
            }
  
        }

        //Metodo para detener el hilo de lectura cambiando el atributo "isReading" a false
        public void DetenerLectura()
        {
            isReading = false;
            if (Arduino.IsOpen)
                Arduino.Close();
        }
    }
}
