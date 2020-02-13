using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Connect
    {
        public int player1 = 1; 
        public int player2 = 0;
        bool number = true; //its able to measure to whos next turn
        bool result = false;  //if it is true, game is finished
        public int[] results = new int[9]; //those clicked buttons
        public int count = 0; //counter is measure to tie or not
       
        public bool whosnext(int buton) //whosnext
        {

            if (player1 == 1) //if player1 is turn (1)
            {
                player1 = 0; //change the line
                player2 = 1;
                results[buton - 1] = 1; //One is player1's clicked buttons
                count++; 
                number = true;

            }
            else
            {
                player1 = 1;
                player2 = 0;
                results[buton - 1] = 2;
                count++;
                number = false;
            }

            return number;
        }
        public bool End()
        {
            //Win posibilities
            if ((results[0] == results[1] && results[2] == results[1] && results[2] == results[0]) && ((results[0] == 1) || results[0] == 2)) result = true;
            if ((results[3] == results[4] && results[5] == results[3] && results[4] == results[5]) && ((results[3] == 1) || results[3] == 2)) result = true;
            if ((results[6] == results[7] && results[8] == results[6] && results[7] == results[8]) && ((results[7] == 1) || results[7] == 2)) result = true;
            if ((results[0] == results[3] && results[6] == results[0] && results[3] == results[6]) && ((results[6] == 1) || results[6] == 2)) result = true;
            if ((results[1] == results[4] && results[7] == results[1] && results[4] == results[7]) && ((results[1] == 1) || results[1] == 2)) result = true;
            if ((results[2] == results[5] && results[8] == results[2] && results[5] == results[8]) && ((results[8] == 1) || results[8] == 2)) result = true;
            if ((results[0] == results[4] && results[8] == results[0] && results[4] == results[8]) && ((results[8] == 1) || results[8] == 2)) result = true;
            if ((results[2] == results[4] && results[6] == results[2] && results[4] == results[6]) && ((results[2] == 1) || results[2] == 2)) result = true;
           
            return result;
        }
        public void gameReset() 
        {   //clears all stuff
            for (int i = 0; i < 9; i++)
            {
                results[i] = 0;
            }
            player1 = 1;
            player2 = 0;
            number = true;   
            result = false;
            count = 0;
    }
    }
}
