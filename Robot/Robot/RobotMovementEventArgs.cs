using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    // Contains data about an attempted robot movement
    public class RobotMovementEventArgs : EventArgs
    {
        public Robot.Directions Direction { get; set; }
        public int MaxValue { get; set; }
        public int MovementValue { get; set; }
        public int AttemptedValue { get; set; }
    }
}
