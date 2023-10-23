using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia");
        Nokia nokia = new Nokia(numero: "99999-5552", modelo: "Nokia 2200", imei: "123456789", memoria: 5);
        nokia.Ligar();
        nokia.InstalarAplicativo("Game Snake II");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Apple");
        Iphone iphone = new Iphone(numero: "99855-3325", modelo: "Iphone 15", imei: "987654321", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Game Mortal Kombat 1");
    }
}

