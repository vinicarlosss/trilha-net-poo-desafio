using DesafioPOO.Models;

Registro registro = new Registro();
Console.WriteLine("Telefone Nokia: ");
Smartphone nokia = new Nokia(numero: "81979952781", modelo: "Modelo Teste", imei: "1111111111", memoria: 64, registro: registro);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Telefone iphone: ");
Smartphone iphone = new Iphone(numero: "81979952781", modelo: "Modelo Teste", imei: "1111111111", memoria: 64, registro: registro);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");