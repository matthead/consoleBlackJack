using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models.Interfaces
{
    interface ITable
    {
        bool AddPlayerToTable(Player player);
        bool RemovePlayer(Player player);
    }
}
