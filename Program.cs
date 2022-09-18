using ConsoleApp2;
using System;


namespace HolaMundo
{
    class auto
    {
      static void Main(string[] args)
        {
           Console.WriteLine("Ingrese los datos del vehiculo!.\n\n");

            
            vehicle myCar = new vehicle ();
             
             Console.WriteLine("Nombre de modelo :");
              myCar.Model = Console.ReadLine(); 
             
             Console.WriteLine("Nombre de Manufacturador :");
              myCar.Manufacturer = Console.ReadLine();
             
             Console.WriteLine("Numero de puertas :");
            string Doors = Console.ReadLine();
              myCar.Doors = int.Parse(Doors);

             Console.WriteLine("Numero de ruedas :");
            string Wheels = Console.ReadLine();
              myCar.Wheels = int.Parse(Wheels);


            Console.WriteLine("Manufacturador : "  + myCar.Manufacturer);
             Console.WriteLine("Numero de puertas :"  + myCar.Doors);
              Console.WriteLine("Numero de ruedas :"  + myCar.Wheels);
               Console.WriteLine("Modelo : "  + myCar.Model);

           Console.Read();


        }
    }
}
