using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Dominio.Features.Funcionarios;
using Treinamento.Dominio.Features.Pessoas;
using Treinamento.Infra.Memoria.Interface;

namespace Treinamento.Infra.Memoria.Funcionarios
{
    public class FuncionarioDao : IDao<Funcionario>
    {
        private List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

        public Pessoa BuscaFuncionarioPorId(int id)
        {
            foreach (var funcionario in listaDeFuncionarios)
            {
                if (funcionario.Id == id)
                    return funcionario;
            }

            return null;
        }

        public int PegaUltimoId()
        {
            Pessoa ultimoId = listaDeFuncionarios.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }

        public void CadastraDados(Funcionario funcionario)
        {
            funcionario.Id = PegaUltimoId() + 1;
            listaDeFuncionarios.Add(funcionario);
        }

        public List<Funcionario> ListaDados()
        {
            return listaDeFuncionarios;
        }

        public Funcionario BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
