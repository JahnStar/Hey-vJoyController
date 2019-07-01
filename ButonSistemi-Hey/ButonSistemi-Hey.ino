//==============================================================================================================================================//
//================================================================[KUTUPHANELER]================================================================//
#include <SPI.h>

//==============================================================================================================================================//
//==============================================================================================================================================//
int buton_pin = 8;

//==[Aktif-Bellek]==//
unsigned long zaman, sonZaman, zaman2, sonZaman2;
int buton_durum_teyit;

bool buton_basildi;
//==============================================================================================================================================//
//=================================================================[KONTROLLER]=================================================================//
int ButonaKackereBasildi(int butonPin, unsigned long ciftBasmaSuresi_MiliSaniye, unsigned long uzunBasmaSuresi_MiliSaniye)
{
  int dondur = 0;
  if (buton_durum_teyit == 1 ) buton_durum_teyit = 2;

  if (digitalRead(butonPin) == HIGH)
  {     
    // :basiliyor:
    dondur = 4;
    if (buton_durum_teyit == 0) sonZaman2 = millis() + uzunBasmaSuresi_MiliSaniye;
    zaman2 = millis();

    buton_durum_teyit = 1; 
  }
  else if (buton_durum_teyit == 2)
  {
    if (zaman < sonZaman) 
    {
      // :cift basildi:
      dondur = 2;
      zaman = 0;
      sonZaman = 0;
    }
    else 
    { 
      // :tek basildi:
      dondur = 1;
      zaman = 1;
      sonZaman = millis() + ciftBasmaSuresi_MiliSaniye;
    }
    sonZaman2 = 0;
    buton_durum_teyit = 0;
  }

  if (0 < zaman && zaman < sonZaman) zaman = millis();
  else
  { 
    sonZaman = 0; 
    zaman = 0;
  }

  if (zaman2 > sonZaman2 && sonZaman2 > 0) dondur = 3;

  return dondur;

  // - bilgi -
  // (dondur == 0) => basilmiyor
  // (dondur == 1) => tek basma
  // (dondur == 2) => cift basma
  // (dondur == 3) => uzun basma
  // (dondur == 4) => basiliyor
}

//==================================================================[ISLEMLER]==================================================================//
void ButonaTekBasildiysa()
{
  Serial.println("tek basildi");
}

void ButonaCiftBasildiysa()
{
  Serial.println("cift basildi");
}

void ButonaUzunBasildiysa()
{
  Serial.println("uzun basildi");
}

void ButonaBasiliyorsa()
{
  Serial.println("basiliyor");
}

//==============================================================================================================================================//
//==============================================================================================================================================//
void setup() 
{
  //==[Islemler]==//
  Serial.begin(9600);
  SPI.begin();

  //==[Atamalar]==//
  pinMode(buton_pin, INPUT);
}

void loop() 
{
  int butonBasmaSayisi = ButonaKackereBasildi(buton_pin, 250, 750);
  if (butonBasmaSayisi == 1) ButonaTekBasildiysa();
  else if (butonBasmaSayisi == 2) ButonaCiftBasildiysa();
  else if (butonBasmaSayisi == 3) ButonaUzunBasildiysa();
  else if (butonBasmaSayisi == 4) ButonaBasiliyorsa();
}
//==============================================================================================================================================//
//==============================================================================================================================================//
