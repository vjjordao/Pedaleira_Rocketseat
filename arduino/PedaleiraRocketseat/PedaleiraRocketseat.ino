

// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);

  //
}

bool lastState = false;

void loop() {
  int button = digitalRead(5);
  if (!button and !lastState){
    lastState = true;
    Serial.println("pushed");
    delay(200); 
  }
  else if(button and lastState)
  {
    lastState = false;    
  }
  
}
