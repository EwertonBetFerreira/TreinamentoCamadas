using System;
using Treinamento.Dominio.Features.Pessoas;

namespace Treinamento.Dominio.Features.Funcionarios
{
    public class Funcionario : Pessoa
    {
        public string DataAdmissao { get; private set; }
        public string Funcao { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, string nomecidade, string datanasc, int numendereco, string tipopessoa, string estado, string cpfCnpj, string funcao, double salario) : base(nome, nomecidade, datanasc, numendereco, tipopessoa, estado, cpfCnpj)
        {
            DataAdmissao = DateTime.Now.ToString();
            Funcao = funcao;
            Salario = salario;
        }

    }
}
