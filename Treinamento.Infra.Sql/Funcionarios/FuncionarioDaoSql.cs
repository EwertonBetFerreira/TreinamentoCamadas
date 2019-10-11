using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Infra.Memoria.Interface;

namespace Treinamento.Infra.Sql.Funcionarios
{
    public class FuncionarioDaoSql : IDao<FuncionarioDao>
    {
        public FuncionarioDao BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(FuncionarioDao obj)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDao> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
