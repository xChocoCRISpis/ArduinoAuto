using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Arduino
{
    public class Sensado
    {
        //Objeto de la clase conexion
        Conexion Conexion;
        //Atributos de distancias
        private int distanciaCenter = 0;
        private int distanciaIzquierda = 0;
        private int distanciaDerecha = 0;

        //Constructor
        public Sensado(Conexion con)
        {
            Conexion = con;
        }
        //Manda un input a la clase conexion
        public void llamar(string valor)
        {
            if (Conexion.EstaAbierto() == true)
            {
                Console.WriteLine(valor);
                Conexion.Escribir(Convert.ToChar(valor));
                //Ejecuta el metodo salida para escribir la consola y leer la serial de arduino
                salida();
            }
        }

        private void salida()
        {
            //Llama a la función leer y escribe el resultado en la consola
            Leer();
            int[] datos = { distanciaIzquierda, distanciaCenter, distanciaDerecha };
            Console.WriteLine("Izq: " + distanciaIzquierda + "Cen: " + distanciaCenter + "Der: " + distanciaDerecha);
        }

        //Retorna los valores obtenidos de la serial de arduino
        public int[] serial()
        {
            int[] datos = { distanciaIzquierda, distanciaCenter, distanciaDerecha };
            return datos;
        }

        //Thread que lee la consola de arduino
        public void Leer()
        {
            if (Conexion.EstaAbierto())
            {
                //Establece las ditancias en 0
                this.distanciaCenter = 0;
                this.distanciaIzquierda = 0;
                this.distanciaDerecha = 0;
                string salida;
                //Obtine la salida de arduino con la clase conexion
                salida = Conexion.GetSerial();
                //Algorimtos para separas la cadenas de Arduino y asignarlas al parámetro del sensor correspondiente
                // Verificar si la cadena contiene información del sensor Central
                if (salida.Contains("C:"))
                {
                    int inicio = salida.IndexOf("C:") + "C:".Length;
                    int fin = salida.IndexOf(",", inicio);

                    string valor = salida.Substring(inicio, fin - inicio).Trim();

                    if (int.TryParse(valor, out int distanciaCentral))
                    {
                        this.distanciaCenter = distanciaCentral;
                    }

                }
                // Verificar si la cadena contiene información del sensor Izquierdo
                if (salida.Contains("L:"))
                {
                    int inicio = salida.IndexOf("L:") + "L:".Length;
                    int fin = salida.IndexOf(",", inicio);

                    string valor = salida.Substring(inicio, fin - inicio).Trim();

                    if (int.TryParse(valor, out int distanciaIzquierda))
                    {
                        this.distanciaIzquierda = distanciaIzquierda;
                    }
                }
                // Verificar si la cadena contiene información del sensor Derecho
                if (salida.Contains("R:"))
                {
                    int inicio = salida.IndexOf("R:") + "R:".Length;
                    int fin = salida.IndexOf(",", inicio);

                    string valor = salida.Substring(inicio, fin - inicio).Trim();

                    if (int.TryParse(valor, out int distanciaDerecha))
                    {
                        this.distanciaDerecha = distanciaDerecha;
                    }
                }
            }
        }

    }
}
