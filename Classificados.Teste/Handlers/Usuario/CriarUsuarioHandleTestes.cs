using Classificados.Comum.Commands;
using Classificados.Dominio.Commands.Usuario;
using Classificados.Dominio.Handlers.Usuarios;
using Classificados.Teste.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Classificados.Teste.Handlers.Usuario
{
    public class CriarUsuarioHandleTestes
    {
        [Fact]
        public void DeveRetornarErroSeOsDadosDoHandlerInvalidos()
        {
            //criar command
            var command = new CriarUsuarioCommand(  "Lucca", 
                                                    "email@email.com", 
                                                    "", 
                                                    "", 
                                                    "123.456.789-10", 
                                                    Comum.Enum.EnTipoUsuario.Comum);
            //criar handler
            var handle = new CriarUsuarioHandle(new FakeUsuarioRepositorio());
            //pega o resultado
            var resultado = (GenericCommandResult)handle.Handle(command);
            //valida a condição
            Assert.False(resultado.Sucesso, "usuario é valido");
        }
        [Fact]
        public void DeveRetornarErroSeOsDadosDoHandlerValidos()
        {
            //criar command
            var command = new CriarUsuarioCommand(  "Lucca",
                                                    "email@email.com",
                                                    "1234567",
                                                    "",
                                                    "123.456.789-10",
                                                    Comum.Enum.EnTipoUsuario.Comum);
            //criar handler
            var handle = new CriarUsuarioHandle(new FakeUsuarioRepositorio());
            //pega o resultado
            var resultado = (GenericCommandResult)handle.Handle(command);
            //valida a condição
            Assert.False(resultado.Sucesso, "usuario é valido");
        }
    }
}
