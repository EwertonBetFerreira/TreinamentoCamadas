using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Dominio.Features.Agencias;
using Treinamento.Infra.Memoria.Interface;

namespace Treinamento.Infra.Memoria.Agencias
{
    public class AgenciaDao : IDao<Agencia>
    {
        private List<Agencia> listaDeAgencias = new List<Agencia>();

        public int PegaUltimoId()
        {
            Agencia ultimoId = listaDeAgencias.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }

        public void CadastraDados(Agencia agencia)
        {
            agencia.Id = PegaUltimoId() + 1;
            listaDeAgencias.Add(agencia);
        }

        public List<Agencia> ListaDados()
        {
            return listaDeAgencias;
        }

        public Agencia BuscaPorId(int id)
        {
            return listaDeAgencias.Find(a => a.Id == id);
        }
    }
}
