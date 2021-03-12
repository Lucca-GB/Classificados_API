using Classificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Classificados.Teste.Entidades
{
    public class UsuarioTestes
    {
        [Fact]
        public void DeveRetornarErroSeUsuarioInvalido()
        {
            var usuario = new Usuario("", "email@email.com", "", "", Comum.Enum.EnTipoUsuario.Admin);
            Assert.True(usuario.Invalid, "Usuario válido");
        }
        [Fact]
        public void DeveRetornarSucessoSeUsuarioInvalido()
        {
            var usuario = new Usuario("Lucca Gomes", "email@email.com", "1234567", "12345678910", Comum.Enum.EnTipoUsuario.Admin);
            Assert.True(usuario.Valid, "Usuario inválido");
        }
        [Fact]
        public void DeveRetornarErroSeTelefoneUsuarioInvalido()
        {
            var usuario = new Usuario("Lucca Gomes", "email@email.com", "1234567", "12345678910", Comum.Enum.EnTipoUsuario.Admin);
            usuario.AdicionarTelefone("98761");

            Assert.True(usuario.Invalid, "Numero do telefone é válido");
        }
        [Fact]
        public void DeveRetornarSucessoSeTelefoneUsuarioValido()
        {
            var usuario = new Usuario("Lucca Gomes", "email@email.com", "1234567", "12345678910", Comum.Enum.EnTipoUsuario.Admin);
            usuario.AdicionarTelefone("11987654321");

            Assert.True(usuario.Valid, "Numero do telefone é invalido");
        }
        public void Usuario()
        {


        }
    }
}
