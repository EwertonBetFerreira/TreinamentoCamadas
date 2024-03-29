﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Apresentacao.Cmd.Features.Contas;
using Treinamento.Dominio.Features.Contas;
using Treinamento.Dominio.Features.Operacoes;
using Treinamento.Infra.Memoria.Contas;
using Treinamento.Infra.Memoria.Operacoes;

namespace Treinamento.Apresentacao.Cmd.Features.Operacoes
{
    public class ViewDeposito
    {
        public void RealizaDeposito(ContaBancariaDao contaDao, ViewContaBancaria viewConta, RelatorioOperacaoDao relatorioDao)
        {
            Console.Clear();

            Console.WriteLine("Informe o ID da sua conta");
            int IdContaOrigem = Convert.ToInt32(Console.ReadLine());

            ContaBancaria contaOrigem = contaDao.BuscaPorId(IdContaOrigem);

            if (contaOrigem != null)
            {
                Operacao operacao = new Operacao();

                Console.WriteLine("Informe o ID da conta bancaria a qual irá receber o deposito:\n");
                int IdContaMovimentada = Convert.ToInt32(Console.ReadLine());

                ContaBancaria contaMovimentada = contaDao.BuscaPorId(IdContaMovimentada);

                if (contaMovimentada != null)
                {
                    Console.WriteLine("\nConfirme os dados: \n");
                    viewConta.ListaEFormata();

                    Console.WriteLine("\nInforme o valor a ser depositado: ");
                    double ValorDeposito = Convert.ToDouble(Console.ReadLine());

                    contaMovimentada.Deposito(ValorDeposito);
                    operacao.RealizaOperacao(contaMovimentada, contaOrigem, 1, ValorDeposito);

                    relatorioDao.AdicionaNovaOperacao(operacao);

                    Console.WriteLine("Operacao realizada com sucesso");

                }
                else
                {
                    Console.WriteLine("Nenhuma conta encontrada");
                }

            }
            else
            {
                Console.WriteLine("Conta nao encontrada");
            }
        }
    }
}
