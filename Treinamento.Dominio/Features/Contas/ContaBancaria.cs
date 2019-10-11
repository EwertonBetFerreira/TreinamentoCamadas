using System;
using Treinamento.Dominio.Features.Agencias;
using Treinamento.Dominio.Features.Pessoas;

namespace Treinamento.Dominio.Features.Contas
{
    public class ContaBancaria
    {
        public int Id { get; set; }
        public string Conta { get; private set; }
        public Agencia Agencia { get; private set; }
        public Pessoa DonoDaConta { get; private set; }
        public double Saldo { get; private set; }
        public string DataAbertura { get; private set; }

        public ContaBancaria(string conta, Agencia agencia, Pessoa donodaconta)
        {
            Conta = conta;
            Agencia = agencia;
            DonoDaConta = donodaconta;
            DataAbertura = DateTime.Now.ToString();
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
