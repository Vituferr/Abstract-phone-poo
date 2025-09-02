using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("123455678", "Nokia 1101", "1234", 64);
nokia1.InstalarAplicativo("WhatsApp");
nokia1.ReceberLigacao();
nokia1.Ligar();

Console.WriteLine("\n");

Iphone iphone1 = new Iphone("987654321", "Iphone 13", "5678", 128);
iphone1.InstalarAplicativo("Telegram");
iphone1.ReceberLigacao();
iphone1.Ligar();

Console.ReadKey();