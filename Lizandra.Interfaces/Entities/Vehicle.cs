namespace Lizandra.Interfaces.Entities
{
    public class Vehicle
    {
        public string Modelo { get; set; }

        public Vehicle(string modelo)
        {
            Modelo = modelo;
        }
    }
}