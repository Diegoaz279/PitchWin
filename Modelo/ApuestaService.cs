public class ApuestaService
{
    // Cuotas de ejemplo para cada tipo de apuesta
    private decimal cuotaEquipoLocal = 1.8m;
    private decimal cuotaEquipoVisitante = 2.0m;
    private decimal cuotaEmpate = 3.0m;

    // Método para calcular la ganancia estimada
    public decimal CalcularGananciaEstimada(string tipoApuesta, decimal montoApuesta)
    {
        decimal gananciaEstimada = 0;

        if (tipoApuesta == "Equipo Local")
        {
            gananciaEstimada = montoApuesta * cuotaEquipoLocal;
        }
        else if (tipoApuesta == "Equipo Visitante")
        {
            gananciaEstimada = montoApuesta * cuotaEquipoVisitante;
        }
        else if (tipoApuesta == "Empate")
        {
            gananciaEstimada = montoApuesta * cuotaEmpate;
        }

        return gananciaEstimada;
    }

    // Lógica para cargar los tipos de apuestas basados en el equipo seleccionado
    public List<string> ObtenerTiposDeApuesta(string equipoSeleccionado)
    {
        List<string> tiposDeApuesta = new List<string>
        {
            "Equipo Local",
            "Equipo Visitante",
            "Empate"
        };

        // Si el equipo es de cierto tipo, se ajustan las apuestas
        if (equipoSeleccionado == "Los Angeles Dodgers" || equipoSeleccionado == "Chicago Cubs")
        {
            tiposDeApuesta.Remove("Empate"); // Ejemplo: no se permite empate para ciertos equipos
        }

        return tiposDeApuesta;
    }
}
