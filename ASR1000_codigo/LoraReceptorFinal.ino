
#include <SPI.h>
#include <LoRa.h>
//define os pinos utilizado pelo LoRa
#define ss 5
#define rst 15
#define dio0 2

int cont;
void setup() {
  //Inicializa monitor serial
  Serial.begin(115200);
  while (!Serial);
  //Serial.println("LoRa Receptor");

  //Configura pinos do LoRa
  LoRa.setPins(ss, rst, dio0);
  
  
  //LoRa com 915MHz
  while (!LoRa.begin(915E6)) {
    Serial.println(".");
    delay(500);
  }
   // Seta endereço do LoRa como 0xF3
  // Deve ser igual ao do transmissor
  // Comunicação fica restrita a módulos de mesmo endereço
  LoRa.setSyncWord(0xF3);
  //Serial.println("LoRa Inicializado com sucesso");
}

void loop() {


 
  // espera a chegada de um pacote 
  int packetSize = LoRa.parsePacket();
  if (packetSize) {
    // pacote recebido
    //Serial.print("Pacote Recebido: ");

    // lê o pacote
    while (LoRa.available()) {
 
     String Rxdata=LoRa.readString();   
     //imprime no monitor serial
   
    
      Serial.print(Rxdata);   
    }

  }
}
