using Classificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classificados.Teste.Entidades
{
    class UsuarioTestes
    {
        public void Usuario()
        {
            var usuario = new Usuario("", "", "", "", "", Comum.Enum.EnTipoUsuario.Admin);


        }
    }
}
