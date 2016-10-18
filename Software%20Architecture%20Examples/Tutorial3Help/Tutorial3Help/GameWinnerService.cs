using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3Help
{
    public class GameWinnerService : IGameWinnerService
    {
        char IGameWinnerService.Validate(char[,] gameboard)
        {
            var rowOneChar = gameboard[0, 0];
            var rowTwoChar = gameboard[0, 1];
            var rowThreeChar = gameboard[0, 2];

            if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }

            return ' ';
        }
    }
}
