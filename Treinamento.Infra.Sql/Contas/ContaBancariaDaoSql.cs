﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Infra.Memoria.Interface;

namespace Treinamento.Infra.Sql.Contas
{
    public class ContaBancariaDaoSql : IDao<ContaBancaria>
    {
        public ContaBancaria BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(ContaBancaria obj)
        {
            throw new NotImplementedException();
        }

        public List<ContaBancaria> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
