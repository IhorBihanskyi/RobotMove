using MoveRobot;

public class Program
{
    public static void Main()
    {
        RobotMovement robot = new(Direction.North, 7, 3);
        robot.Move("RAALAL");

        Console.WriteLine($"Robot located in ({robot.X},{robot.Y}) facing {robot.Direction}");
    }
}