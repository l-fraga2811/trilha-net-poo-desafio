using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "tijolão", imei: "010101", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();

Console.WriteLine("iPhone: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "de botao", imei: "260385", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Photos");
iphone.ReceberLigacao();