using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3Help
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameboard);

    }
}
