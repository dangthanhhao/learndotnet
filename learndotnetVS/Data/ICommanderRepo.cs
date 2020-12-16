using learndotnetVS.Models;
using System.Collections.Generic;

namespace learndotnetVS.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        public IEnumerable<Command> GetAllCommands();
        public Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void updateCommand(Command cmd);
        void deleteCommand(Command cmd);

    }
}
