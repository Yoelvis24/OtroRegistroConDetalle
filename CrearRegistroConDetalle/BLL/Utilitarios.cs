using System;
using System.Collections.Generic;
using System.Text;

namespace CrearRegistroConDetalle.BLL
{
    public static class Utilitarios
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
    }
}
