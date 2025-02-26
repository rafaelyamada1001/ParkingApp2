namespace Aplication.DTO;

public class VagasTotaisDTO
{
    public VagasTotaisDTO(int vagasTotaisCarros, int vagasTotaisMotos, decimal valorHora)
    {
        VagasTotaisCarros = vagasTotaisCarros;
        VagasTotaisMotos = vagasTotaisMotos;
        ValorHora = valorHora;
    }

    public VagasTotaisDTO() { }

    public int VagasTotaisCarros { get; set; }
    public int VagasTotaisMotos { get; set; }
    public decimal ValorHora { get; set; }

}
