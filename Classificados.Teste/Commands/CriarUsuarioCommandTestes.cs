using Classificados.Comum.Enum;
using Classificados.Dominio.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Classificados.Teste.Commands
{
    public class CriarUsuarioCommandTestes
    {
        [Fact]
        public void DeveRetornarErroSeDadosInvalidos()
        {
            var command = new CriarUsuarioCommand();

            command.Validar();

            Assert.False(command.Valid, "Usuário é válido");
        }
        [Fact]
        public void DeveRetornarErroSeDadosValidos()
        {
            var command = new CriarUsuarioCommand(  "Lucca",
                                                    "email@email.com",
                                                    "1234567",
                                                    "",
                                                    "123.456.789-10",
                                                    EnTipoUsuario.Comum);
            
            command.Validar();

            //se o meu objeto command passar pelas validações
            //Invalid = false
            //se nao invalid = true

            //se o meu objeto command passar pelas validações
            //valid = true
            //se nao = false

            Assert.True(command.Invalid, "Usuário é inválido");
        }
    }
}
