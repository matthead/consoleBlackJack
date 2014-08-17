using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Multiplayer
    {
        private List<Models.Table> _table;
        private static Multiplayer instance;
        private Multiplayer()
        {
            if (_table == null)
            {
                _table = new List<Models.Table>();
            }
            while (_table.Count < 10)
            {
                _table.Add(new Models.Table());
            }            
        }
        public static Multiplayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Multiplayer();
                }
                return instance;
            }
        }
        public Models.Table selectTable(Models.Player player,int selection)
        {
            _table[selection].AddPlayerToTable(player);
            _table[selection].Start();
            return _table[selection];
        }
    }
}
