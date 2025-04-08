namespace Aplication.DTO;

public class VagasTotaisDTO
{
    public VagasTotaisDTO(int vagasTotaisCarros, int vagasTotaisMotos, decimal valorHora)
    {
        TotalVagasCarros = vagasTotaisCarros;
        TotalVagasMotos = vagasTotaisMotos;
        ValorHora = valorHora;
    }

    public VagasTotaisDTO() { }

    public int TotalVagasCarros { get; set; }
    public int TotalVagasMotos { get; set; }
    public decimal ValorHora { get; set; }

}
