﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models
{
    public class Player
    {
        public Player()
        {
            if (hand == null)
            {
                hand = new Hand();
            }
        }
        public int wealth { get; private set; }
        public string password { get; private set; }
        public Hand hand { get; private set; }
        public int currentBet { get; private set; }
    }
}