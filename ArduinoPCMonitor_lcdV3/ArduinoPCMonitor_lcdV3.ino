
#include <Adafruit_GFX.h>
#include <MCUFRIEND_kbv.h>


#define BLACK 0x0000
#define NAVY 0x000F
#define DARKGREEN 0x03E0
#define DARKCYAN 0x03EF
#define MAROON 0x7800
#define PURPLE 0x780F
#define OLIVE 0x7BE0
#define LIGHTGREY 0xC618
#define DARKGREY 0x7BEF
#define BLUE 0x001F
#define GREEN 0x07E0
#define CYAN 0x07FF
#define RED 0xF800
#define MAGENTA 0xF81F
#define YELLOW 0xFFE0
#define WHITE 0xFFFF
#define ORANGE 0xFD20
#define GREENYELLOW 0xAFE5
#define PINK 0xF81F


// LCD pins 
#define LCD_CS A3 // Chip Select goes to Analog 3
#define LCD_CD A2 // Command/Data goes to Analog 2
#define LCD_WR A1 // LCD Write goes to Analog 1
#define LCD_RD A0 // LCD Read goes to Analog 0
#define LCD_RESET A4 // Can alternately just connect to Arduino's reset pin

#define cpu_pkg_loc 80,0
#define gpuloadloc 250,0
#define ramloc 400,0

#define cputemploc 00,35
#define cpupwrloc 0,60

#define gputemploc 175,35
#define gpumemusedloc 175,60

#define gpuramloc 380,110
#define gpufanloc 380,140
#define gpuclockloc 380,170
#define ssdtemploc 380,200
#define ssdtbwloc 380,230

#define cpu1loc 40,150
#define cpu2loc 40,180
#define cpu3loc 40,210
#define cpu4loc 40,240
#define cpu5loc 160,150
#define cpu6loc 160,180
#define cpu7loc 160,210
#define cpu8loc 160,240












String cpu_pkg_load, cpu_pkg_temp, cpu_c1, cpu_c2, cpu_c3, cpu_c4, cpu_c5, cpu_c6, cpu_c7, cpu_c8,cpu_power;

String gpu_load, gpu_temp, gpu_ram,sys_ram, gpu_fan, gpu_clock, ssd_temp, ssd_tbw;

float gpumemuse1;
int  gpu_memused;

char c;



MCUFRIEND_kbv tft(A3, A2, A1, A0, A4);  



void setup() {

uint16_t ID = tft.readID();
tft.begin(ID);
tft.fillScreen(BLACK); 

tft.setRotation(1);
tft.setTextSize(2);

tft.drawFastHLine(0,90,480,MAROON);
tft.drawFastHLine(0,91,480,MAROON);
tft.drawFastHLine(0,92,480,MAROON);
tft.drawFastHLine(0,93,480,MAROON);
tft.drawFastHLine(0,94,480,MAROON);
tft.drawFastHLine(0,95,480,MAROON);
tft.drawFastVLine(220,95,180,MAROON);
tft.drawFastVLine(221,95,180,MAROON);
tft.drawFastVLine(222,95,180,MAROON);
tft.drawFastHLine(0,275,480,MAROON);
tft.drawFastHLine(0,276,480,MAROON);
tft.drawFastHLine(0,277,480,MAROON);
tft.drawFastHLine(0,278,480,MAROON);
tft.drawFastHLine(0,279,480,MAROON);
tft.drawFastHLine(0,280,480,MAROON);
// Setup serial
Serial.begin(9600);
tft.setTextColor(GREENYELLOW, BLACK);
 tft.setTextSize(2);
 tft.setCursor(20,300);
  tft.print("i7 9700k @ 5GHZ");
  tft.setCursor(240,300);
  tft.print("RTX 2080 Super");

tft.setTextColor(GREEN, BLACK);

      tft.setTextSize(3);  //Set text size big
      
      tft.setCursor(0,0);
      tft.print("CPU ");


      tft.setCursor(175,0);
      tft.print("GPU ");

      tft.setCursor(330,0);
      tft.print(" RAM ");
      
//tft.setTextColor(WHITE, BLACK);
      tft.setTextSize(2); //set text size small
      
      tft.setCursor(0,150);
      tft.print("C1: ");

      tft.setCursor(0,180);
      tft.print("C2: ");

      tft.setCursor(0,210);
      tft.print("C3: ");

      tft.setCursor(0,240);
      tft.print("C4: ");

      tft.setCursor(110,150);
      tft.print("C5: ");

      tft.setCursor(110,180);
      tft.print("C6: ");

      tft.setCursor(110,210);
      tft.print("C7: ");

      tft.setCursor(110,240);
      tft.print("C8: ");

                
      tft.setCursor(260,110);
      tft.print("GPU Mem: ");

      tft.setCursor(260,140);
      tft.print("GPU fan: ");

      tft.setCursor(260,170);
      tft.print("GPU clk: ");

       tft.setCursor(260,200);
      tft.print("SSD Temp: ");

       tft.setCursor(260,230);
      tft.print("SSD TBW: ");

      tft.setCursor(0,110);
      tft.print("CPU Core Util. % ");

     

     


}



