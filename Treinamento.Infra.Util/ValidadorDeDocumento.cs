using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Infra.Util
{
    public static class ValidadorDeDocumento
    {
        public static string ValidaCpfCnpj(this string CpfCnpj)
        {
            if (CpfCnpj.Length == 11)
            {
                return "cpf";

            }

            if (CpfCnpj.Length == 13)
            {

                return "cnpj";
            }

            return null;
        }
    }
}
