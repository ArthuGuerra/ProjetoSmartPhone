using ProjetoSmart.Models;

Nokia cellNokia = new Nokia("(99)99909099","Nokia S10000 Plus+","Nokia-MOTOROLA",9999999);
Samsumg cellSamsumg = new Samsumg("81989005184","Samsumg S 25 Plus","Samsumg",200000);
Iphone cellIphone = new Iphone("40028922","Iphone 15 S+ Plus","Apple",3333333);




Console.WriteLine("Informações do Nokia");
cellNokia.ExibirMenu();
cellNokia.InstalarApp("Zapzap");

Console.WriteLine("\n");

Console.WriteLine("Informações do Samsumg");
cellSamsumg.ExibirMenu();
cellSamsumg.InstalarApp("instagram");


Console.WriteLine("\n");

Console.WriteLine("Informações do Iphone");
cellIphone.ExibirMenu();
cellIphone.InstalarApp("Team Fight Tatics");

