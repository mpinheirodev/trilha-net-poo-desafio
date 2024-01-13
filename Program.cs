using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nTestando smartphone Nokia...");
Nokia nokia = new Nokia("(12)3456-7890", "Nokia 3310", "123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("----------------------------------------");

Console.WriteLine("Testando smartphone Iphone...");
Iphone iphone = new Iphone("(12)3456-7890", "Iphone 12", "123456789", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");

Console.WriteLine("\n");