using DesafioPOO.Models;

Console.WriteLine("Telefone Nokia: ");
Smartphone nokia = new Nokia(numero: "81979952781", modelo: "Modelo Teste", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Telefone iphone: ");
Smartphone iphone = new Iphone(numero: "85979952781", modelo: "Modelo Teste", imei: "1111111111", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");