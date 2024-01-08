using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "897456123", "modelo 1", "1111111111111", "64");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "32145698", "modelo 2", "2222222222", "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");