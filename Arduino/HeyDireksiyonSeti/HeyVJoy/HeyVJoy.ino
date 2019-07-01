#include <Arduino.h>
void setup() 
{ 
   Serial.begin(9600);
   pinMode(8,OUTPUT); //motor
   pinMode(9,OUTPUT);  //kirmizi
   pinMode(10,OUTPUT);  //yesil
   pinMode(11,OUTPUT);  //mavi
}

bool baglanildi;
int baslangic;
void loop() 
{
  if (Serial.read() == '+') baglanildi = true; 
  else if (baglanildi)
  {
    int girdi = analogRead(A2);
    String yazdir = "";
    // Direksiyon = "a";
    yazdir = "a" + String(analogRead(A0));
    // Vites = "v";
    if (girdi > 1020) yazdir += "b0";
    else if (girdi > 1009) yazdir += "b4"; 
    else if (girdi > 996) yazdir += "b1"; 
    else if (girdi > 986) yazdir += "b2";
    else if (girdi > 976) yazdir += "b5";
    else if (girdi > 926) yazdir += "b3";
    else if (girdi > 906) yazdir += "b6";
    else if (girdi > 846) yazdir += "b7";
    else if (digitalRead(3) == 1)  yazdir += "b8";
    else if (digitalRead(5) == 1)  yazdir += "b9";
    else yazdir += "b-";
  
    yazdir += "c";
    int fren = analogRead(A3);
    yazdir += (fren - 921);
    yazdir += "+";
    int gaz = analogRead(A5);
    yazdir += (gaz - 108);
    Serial.println(yazdir + "*");
    delay(0); //Yenileme Hizi

    if (millis() % random(100,1000) == 0)
    {
      analogWrite(9,random(0,255));
      analogWrite(10,random(0,255));
      analogWrite(11,random(0,255));
    }
    if (gaz < 700 && 275 < fren) digitalWrite(8,1);
    else digitalWrite(8,0);
  }
  else {
    digitalWrite(8,1);
    if (millis() % random(150,1000) == 0)
    {
      analogWrite(9,random(0,255));
      analogWrite(10,random(0,255));
      analogWrite(11,random(0,255));
    }
  }
}
