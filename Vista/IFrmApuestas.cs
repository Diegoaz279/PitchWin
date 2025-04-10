namespace PitchWin.Vista
{
    public interface IFrmApuestas
    {
        // Recibe el número de partido y sus datos para actualizar la vista.
        void SetPartidoData(
            int partidoNumero,
            string equipoLocal,
            string equipoVisitante,
            string horaPartido,
            string logoLocalUrl,
            string logoVisitanteUrl);

        // Método para mostrar errores
        System.Threading.Tasks.Task ShowError(string mensaje);
    }
}
