﻿using Aplication.DTO;
using Aplication.Interface;
using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;


namespace Aplication.UseCase
{
    public class AdicionarVeiculoUseCase
    {
        private readonly IVeiculoRepository _veiculosRepository;
        private readonly IEstacionamentoRepository _estacionamentoRepository;


        public AdicionarVeiculoUseCase(IVeiculoRepository veiculosRepository, IEstacionamentoRepository estacionamentoRepository)
        {
            _veiculosRepository = veiculosRepository;
            _estacionamentoRepository = estacionamentoRepository;
        }

        public ResponseDefault<string> Execute(string placa, EVeiculoType tipoVeiculo)
        {
            var placaVeiculo = new PlacaVeiculo(placa);
            var vagasOcupadas = _estacionamentoRepository.VagasOcupadas();
            var vagasTotaisResponse = _estacionamentoRepository.VagasTotais();
            var veiculo = new Veiculos(placaVeiculo, tipoVeiculo);

            if (!vagasTotaisResponse.Sucesso) return new ResponseDefault<string>(false, vagasTotaisResponse.Mensagem, null);

            var vagasCarros = vagasTotaisResponse.Dados.VagasTotaisCarros;
            var vagasMotos = vagasTotaisResponse.Dados.VagasTotaisMotos;

            if (vagasOcupadas.Dados.VagasCarros >= vagasCarros)
            {
                return new ResponseDefault<string>(false, "Atenção!\n Estacionamento atingiu o limite de Carros estacionados.", null);
            }

            if (vagasOcupadas.Dados.VagasMotos >= vagasMotos)
            {
                return new ResponseDefault<string>(false, "Atenção!\n Estacionamento atingiu o limite de Motos estacionadas.", null);
            }

            if (!veiculo.Validation())
            {
                // Coleta todas as mensagens de erro das notificações da placa
                var notificacoes = placaVeiculo.Notifications
                    .Select(n => n.Message)
                    .ToList();

                // Coleta as notificações do veículo 
                notificacoes.AddRange(veiculo.Notifications.Select(n => n.Message));

                return new ResponseDefault<string>(false, string.Join(", ", notificacoes), null);
            }

            var veiculosComMesmaPlaca = _veiculosRepository.VerificarPlaca(placa);

            if (veiculosComMesmaPlaca.Dados > 0)
            {
                return new ResponseDefault<string>(false, "Veículo já estacionado", null);
            }

            var adicionarVeiculo = _veiculosRepository.AdicionarVeiculo(veiculo);

            if (!adicionarVeiculo.Sucesso)
            {
                return new ResponseDefault<string>(false, adicionarVeiculo.Mensagem, null);
            }

            return new ResponseDefault<string>(true, adicionarVeiculo.Mensagem, placa);
        }
    }
}
