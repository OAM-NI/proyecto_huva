#include <Adafruit_Sensor.h>
#include <DHT.h>
#include <DHT_U.h>

///////// SENSOR DE TEMPERATURA/////////////////7
#include "DHT.h"

#define DHTPIN 12     // what digital pin we're connected to


#define DHTTYPE DHT11   // DHT 22  (AM2302), AM2321
DHT dht(DHTPIN, DHTTYPE);



//////// sensor de PH///////////////////////////////7
#include <Wire.h>

float calibration_value = 26.34;
int phval = 0;
unsigned long int avgval;
int buffer_arr[10], temp;

String str_data;


void setup() {


Serial.begin(115200);
dht.begin();
  
}

void loop() {
  

///// sensor de ph/////

for (int i = 0; i < 10; i++)
  {
    buffer_arr[i] = analogRead(A0);
    delay(30);
  }
  for (int i = 0; i < 9; i++)
  {
    for (int j = i + 1; j < 10; j++)
    {
      if (buffer_arr[i] > buffer_arr[j])
      {
        temp = buffer_arr[i];
        buffer_arr[i] = buffer_arr[j];
        buffer_arr[j] = temp;
      }
    }
  }
  avgval = 0;
  for (int i = 2; i < 8; i++)
    avgval += buffer_arr[i];
  float volt = (float)avgval * 5.0 / 1024 / 6;
  uint32_t ph_act = -5.70 * volt + calibration_value;
  





//////sensor de temperatura y humedad//////


  uint32_t h = dht.readHumidity();
 
  uint32_t t = dht.readTemperature();
  
  uint32_t f = dht.readTemperature(true);

  

  
  float hif = dht.computeHeatIndex(f, h);
 
  float hic = dht.computeHeatIndex(t, h, false);

 //Serial.print("Humidity: ");
  Serial.print(h);  Serial.print("A");
  //Serial.print(" %\t");
 // Serial.print("Temperature: ");
  Serial.print(t);  Serial.print("B");
  //Serial.print(" *C ");
  Serial.print(f);    Serial.print("C");
  //Serial.print(" *F\t");

//imprecio de medicion de pH
Serial.print(ph_act);  Serial.print("D");

Serial.print(1023);  Serial.print("E");


 str_data="Activado";
Serial.print(str_data);  Serial.print("F");
  
  
Serial.print("\n");

delay(100);

}










  
    
    
   

    
    
    
