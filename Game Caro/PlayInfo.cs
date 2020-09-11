﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    public class PlayInfo
    {
        private Point point;
        private int currentPlayer;

        public Point Point { get => point; set => point = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        public PlayInfo(Point point, int currentPlayer)
        {
            Point = point;
            CurrentPlayer = currentPlayer;
        }
    }
}
