//Libreria del modulo Bluetooth
#include <SoftwareSerial.h>
//Pines del modulo Bluetooth
SoftwareSerial Blue(12,13);

// Pines de los motores
#define MotorLeft_P1 8
#define MotorLeft_P2 9

#define MotorRight_P1 10
#define MotorRight_P2 11

// Límites de velocidad
int MaxSpeed =200;
int MinSpeed =40;

// Pines Sensores
#define CenterTrig 2
#define LeftTrig 4
#define RightTrig 6

#define CenterEcho 3
#define LeftEcho 5
#define RightEcho 7

//Limites de distancia
int MaxDistance =40;
int MinDistance =10;

//Modo autonomo
bool Auto=false;


void setup() {
  //Inicialización de los seriales
  Serial.begin(9600);
  Blue.begin(9600);

  //Inicialización de los pines de los motores, como outputs
  pinMode(MotorLeft_P1, OUTPUT);
  pinMode(MotorLeft_P2, OUTPUT);
  pinMode(MotorRight_P1, OUTPUT);
  pinMode(MotorRight_P2, OUTPUT);

  //Inicialización de Triggers sensores
  pinMode(CenterTrig,OUTPUT);
  pinMode(LeftTrig,OUTPUT);
  pinMode(RightTrig,OUTPUT);

  //Inicialización de Echos Sensores
  pinMode(CenterEcho,INPUT);
  pinMode(LeftEcho,INPUT);
  pinMode(RightEcho,INPUT);

}

void loop() {

  if (!Blue.isListening()) {
    // Si el módulo Bluetooth no está emparejado, ejecutar comandos 9 y N
    Blue.println("9");
    Blue.println("N");
    Serial.println("Bluetooth sin emparejar");
    delay(1000);
  }

  if(Blue.available()>0)
  {
    char Accion=Blue.read();
    switch (Accion) 
    {
       case 'X':
        Blue.println("h");       
        break;
        case 'T':
        Motor_Der_Adelante();
        Blue.println("");
        delay(300);        
        break;
        case 'Y':
        Motor_Der_Atras();
        Blue.println("");
        delay(300);
        break;
        case 'U':
        Motor_Izq_Adelante();
        Blue.println("");
        delay(300);
        break;
      case 'I':
        Motor_Izq_Atras();
        Blue.println("");
        delay(300);
        break;
      case 'W':
        Motor_Der_Adelante();
        Motor_Izq_Adelante();
        Blue.println("");
        delay(300);
        break;
      case 'S':
        Motor_Der_Atras();
        Motor_Izq_Atras();
        Blue.println("");
        delay(300);
        break;
      case 'D':
        Motor_Izq_Atras();
        Motor_Der_Adelante();
        Blue.println("");
        delay(300);
        break;
      case 'A':
        Motor_Izq_Adelante();
        Motor_Der_Atras();
        Blue.println("");
        delay(300);
        break;
      case '1':
        LeftSensor();
        Blue.println(" ");
        break;
      case '2':
        CenterSensor();
        Blue.println(" ");
        break;
      case '3':
        RightSensor();
        Blue.println(" ");
        break;
      case '4':
        LeftCenter();
        break;
      case '5':
        LeftRight();
        break;
      case '6':
        CenterRight();
        break;
      case '7':
        AllSensor();
        break;
      case 'd':
        MaxSpeed= 130;
        break;
      case 'b':
         MaxSpeed= 190;
        break;
      case 'c':
         MaxSpeed= 250;
        break;
      case 'x':
        MinDistance=3;
        break; 
      case 'y':
        MinDistance=10;
        break;
      case 'z':
        MinDistance=15;
        break;
      case '0':
          Auto=true;
        break;
      case '9':
          Auto=false;
        break;                                                                              
      default:
        Detener();
        Blue.println("");
        break;
    }
     Serial.println(Accion);
  }
  delay(20);
  if(Auto==true)
  {
     Autonomous();
     delay(1000);
  }
   
}


//Funciones del motor derecho
void Motor_Der_Adelante()
{
  analogWrite(MotorRight_P1, MaxSpeed);
  analogWrite(MotorRight_P2,LOW);
}

void Motor_Der_Atras()
{
  analogWrite(MotorRight_P1, LOW);
  analogWrite(MotorRight_P2,MaxSpeed);
}


//Funciones del motor izquierdo
void Motor_Izq_Adelante()
{
  analogWrite(MotorLeft_P1, MaxSpeed);
  analogWrite(MotorLeft_P2, LOW);
}

