using Classificados.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classificados.Comum.Handlers
{
    // Handler : IHandler<Class> se Classe : ICommand
    // Definido que ao herdar o IHandler deve ser passado uma classe que herda o icommand
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
