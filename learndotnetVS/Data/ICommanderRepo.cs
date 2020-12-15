using learndotnetVS.Models;
using System.Collections.Generic;

namespace learndotnetVS.Data
{
    public interface ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands();

        public Command GetCommandById(int id);
    }
}
