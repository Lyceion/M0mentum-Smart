#include <Servo.h>
String inputString = "";
boolean stringComplete = false;
String commandString = "";
int servoPin = 12;
boolean isConnected = false;
Servo srv;

void setup() {  
  Serial.begin(9600);
  srv.attach(servoPin);
}


boolean getSrvState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(1,5);
  }
}

//String getTextToPrint()
//{
//  String value = inputString.substring(5,inputString.length()-2);
//  return value;
//}


void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

void loop() {
if(stringComplete)
{
stringComplete = false;
getCommand();
  if(commandString.equals("STAR"))
    {
      srv.write(180);
    }
  if(commandString.equals("STOP"))
    {
      srv.write(0);   
    }
  else if(commandString.equals("TEST"))
    {
      srv.write(75);
    }
  else if(commandString.equals("SRV1"))
    {
      boolean SrvState = getSrvState();
      if(SrvState == true)
        {
          srv.write(45);
      }else
        {
        srv.write(180);
        }   
    }
  else if(commandString.equals("SRV2"))
    {
      boolean SrvState = getSrvState();
      if(SrvState == true)
        {
          srv.write(90);
        }else
        {
        srv.write(135);
        }   
    }
}
}


