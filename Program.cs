using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia!");
Smartphone nokia = new Nokia("332233", "NK025", "7908414408210", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine($"Modelo: {nokia.Modelo}");


Console.WriteLine("----------------------------------------------------------------------------");

Console.WriteLine("Ipone!");
Smartphone iphone = new Iphone("222200", "MPVX3BE/A", "194253488279", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine($"Modelo: {iphone.Modelo}");