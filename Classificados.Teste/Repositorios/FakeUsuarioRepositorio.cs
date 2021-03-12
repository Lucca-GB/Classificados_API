using Classificados.Dominio.Entidades;
using Classificados.Dominio.Repositorios;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classificados.Teste.Repositorios
{
    public class FakeUsuarioRepositorio : Notifiable, IUsuarioRepositorio
    {
        List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario("lucca", "email2@email.com", "1234567", "123.456.789-10", Comum.Enum.EnTipoUsuario.Comum),
            new Usuario("deja", "email3@email.com", "1234567", "123.456.789-10", Comum.Enum.EnTipoUsuario.Comum)
        };
        public void Adicionar(Usuario usuario)
        {
            if (usuario.Invalid)
                AddNotification("Usuario", "Dados inválidos");
        }

        public void Alterar(Usuario usuario)
        {
            
        }

        public void AlterarSenha(Usuario usuario)
        {
            
        }

        public Usuario BuscarPorEmail(string email)
        {
            var usuario = new Usuario("Lucca", "email2@email.com", "123.456.789-10", "1234567", Comum.Enum.EnTipoUsuario.Comum);
            if (usuario.Valid)
                return usuario;

            AddNotification("Usuario", "Dados Inválidos");

            return usuario;
        }

        public Usuario BuscarPorId(Guid id)
        {
            if (id == new Guid("1755D7CC-ECEE-4EA9-990A-34B1716C65A7"))
                return new Usuario("lucca", "email2@email.com", "1234567", "123.456.789-10", Comum.Enum.EnTipoUsuario.Comum);

            return null;
        }

        public List<Usuario> Listar(bool? ativo = null)
        {
            return new List<Usuario>()
            {
                new Usuario("lucca", "email2@email.com", "1234567", "123.456.789-10", Comum.Enum.EnTipoUsuario.Comum),
                new Usuario("deja", "email3@email.com", "1234567", "123.456.789-10", Comum.Enum.EnTipoUsuario.Comum)
            };
        }
    }
}
