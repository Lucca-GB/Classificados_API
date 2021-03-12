using Classificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classificados.Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="usuario">dados do usuario</param>
        void Adicionar(Usuario usuario);
        void Alterar(Usuario usuario);
        void AlterarSenha(Usuario usuario);
        Usuario BuscarPorEmail(string email);
        Usuario BuscarPorId(Guid id);
        List<Usuario> Listar(bool? ativo = null);
    }
}
