using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Robot
{
    
    public class Robot
    {
        public enum Directions
        {
            NORTH,
            SOUTH,
            EAST,
            WEST
        }
        //
        public Directions Direction { get; set; } = Directions.NORTH;
        public Point Position => position;
        private Point position = new Point() { X = 0, Y = 0 };
        private const int MAX = 100; // Maximum allowed position of the robot in any given direction.
        private const int NMAX = MAX * -1; // Negatives for MAX
        //
        public event EventHandler<RobotMovementEventArgs> RobotPositionLimitReached;
        public event EventHandler<RobotMovementEventArgs> RobotMoved;
        public event EventHandler<RobotMovementEventArgs> RobotMoveInvalid;
        //
        public Robot() { }
        public Robot(Directions dir) => Direction = dir;
        public Robot(Directions dir, Point pos) { Direction = dir; position = pos; }
        public Robot(Directions dir, int xPos, int yPos) { Direction = dir; position.X = xPos; position.Y = yPos; }
        //

        // Move methods for the robot. Returns a true or false value if the robot has completed a move or not.
        // Raises the RobotPositionLimitReached && RobotMoved Events
        public bool Move(int moves)
        {
            var movementInfo = new RobotMovementEventArgs() { Direction = Direction, MovementValue = moves };
            if(moves <= 0 || moves > MAX)
            {
                movementInfo.MaxValue = MAX;
                movementInfo.AttemptedValue = moves;
                OnRobotMoveInvalid(movementInfo);
                return false;
            }
            switch(Direction)
            {
                case Directions.NORTH:
                    movementInfo.MaxValue = MAX;
                    movementInfo.AttemptedValue = Position.Y + moves;
                    if (Position.Y + moves > MAX)
                    {
                        OnRobotPositionLimitReached(movementInfo);
                        return false;
                    } else { position.Y += moves; OnRobotMoved(movementInfo); return true; }
                case Directions.SOUTH:
                    movementInfo.MaxValue = NMAX;
                    movementInfo.AttemptedValue = Position.Y - moves;
                    if (Position.Y - moves < NMAX)
                    {
                        OnRobotPositionLimitReached(movementInfo);
                        return false;
                    }
                    else { position.Y -= moves; OnRobotMoved(movementInfo); return true; }
                case Directions.EAST:
                    movementInfo.MaxValue = MAX;
                    movementInfo.AttemptedValue = Position.X + moves;
                    if (Position.X + moves > MAX)
                    {
                        OnRobotPositionLimitReached(movementInfo);
                        return false;
                    }
                    else { position.X += moves; OnRobotMoved(movementInfo); return true; }
                case Directions.WEST:
                    movementInfo.MaxValue = NMAX;
                    movementInfo.AttemptedValue = Position.X - moves;
                    if (Position.X - moves < NMAX)
                    {
                        OnRobotPositionLimitReached(movementInfo);
                        return false;
                    }
                    else { position.X -= moves; OnRobotMoved(movementInfo); return true; }
            }
            return false;
        }




        protected virtual void OnRobotMoved(RobotMovementEventArgs e)
        {
            RobotMoved?.Invoke(this, e);
        }
        protected virtual void OnRobotPositionLimitReached(RobotMovementEventArgs e)
        {
            RobotPositionLimitReached?.Invoke(this, e);
        }
        protected virtual void OnRobotMoveInvalid(RobotMovementEventArgs e)
        {
            RobotMoveInvalid?.Invoke(this, e);
        }
    }
}
