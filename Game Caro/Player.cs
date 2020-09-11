﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    public class Player
    {
        private string name;
        private Image mark;

        public string Name { get => name; set => name = value; }
        public Image Mark { get => mark; set => mark = value; }

        public Player(string name, Image mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
