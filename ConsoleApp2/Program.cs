// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Cola cola=new Cola(1,1,0.90,10);

Plant plant = new Plant("bitki", 1, 2.90, 15);


Console.WriteLine("Almaq istediyiniz ededi qeyd edin");
int quantity = Int32.Parse(Console.ReadLine());

//cola.Addbasket(quantity);
plant.Addbasket(quantity);



