using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;
        int[] results = new int[3];
        public Slot(int initialBalance, Reel[] reels)
        {
            this.balance = initialBalance;
            this.reels = reels;
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int Stake
        {
            get { return stake; }
            set { stake = value; }
        }
        public void Spin()
        {
            int temp = 0;
            // Spin each reel
            foreach (var reel in reels)
            {
                results[temp]=reel.Spin();
                temp++;
            }
        }
        public int CheckResult()
        {
            int winnings = 0;
            // Check if all three symbols are the same (Jackpot)
            if (results[0] == results[1] && results[1] == results[2])
            {
                winnings = stake * 10; // Win 10x stake
            }
            // Check if two symbols match
            else if (results[0] == results[1] || results[1] == results[2] || results[0] == results[2])
            {
                winnings = stake * 2; // Win 2x stake
            }
            return winnings;
        }
        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}
