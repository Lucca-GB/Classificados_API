using Classificados.Comum.Commands;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classificados.Dominio.Commands.Usuario
{
    class AlterarSenhaCommand : Notifiable, ICommand
    {
        public Guid IdUsuario { get; set; }
        public string Senha { get; private set; }
        public void Validar()
        {
            AddNotifications(new Contract()
                .Requires()
                .AreNotEquals(IdUsuario, Guid.Empty, "IdUsuario", "Informe um id de usuário valido")
                .IsEmail(Senha, "Email", "informe um e-mail válido")
                );
        }
    }
}
