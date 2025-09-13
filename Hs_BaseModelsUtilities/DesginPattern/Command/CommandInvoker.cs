using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.DesginPattern.Command
{
    public class CommandInvoker
    {
        private readonly List<ICommand> _commands = new();
        public void AddCommand(ICommand command) => _commands.Add(command);
        public void ExecuteAll()
        {
            foreach (var cmd in _commands)
                cmd.Execute();
            _commands.Clear();
        }
        public async Task ExecuteAllAsync()
        {
            foreach (var cmd in _commands)
                await cmd.ExecuteAsync();
            _commands.Clear();
        }

    }

}
