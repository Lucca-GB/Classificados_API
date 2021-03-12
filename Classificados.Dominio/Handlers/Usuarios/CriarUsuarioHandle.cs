using Classificados.Comum.Commands;
using Classificados.Comum.Handlers;
using Classificados.Comum.Util;
using Classificados.Dominio.Commands.Usuario;
using Classificados.Dominio.Entidades;
using Classificados.Dominio.Repositorios;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classificados.Dominio.Handlers.Usuarios
{
    public class CriarUsuarioHandle : Notifiable, IHandler<CriarUsuarioCommand>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public CriarUsuarioHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public ICommandResult Handle(CriarUsuarioCommand command)
        {
            //fail fast validation
            //validamos o command
            command.Validar();

            if (command.Invalid)
                return new GenericCommandResult(false, "dados do usuário invalido", command.Notifications);

            //verificamos se o email existe
            var usuarioExiste = _usuarioRepositorio.BuscarPorEmail(command.Email);

            if(usuarioExiste != null)
                return new GenericCommandResult(false, "email ja cadastrado, informe outro email", null);

            //criptografamos a senha
            command.Senha = Senha.CriptografarSenha(command.Senha);

            //salvamos usuario
            var usuario = new Usuario(command.Nome, command.Email, command.Senha, command.CPF, command.TipoUsuario);
            //verifica se foi passado o telefone, se sim inclui o mesmo
            if (!string.IsNullOrEmpty(command.Telefone))
                usuario.AdicionarTelefone(command.Telefone);

            if(usuario.Invalid)
                return new GenericCommandResult(false, "dados invalidso", usuario.Notifications);

            _usuarioRepositorio.Adicionar(usuario);

            //retorno email boas vindas :)
            //SendGrid

            return new GenericCommandResult(true, "usuário criado", usuario);


        }
    }
}
