using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSUV();

            Vehicle vehicle = builder.GetVehicle();
                
            Console.WriteLine($"Criado um veiculo do tipo {vehicle.VehicleType}");
        }
    }
}
