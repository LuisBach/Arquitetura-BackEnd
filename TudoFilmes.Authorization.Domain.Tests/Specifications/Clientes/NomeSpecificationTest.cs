﻿using System;
using TudoFilmes.Authorization.Domain.Entities;
using TudoFilmes.Authorization.Domain.Specifications.Clientes;
using Xunit;

namespace TudoFilmes.Authorization.Domain.Tests.Specifications.Clientes
{
    public class NomeSpecificationTest
    {
        [Fact]
        public void Nome_Valido_Verdadeiro()
        {
            // Arrange
            var especificacao = new ClienteDeveTerNomeSpecification();
            var cliente = new Cliente()
            {
                ClientId = "099153c2625149bc8ecb3e85e03f0022",
                Nome = "Cliente consistente",
                Base64Secret = "IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw"
            };

            // Act
            var valido = especificacao.IsSatisfiedBy(cliente);

            // Assert
            Assert.True(valido);
        }

        [Fact]
        public void Nome_Valido_Falso()
        {
            // Arrange
            var especificacao = new ClienteDeveTerNomeSpecification();
            var cliente = new Cliente()
            {
                ClientId = "099153c2625149bc8ecb3e85e03f0022",
                Nome = "",
                Base64Secret = "IxrAjDoa2FqElO7IhrSrUJELhUckePEPVpaePlS_Xaw"
            };

            // Act
            var valido = especificacao.IsSatisfiedBy(cliente);

            // Assert
            Assert.False(valido);
        }
    }
}
