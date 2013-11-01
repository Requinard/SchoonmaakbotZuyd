#include "ArduinoMotorSlave.h"

void setup()
{
	stopRotationBool = false;
	Serial.begin(9600);

	pinMode(PIN2, OUTPUT);
	pinMode(PIN3, OUTPUT);
	pinMode(PIN4, OUTPUT);
	pinMode(PIN5, OUTPUT);
	pinMode(PIN6, OUTPUT);
	pinMode(PIN7, OUTPUT);
	pinMode(PIN8, OUTPUT);
	pinMode(PIN9, OUTPUT);
	pinMode(PIN10, OUTPUT);
	pinMode(PIN11, OUTPUT);
	pinMode(PIN12, OUTPUT);
}

void loop()
{	
	unsigned long time = millis();
	stopRotation(time);
	serialReceive(time);


	if(time % 10000 == 0)
	{
		Serial.println("10 seconden voorbij");
		delay(10);
	}
}

//Leest de serieële poorten en schedult functies
int serialReceive(unsigned long time)
{
	//Kijkt of er data in de buffer staat
	if(Serial.peek() != -1)
	{
		//Data inlezen
		char data[10] = {};
		Serial.readBytes(data, 10);

		switch(data[0])
		{
			case '0':
				togglePin(PIN2, time);
				break;
			case '1':
				togglePin(PIN3, time);
				break;
			case '2':
				togglePin(PIN4, time);
				break;
			case '3':
				togglePin(PIN5, time);
				break;
			case '4':
				togglePin(PIN6, time);
				break;
			case '5':
				togglePin(PIN7, time);
				break;
			case '6':
				togglePin(PIN8, time);
				break;
			case '7':
				togglePin(PIN9, time);
				break;
			case '8':
				togglePin(PIN10, time);
				break;
			case '9':
				togglePin(PIN11, time);
				break;
			default:
				break;
		}

		Serial.flush();
	}
	/*else
		Serial.println("Niks te zien");*/

	//Serial.println("Serieel gelezen");
}

//Schrijft hoog naar een pin en schedult het verwijderen van de hoog
void togglePin(int pin, unsigned long time)
{
	int pinRead = digitalRead(pin);

	if(pinRead == LOW)
	{
		digitalWrite(pin, HIGH);

		Serial.println("Pin aangezet");
		Serial.println(pin);
		Serial.println(time);
	}
	else if (pinRead == HIGH)
	{
		digitalWrite(pin, LOW);
	
		Serial.println("Pin uitgezet");
		Serial.println(pin);
		Serial.println(time);
	}
	else
		Serial.println("what de fuck");
}

//Stop rotatie als tijd deelbaar is door 500
int stopRotation(unsigned long time)
{
	if(time % 2000 == 0)
	{
		/*Serial.println("Pinnen gaan uit");
		Serial.println(stopRotationBool);

		for(int i = 0; i < 10; i++)
			digitalWrite(i, LOW);

		Serial.println("Pin Uitgezet");
		Serial.println(millis());

		stopRotationBool = false;*/
	}
	return 1;
}