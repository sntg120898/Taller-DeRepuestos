namespace TallerRepuestosASP.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Taller
    {
        public List<Repuesto> Inventario { get; set; } = new List<Repuesto>();

        public void AgregarRepuesto(Repuesto repuesto)
        {
            Inventario.Add(repuesto);
        }

        public string GenerarEstadisticas()
        {
            var estadisticas = Inventario
                .GroupBy(r => r.Tipo)
                .Select(g => new { Tipo = g.Key, Cantidad = g.Sum(r => r.Cantidad) });

            decimal precioTotal = Inventario.Sum(r => r.Precio * r.Cantidad);

            var resumen = string.Join("\n", estadisticas.Select(e => $"Tipo: {e.Tipo}, Cantidad: {e.Cantidad}"));
            return $"Estadísticas del inventario:\n{resumen}\nPrecio total del inventario: ${precioTotal}";
        }

        public List<Repuesto> BuscarRepuesto(string termino)
        {
            return Inventario
                .Where(r => r.Nombre.ToLower().Contains(termino.ToLower()) || r.Tipo.ToLower().Contains(termino.ToLower()))
                .ToList();
        }
    }
}