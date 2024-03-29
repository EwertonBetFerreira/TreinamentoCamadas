﻿using System;
using Treinamento.Dominio.Features.Contas;

namespace Treinamento.Dominio.Features.Operacoes
{
    public class Operacao
    {
        public int Id { get; set; }
        public double Valor { get; private set; }
        public ContaBancaria ContaMovimentada { get; private set; }
        public ContaBancaria ContaOrigem { get; private set; }
        public string OperacaoVinculada { get; private set; }
        public string DataOperacao { get; private set; }


        public void RealizaOperacao(ContaBancaria contaMovimentada, ContaBancaria contaOrigem, int operacaoVinculada, double valor)
        {
            ContaMovimentada = contaMovimentada;
            ContaOrigem = contaOrigem;
            VerificaOperacao(operacaoVinculada);
            DataOperacao = DateTime.Now.ToString();
            Valor = valor;
        }

        private void VerificaOperacao(int operacaoVinculada)
        {
            if (operacaoVinculada == 1)
            {
                OperacaoVinculada = "Deposito";
            }
            else if (operacaoVinculada == 2)
            {
                OperacaoVinculada = "Saque";
            }
            else if (operacaoVinculada == 3)
            {
                OperacaoVinculada = "Transferencia";
            }
        }
    }
}
