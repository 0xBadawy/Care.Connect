#include <Adafruit_Fingerprint.h>


#if (defined(__AVR__) || defined(ESP8266)) && !defined(__AVR_ATmega2560__)
// For UNO and others without hardware serial, we must use software serial...
// pin #2 is IN from sensor (GREEN wire)
// pin #3 is OUT from arduino  (WHITE wire)
// Set up the serial port to use softwareserial..
SoftwareSerial mySerial(2, 3);

#else
// On Leonardo/M0/etc, others with hardware serial, use hardware serial!
// #0 is green wire, #1 is white
#define mySerial Serial1
    #endif
    
    int triggerPin = 7; //triggering on pin 7
    int echoPin = 8;    //echo on pin 8
    int LED = 13; //led pin
    int info = 0;//variable for the information comming from the bluetooth module
    int state = 0;//simple variable for displaying the state


Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

void setup()
{
  Serial.begin(9600);

   pinMode(triggerPin, OUTPUT); //defining pins
   pinMode(echoPin, INPUT);
   pinMode(LED, OUTPUT);    //defining LED pin
   digitalWrite(LED, LOW);  //once the programm starts, it's going to turn of the led, as it can be missleading.
  

  
  while (!Serial);  // For Yun/Leo/Micro/Zero/...
  delay(100);
 // Serial.println("");

  // set the data rate for the sensor serial port
  finger.begin(57600);
  delay(5);
  if (finger.verifyPassword()) {
  //  Serial.println("");
  } else {
//    Serial.println("");
    while (1) { delay(1); }
  }

 // Serial.println(F(""));
  finger.getParameters();/*
  Serial.print(F("Status: 0x")); Serial.println(finger.status_reg, HEX);
  Serial.print(F("Sys ID: 0x")); Serial.println(finger.system_id, HEX);
  Serial.print(F("Capacity: ")); Serial.println(finger.capacity);
  Serial.print(F("Security level: ")); Serial.println(finger.security_level);
  Serial.print(F("Device address: ")); Serial.println(finger.device_addr, HEX);
  Serial.print(F("Packet len: ")); Serial.println(finger.packet_len);
  Serial.print(F("Baud rate: ")); Serial.println(finger.baud_rate);
*/
  finger.getTemplateCount();

  if (finger.templateCount == 0) {
   // Serial.print("");
  }
  else {
  //  Serial.println("");
    //  Serial.print(""); Serial.print(finger.templateCount); Serial.println("");
  }
}

void loop()                     // run over and over again
{
    bluetooth();
  
  getFingerprintID();
  delay(1000);            //don't ned to run this at full speed.
}


void bluetooth() { //loop from the bluetooth code is renamed to "bluetooth" void
  if(Serial.available() > 0){  //if there is any information comming from the serial lines...
    info = Serial.read();   
    state = 0;   //...than store it into the "info" variable
  }
  if(info == '1'){                //if it gets the number 1(stored in the info variable...
    digitalWrite(LED, HIGH);    //it's gonna turn the led on(the on board one)
    if(state == 0){              //if the flag is 0, than display that the LED is on and than set that value to 1
      Serial.println("LED ON");  //^^that will prevent the arduino sending words LED ON all the time, only when you change the state
      state = 1;
    }
   }
  else if(info == '0'){
    digitalWrite(LED, LOW);      //else, it's going to turn it off
    if(state == 0){
      Serial.println("LED OFF");//display that the LED is off
      state = 1;
     }
  }
}
uint8_t getFingerprintID() {
  uint8_t p = finger.getImage();
  switch (p) {
    case FINGERPRINT_OK:
     // Serial.println("");
      break;
    case FINGERPRINT_NOFINGER:
     // Serial.println("");
      return p;
    case FINGERPRINT_PACKETRECIEVEERR:
    //  Serial.println("Communication error");
      return p;
    case FINGERPRINT_IMAGEFAIL:
    //  Serial.println("");
      return p;
    default:
    //  Serial.println("");
      return p;
  }

  // OK success!

  p = finger.image2Tz();
  switch (p) {
    case FINGERPRINT_OK:
    //  Serial.println("");
      break;
    case FINGERPRINT_IMAGEMESS:
  ///    Serial.println("");
      return p;
    case FINGERPRINT_PACKETRECIEVEERR:
   //   Serial.println("Communication error");
      return p;
    case FINGERPRINT_FEATUREFAIL:
    //  Serial.println("Could not find fingerprint features");
      return p;
    case FINGERPRINT_INVALIDIMAGE:
  //    Serial.println("");
      return p;
    default:
    //  Serial.println("Unknown error");
      return p;
  }

  // OK converted!
  p = finger.fingerSearch();
  if (p == FINGERPRINT_OK) {
   // Serial.println("Found a print match!");
  } else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("Communication error");
    return p;
  } else if (p == FINGERPRINT_NOTFOUND) {
    Serial.println("Did not find a match");
    return p;
  } else {
    Serial.println("Unknown error");
    return p;
  }

  // found a match!
   Serial.print(finger.fingerID);Serial.print("\n"); 
//  Serial.print(" with confidence of "); Serial.println(finger.confidence);

  return finger.fingerID;
}

// returns -1 if failed, otherwise returns ID #
int getFingerprintIDez() {
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK)  return -1;

  // found a match!
 //  Serial.print(finger.fingerID);
 // Serial.print(" with confidence of "); Serial.println(finger.confidence);
  return finger.fingerID;
}
