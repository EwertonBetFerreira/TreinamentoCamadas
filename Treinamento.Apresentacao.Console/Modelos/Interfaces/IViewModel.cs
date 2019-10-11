using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Apresentacao.Cmd.Modelos.Interfaces
{
    public interface IViewModel<T>
    {
        void CadastraDados();

        void ListaEFormata();

    }
}
