﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satoshi_GUI
{
    public class GameSettings
    {
        public int BombCount { get; set; }
        public string PlayerHash { get; set; }
        public int BetAmmount { get; set; }
        public decimal BetCost { get; set; }
        public decimal PercentOnLoss { get; set; }
        public bool StopAfterWin { get; set; }
        public bool StopAfterLoss { get; set; }
        public bool ShowExceptionWindow { get; set; }
        public int[] StratergySquares { get; set; }
        public bool UseStrat { get; set; }
        public bool ShowGameBombs { get; set; }
        public string ConfigTag { get; set; }
        public bool SaveLogToFile { get; set; }
        public bool StopAfterGames { get; set; }
        public int StopAfterGamesAmmount { get; set; }
        public bool CheckBalance { get; set; }
        public int BalanceStopAbove { get; set; }
        public int BalanceStopBelow { get; set; }
        public bool ResetBetMultiplyer { get; set; }
        public int ResetBetMultiplyerDeadline { get; set; }
        public bool UseProxy { get; set; }
        public string Proxy { get; set; }
        public bool MetaSettings { get; set; }
    }
}
