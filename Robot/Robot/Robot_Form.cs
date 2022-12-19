using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class Robot_Form : Form
    {
        public Robot robot = new Robot();
        public enum Arrows // Arrow direction char values
        {
            LEFT = 231,
            RIGHT = 232,
            UP = 233,
            DOWN = 234
        }
        public Robot_Form()
        {
            InitializeComponent();
            robot.RobotMoved += OnRobotMoved;
            robot.RobotPositionLimitReached += OnRobotPositionLimitReached;
            robot.RobotMoveInvalid += OnRobotMoveInvalid;
            // Initialize the event handlers
        }
        private void Exit_Button_Click(object sender, EventArgs e) { Close(); }








        // Handles the form when the robot is moved using Robot.Move
        public void OnRobotMoved(object sender, RobotMovementEventArgs e)
        {
            switch (e.Direction)
            {
                case Robot.Directions.NORTH:
                    Robot_Label.Location = new Point() { X = Robot_Label.Location.X, Y = Robot_Label.Location.Y - e.MovementValue };
                    UpdatePositionLabel(robot.Position);
                    return;
                case Robot.Directions.SOUTH:
                    Robot_Label.Location = new Point() { X = Robot_Label.Location.X, Y = Robot_Label.Location.Y + e.MovementValue };
                    UpdatePositionLabel(robot.Position);
                    return;
                case Robot.Directions.EAST:
                    Robot_Label.Location = new Point() { X = Robot_Label.Location.X + e.MovementValue, Y = Robot_Label.Location.Y };
                    UpdatePositionLabel(robot.Position);
                    return;
                case Robot.Directions.WEST:
                    Robot_Label.Location = new Point() { X = Robot_Label.Location.X - e.MovementValue, Y = Robot_Label.Location.Y };
                    UpdatePositionLabel(robot.Position);
                    return;
            }
        }
        public void OnRobotPositionLimitReached(object sender, RobotMovementEventArgs e) // Robot has reached a direction limit
        {
            Console.WriteLine($"The robot has failed to move to {e.AttemptedValue} {e.Direction} because " +
                $"{e.AttemptedValue} exceeds {e.MaxValue}.");
            MessageBox.Show($"The robot has failed to move to {e.AttemptedValue} {e.Direction} because " +
                $"{e.AttemptedValue} exceeds {e.MaxValue}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void OnRobotMoveInvalid(object sender, RobotMovementEventArgs e) // Invalid entry for robot move call
        {
            Console.WriteLine($"Invalid attempted robot movement ({e.AttemptedValue}). Move must be called within 0 and {e.MaxValue}");
        }
        public void UpdatePositionLabel(Point p) { Coordinates_Label.Text = p.ToString(); } // Updates the label to the robot's position

        // Movement Button Clicks
        public void MoveOne_Button_Click(object sender, EventArgs e)
        {
            robot.Move(1);

        }
        public void MoveTen_Button_Click(object sender, EventArgs e)
        {
            robot.Move(10);
        }

        // Direction Button Clicks
        public void North_Button_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.Directions.NORTH;
            Robot_Label.Text = ((char)Arrows.UP).ToString();
        }
        public void South_Button_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.Directions.SOUTH;
            Robot_Label.Text = ((char)Arrows.DOWN).ToString();
        }
        public void East_Button_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.Directions.EAST;
            Robot_Label.Text = ((char)Arrows.RIGHT).ToString();
        }
        public void West_Button_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.Directions.WEST;
            Robot_Label.Text = ((char)Arrows.LEFT).ToString();
        }

    }
}
