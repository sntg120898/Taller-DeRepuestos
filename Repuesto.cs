namespace TallerRepuestosASP.Models
{
    public class Repuesto
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public void ActualizarCantidad(int cantidadVendida)
        {
            if (cantidadVendida <= Cantidad)
            {
                Cantidad -= cantidadVendida;
            }
        }
    }
}