using learndotnetVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learndotnetVS.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boild and egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Boild and egg 1", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=2, HowTo="Boild and egg 2", Line="Boil water", Platform="Kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boild and egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }
    }
}
