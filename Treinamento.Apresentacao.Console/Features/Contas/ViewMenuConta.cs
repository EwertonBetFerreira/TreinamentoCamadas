using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Apresentacao.Cmd.Features.Agencias;
using Treinamento.Apresentacao.Cmd.Features.Pessoas;
using Treinamento.Apresentacao.Cmd.Menus;
using Treinamento.Dominio.Features.Agencias;
using Treinamento.Infra.Memoria.Contas;
using Treinamento.Infra.Memoria.Interface;
using Treinamento.Infra.Memoria.Pessoas;

namespace Treinamento.Apresentacao.Cmd.Features.Contas {
    public void IniciaMenuConta(ViewContaBancaria viewConta, ViewPessoa viewPessoa, ViewAgencia viewAgencia, IDao<Agencia> agenciaDao, ContaBancariaDao contaDao, PessoaDao pessoaDao)
    {
    ConsoleKeyInfo _opcao;
    ViewMenu viewMenu = new ViewMenu();

    Console.WriteLine("\n PRESSIONE: \n\n F1 Para cadastrar uma conta bancaria \n F2 Para mostrar o saldo \n F12 para voltar ao menu principal");
    _opcao = Console.ReadKey();
    switch (_opcao.Key)
    {
        case ConsoleKey.F1:
        Console.Clear();
        viewConta.CadastraDados();
        break;

        case ConsoleKey.F2:
        Console.Clear();
        viewConta.MostraSaldo(contaDao);
        break;

        case ConsoleKey.F12:
        Console.Clear();
        viewMenu.IniciaMenu();
        break;
    }
    }

}

