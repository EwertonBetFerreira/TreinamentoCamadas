using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Dominio.Features.Agencias;
using Treinamento.Infra.Memoria.Interface;

namespace Treinamento.Apresentacao.Cmd.Features.Agencias
{ 
    public class ViewAgencia
    {
        private IDao<Agencia> _agenciaDao;

        public ViewAgencia(IDao<Agencia> agenciaDao)
        {
            _agenciaDao = agenciaDao;
        }

        public void CadastraDados()
        {
            System.Console.WriteLine("Digite o codigo da agencia");
            string CodAgencia = System.Console.ReadLine();

            Console.WriteLine("Digite o nome da agencia");
            string NomeAgencia = Console.ReadLine();

            Console.WriteLine("Digite o nome da cidade");
            string NomeCidade = Console.ReadLine();

            Console.WriteLine("Digite o estado");
            string Estado = Console.ReadLine();

            Agencia agencia = new Agencia(CodAgencia, NomeAgencia, NomeCidade, Estado);

            _agenciaDao.CadastraDados(agencia);

            Console.Clear();
            Console.WriteLine("Agencia cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListaEFormata()
        {
            Console.Clear();

            if (_agenciaDao.ListaDados().Count != 0)
            {
                foreach (var agencia in _agenciaDao.ListaDados())
                {
                    Console.WriteLine("\nID: {0} \nNome: {1} \nCodigo: {2} \nCidade: {3} \nEstado: {4} \n",
                        agencia.Id, agencia.Nome, agencia.Codigo, agencia.NomeCidade, agencia.Uf);
                }
            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhuma agencia cadastrada");
            }
        }
    }
}