void Motor_Izq_Atras()
{
  analogWrite(MotorLeft_P1, LOW);
  analogWrite(MotorLeft_P2, MaxSpeed);
}

void Detener()
{
  analogWrite(MotorLeft_P1, LOW);
  analogWrite(MotorLeft_P2, LOW);
  analogWrite(MotorRight_P1, LOW);
  analogWrite(MotorRight_P2, LOW);
}

//Funciones calculo distancia
int CenterDistanceSensor()
{
  //Envía un pulso ultrasonico
  digitalWrite(CenterTrig,LOW);
  delayMicroseconds(2);
  digitalWrite(CenterTrig,HIGH);
  delayMicroseconds(10);
  digitalWrite(CenterTrig,LOW);

  //Lee el tiempo que tarda en llegar el pulso
  long t=pulseIn(CenterEcho,HIGH);
  //Convierte el tiempo en cm, calculando el tiempo entre una constante de el sonido en el aire
  int cm=t/29/2;
  return cm;
}

int LeftDistanceSensor()
{
  //Envía un pulso ultrasonico
  digitalWrite(LeftTrig,LOW);
  delayMicroseconds(2);
  digitalWrite(LeftTrig,HIGH);
  delayMicroseconds(10);
  digitalWrite(LeftTrig,LOW);

  //Lee el tiempo que tarda en llegar el pulso
  long t=pulseIn(LeftEcho,HIGH);
  //Convierte el tiempo en cm, calculando el tiempo entre una constante de el sonido en el aire
  int cm=t/29/2;
  return cm;
}

int RightDistanceSensor()
{
  //Envía un pulso ultrasonico
  digitalWrite(RightTrig,LOW);
  delayMicroseconds(2);
  digitalWrite(RightTrig,HIGH);
  delayMicroseconds(10);
  digitalWrite(RightTrig,LOW);

  //Lee el tiempo que tarda en llegar el pulso
  long t=pulseIn(RightEcho,HIGH);
  //Convierte el tiempo en cm, calculando el tiempo entre una constante de el sonido en el aire
  int cm=t/29/2;
  return cm;
}


//Funciones de impresion de Sensores
void CenterSensor()
{
  int DC=CenterDistanceSensor();
  Serial.println("C:" + String(DC) + ",");
  Blue.print("C:" + String(DC) + ",");


}

void LeftSensor()
{
  int DL=LeftDistanceSensor();
  Serial.println("L:" + String(DL) + ",");
  Blue.print("L:" + String(DL) + ",");
}


void RightSensor()
{
  int DR=RightDistanceSensor();
  Serial.println("R:" + String(DR) + ",");
  Blue.print("R:" + String(DR) + ",");
}


void LeftCenter()
{
  LeftSensor();
  CenterSensor();
  Blue.println(" ");
}

void LeftRight()
{
  LeftSensor();
  RightSensor();
  Blue.println(" ");

}

void CenterRight()
{
  CenterSensor();
  RightSensor();
  Blue.println(" ");

}

void AllSensor()
{
  LeftSensor();
  CenterSensor();
  RightSensor();
  Blue.println(" ");

}

//Funcion para el auto de manera autonoma
void Autonomous()
{
  //Uso de las funciones de distancia para guardarlas en variable
  int Delante=CenterDistanceSensor();
  int Izquierda=LeftDistanceSensor();
  int Derecha=RightDistanceSensor();

  if(Delante < MinDistance)
  {
    //El auto esta dentro del limite inferior
    Motor_Der_Atras();
    Motor_Izq_Atras();
    Blue.println("Retroceder");
    Serial.println("Retroceder");
  }
  else
  {
    //El auto tiene el obstaculo enfrente
    if(Delante < Izquierda && Delante < Derecha && Delante < MaxDistance)
    {
      Motor_Der_Adelante();
      Motor_Izq_Adelante();
      Blue.println("Avanzar");
      Serial.println("Avanzar");

    }
    else
    {
      //Primero se evalua si el obstaculo esta más cerca de la izquierda
      if(Izquierda < Derecha && Izquierda < MaxDistance)
      {
        Motor_Izq_Adelante();
        Motor_Der_Atras();
        Blue.println("Izquierda");
        Serial.println("Izquierda");

      }
      else
      {
        //Se verifica si la derecha esta dentro del rango maximo al que puede seguir
        if(Derecha < MaxDistance)
        {
          Motor_Der_Adelante();
          Motor_Izq_Atras();
          Blue.println("Derecha");
          Serial.println("Derecha");
        }
        else
        {
          Detener();
          Blue.println("Detener");
          Serial.println("Detener");

        }
      }
    }
  }
}

