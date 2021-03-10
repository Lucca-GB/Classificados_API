using Classificados.Comum.Entidades;
using Classificados.Comum.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classificados.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public Usuario(string nome, string email, string senha, string telefone, string cPF, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(nome, 3, "Nome", "Nome deve conter pelo menos 3 caracteres.")
                .HasMaxLen(nome, 40, "Nome", "Nome deve conter no máximo 40 caracteres.")
                .IsEmail(email, "Email", "Informe um e-mail válido")
                .HasMinLen(senha, 6, "Senha", "Senha deve ter no minímo 6 caracteres.")
                .HasMaxLen(senha, 18, "Senha", "Senha deve ter no máximo 12 caracteres.")

            );

            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            CPF = cPF;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }

    }
}
