using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Apresentacao.Cmd.Features.Agencias;
using Treinamento.Apresentacao.Cmd.Features.Pessoas;
using Treinamento.Apresentacao.Cmd.Modelos.Interfaces;
using Treinamento.Apresentacao.Features.Pessoas;
using Treinamento.Dominio.Features.Contas;
using Treinamento.Dominio.Features.Pessoas;
using Treinamento.Infra.Memoria.Contas;
using Treinamento.Infra.Memoria.Interface;
using Treinamento.Infra.Memoria.Pessoas;

namespace Treinamento.Apresentacao.Cmd.Features.Contas
{
    public class ViewContaBancaria : IViewModel<ContaBancaria>
    {
        private ContaBancariaDao _contaDao;
        private PessoaDao _pessoaDao;
        private IDao<Agencias> _agenciaDao;
        private ViewPessoa _pessoaView;
        private ViewAgencia _viewAgencia;

        public ViewContaBancaria(ContaBancariaDao contaDao, PessoaDao pessoaDao, IDao<Agencias> agenciaDao, ViewPessoa viewPessoa, ViewAgencia viewAgencia)
        {
            _contaDao = contaDao;
            _pessoaDao = pessoaDao;
            _agenciaDao = agenciaDao;
            _pessoaView = viewPessoa;
            _viewAgencia = viewAgencia;
        }

        public void CadastraDados()
        {
            Console.WriteLine("Digite o numero da conta bancaria");
            string NumContaBancaria = Console.ReadLine();

            _viewAgencia.ListaEFormata();

            Console.WriteLine("Selecione uma agencia acima digitando o numero do seu ID\n");
            int agenciaId = Convert.ToInt16(Console.ReadLine());

            Agencias retornoAgencia = _agenciaDao.BuscaPorId(agenciaId);

            if (retornoAgencia != null)
            {
                Console.Clear();

                Console.WriteLine("\nInforme o dono da conta pelo ID:\n");
                int idDonoDaConta = Convert.ToInt16(Console.ReadLine());

                Pessoa donodaConta = _pessoaDao.BuscaPorId(idDonoDaConta);

                if (donodaConta != null)
                {
                    ContaBancaria novaConta = new ContaBancaria(NumContaBancaria, retornoAgencia, donodaConta);

                    _contaDao.CadastraDados(novaConta);
                    Console.WriteLine("\n {0} cadastrado com sucesso \n Pressione qualquer tecla para voltar ao menu", donodaConta.Nome);
                }
                else
                {
                    Console.WriteLine("Pessoa nao encontrada \n Pressione qualquer tecla para voltar ao menu");
                }
            }
            else
            {
                Console.WriteLine("Agencia nao encontrada \n Pressione qualquer tecla para voltar ao menu");
            }

            Console.ReadKey();
            Console.Clear();
        }
        public void ListaEFormata()
        {
            Console.Clear();

            if (_contaDao.ListaDados().Count != 0)
            {
                foreach (var conta in _contaDao.ListaDados())
                {
                    Console.WriteLine($"\nID: {conta.Id}" +
                        $" \n Conta: {conta.Conta} \n Agencia: {conta.Agencia.Nome} \n Dono da Conta: {conta.DonoDaConta.Nome}");
                }
            }
            else
            {
                Console.WriteLine("\nNão foi encontrado nenhuma conta bancaria\n");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
        public void MostraSaldo(ContaBancariaDao contaDao)
        {
            Console.WriteLine("\nInforme o Id da conta para verificar o saldo");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n O saldo desta conta é: {0}", contaDao.BuscaPorId(id).Saldo);

        }
    }
}
