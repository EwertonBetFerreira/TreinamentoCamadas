﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Infra.Memoria.Interface;

namespace Treinamento.Infra.Sql.Operacoes
{
    public class RelatorioOperacaoDaoSql : IDao<RelatorioOperacaoDao>
    {
        public RelatorioOperacaoDao BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(RelatorioOperacaoDao obj)
        {
            throw new NotImplementedException();
        }

        public List<RelatorioOperacaoDao> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
