using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999-999", modelo: " ztxmc", imei:"1321546465", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"789879-987", modelo:"iphoneX", imei:" 1231321", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");