void loop() 
{


    if (Serial.available()) 
    {  
      char c = Serial.read();
      if (c == '@')
      {     
      cpu_pkg_load=  Serial.parseInt();
      cpu_c1=Serial.parseInt();
      cpu_c2=Serial.parseInt();
      cpu_c3=+Serial.parseInt();
      cpu_c4=Serial.parseInt();
      cpu_c5=Serial.parseInt();
      cpu_c6=Serial.parseInt();
      cpu_c7=Serial.parseInt();
      cpu_c8=Serial.parseInt();
      gpu_ram=Serial.parseInt();
      gpu_temp=Serial.parseInt();
      gpu_fan=Serial.parseInt();
      gpu_clock=Serial.parseInt();
      gpu_load=Serial.parseInt();
  
    cpu_power=Serial.parseInt();
      
      cpu_pkg_temp=Serial.parseInt();
       ssd_temp=Serial.parseInt();
       ssd_tbw=Serial.parseInt();
      
     
   
     sys_ram=Serial.parseInt();
        gpu_memused=Serial.parseInt();

      
        
      tft.setTextColor(YELLOW, BLACK);
      tft.setTextSize(3);
      tft.setCursor(cpu_pkg_loc);
      tft.print(cpu_pkg_load + "% ");

      tft.setCursor(gpuloadloc);
      tft.print(gpu_load+ "% ");

      tft.setCursor(ramloc);
     tft.print(" " +sys_ram+ "%");

     tft.setTextSize(2);

      tft.setCursor(cpu1loc);
      tft.print(cpu_c1+ " ");

      tft.setCursor(cpu2loc);
      tft.print(cpu_c2+ " ");

      tft.setCursor(cpu3loc);
      tft.print(cpu_c3+ " ");

      tft.setCursor(cpu4loc);
      tft.print(cpu_c4+ " ");

      tft.setCursor(cpu5loc);
      tft.print(cpu_c5+ " ");

      tft.setCursor(cpu6loc);
      tft.print(cpu_c6+ " ");

      tft.setCursor(cpu7loc);
      tft.print(cpu_c7+ " ");

      tft.setCursor(cpu8loc);
      tft.print(cpu_c8+ " ");

      tft.setCursor(gpuramloc);
      tft.print(gpu_ram+ " % ");

        tft.setCursor(gputemploc);
      tft.print(gpu_temp+ " deg C ");

      tft.setCursor(gpufanloc);
      tft.print(gpu_fan+ " % ");

      tft.setCursor(gpuclockloc);
      tft.print(gpu_clock+ " Mhz");
        
  gpumemuse1=float(gpu_memused)/1000;
      tft.setCursor(gpumemusedloc);
    tft.print( String(gpumemuse1) + "/8.00 GB" );

    tft.setCursor(cputemploc);
   tft.print(cpu_pkg_temp + " deg C");

    tft.setCursor(cpupwrloc);
     tft.print(cpu_power + " Watts ");

     tft.setCursor(ssdtemploc);
     tft.print(ssd_temp + " deg C");

tft.setCursor(ssdtbwloc);
    tft.print(ssd_tbw + " GB");

     

      
      } 
    /*else if (c!='@')
    {     
     tft.print("Nvidia RTX 2080 Super");
    }*/
    }
}
