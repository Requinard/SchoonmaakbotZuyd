#include <Wire.h>
#include "Queue.h"

//Defines
#define PIN8 8
#define PIN9 9
#define PIN10 10
#define PIN11 11
#define PIN12 12
#define PIN13 13

//Globale variabelen declareren
//Scheduler
Queue scheduler;
//Rotatie voor scheduler
bool stopRotationBool;

int serialReceive(unsigned long time);
int stopRotation(unsigned long time);
void pintWrite(int, unsigned long);
