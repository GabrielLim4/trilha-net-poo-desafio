using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "123409540", modelo: "Nokia 1", imei: "1240540934", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("------------------------------------------------------------------------------------------------------------");

Console.WriteLine("iPhone: ");
Smartphone iphone = new Iphone(numero: "4540234534", modelo: "Iphone 14", imei: "450029399", memoria: 258);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");