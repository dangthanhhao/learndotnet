using learndotnetVS.Models;
using System.Collections.Generic;

namespace learndotnetVS.Data
{
    public interface ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands();

        public Command GetCommandById(int id);
    }
}
