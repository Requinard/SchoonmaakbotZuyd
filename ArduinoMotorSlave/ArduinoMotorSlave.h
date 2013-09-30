#include <Wire.h>
#include <Stepper.h>
#include "Queue.h"

//Globale variabelen declareren
//Stappenmotoren
Stepper leftFront = Stepper(200, A0, A1);
Stepper leftBehind = Stepper(200, A2, A3);
Stepper rightFront = Stepper(200, 6, 7);
Stepper rightBehind = Stepper(200, 8, 9);
//Scheduler
Queue myQueue;

int testFunction(unsigned long);
int test2(unsigned long);
int readI2C(unsigned long);
