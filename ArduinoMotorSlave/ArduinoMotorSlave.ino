#include "ArduinoMotorSlave.h"

void setup() 
{
	//Schedule testfunctions
    myQueue.scheduleFunction(testFunction, "Test", 1000, 100);
	myQueue.scheduleFunction(test2, "Test#2", 1001, 500);

	//Seriëel initialiseren
	Serial.begin(9600);

	//Wire initialiseren
	Wire.begin(0x02);
}

void loop() 
{
	myQueue.Run(millis());
}

int testFunction(unsigned long now)
{
	Serial.print("hello");
	Serial.println(now);
	return now;
}

int test2(unsigned long now)
{
	Serial.print("WERKT HIJ WEL NORMAAL ");
	Serial.println(now);
	return 0;
}

int readI2C(unsigned long now)
{
	char buffer[50] = {};
	Wire.readBytes(buffer, 50)
}