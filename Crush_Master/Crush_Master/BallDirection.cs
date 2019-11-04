using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crush_Master
{
    public enum BallDirection
    {
        //направление мяча. В идеале лучше задавать его градусом, но у нас будет только 4 направления (Влево-вверх и т.п.)

        LeftUp,
        RightUp,
        LeftBottom,
        RightBottom
    }
}
