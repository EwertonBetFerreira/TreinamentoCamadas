﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Infra.Memoria.Interface
{
    public interface IDao<T>
    {
        void CadastraDados(T obj);

        List<T> ListaDados();

        T BuscaPorId(int id);

        int PegaUltimoId();
    }
}
