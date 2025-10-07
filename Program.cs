using DesafioPOO.Models;

Console.WriteLine("Instanciando um Nokia:");
Nokia nokia1 = new Nokia(numero: "123456789", modelo: "Nokiazika", IMEI: "123456789", memoria: 64);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo(nomeApp: "WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Instanciando um Iphone:");

Iphone iphone1 = new Iphone(numero: "987654321", modelo: "Iphone", IMEI: "987654321", memoria: 128);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo(nomeApp: "WhatsApp");


