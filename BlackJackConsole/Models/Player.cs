using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models
{
    public class Player
    {
        public int wealth { get; private set; }
        public string password { get; private set; }
        public Hand hand { get; private set; }
    }
}