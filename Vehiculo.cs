namespace TallerRepuestosASP.Models
{
    using System.Collections.Generic;

    public class Vehiculo
    {
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public List<Repuesto> Repuestos { get; set; } = new List<Repuesto>();

        public void AgregarRepuesto(Repuesto repuesto)
        {
            Repuestos.Add(repuesto);
        }
    }
}