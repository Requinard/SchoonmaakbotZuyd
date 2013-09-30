#include <Stepper.h>
#include <Wire.h>

void setup()
{
    //4 stappenmotoren opzetten
    Stepper leftFront = Stepper(4, A0, A1, A2, A3);
    Stepper leftBehind = Stepper(3, 0, 1, 2, 3);
    Stepper rightFront = Stepper(4, 4, 5, 6, 7);
    Stepper rightBehind = Stepper(4, 8, 9, 10, 11);
    
    //I2C-bus joinen als slave met adress 2
    Wire.begin(0x02);
}

void loop()
{

  /* add main program code here */

}
