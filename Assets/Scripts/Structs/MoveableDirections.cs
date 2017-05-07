using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Structs
{
    public struct MoveableDirections
    {
        public bool CanMoveRight { get; set; }
        public bool CanMoveLeft { get; set; }
        public bool CanMoveUp { get; set; }
        public bool CanMoveDown { get; set; }
    }
}
