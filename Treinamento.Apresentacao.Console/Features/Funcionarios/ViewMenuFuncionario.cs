﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Apresentacao.Cmd.Features.Funcionarios
{
    public void IniciaMenuFuncionario(FuncionarioDao funcionarioDao, ViewMenu viewMenu, ViewFuncionario viewFuncionario)
    {
    ConsoleKeyInfo _opcao;

    Console.WriteLine("\n PRESSIONE: \n\n F1 Para cadastrar um Funcionario \n F2 Para mostrar todos os funcionarios \n F12 para voltar ao menu principal");
    _opcao = Console.ReadKey();
    switch (_opcao.Key)
    {
        case ConsoleKey.F1:
        Console.Clear();
        viewFuncionario.CadastraDados();
        break;

        case ConsoleKey.F2:
        Console.Clear();
        viewFuncionario.ListaEFormata();
        break;

        case ConsoleKey.F12:
        Console.Clear();
        viewMenu.IniciaMenu();
        break;
    }
    }
}
