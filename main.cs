using System;
public class Gameclock
{
    int tickspeed = 1000;
    public static System.Timers.Timer tick;
    public static void Main()
    {
        StartTicks();
    }
    
    public static void StartTicks()
    {
        tick = new System.Timers.Timer(tickspeed);
        tick.Elapsed += O
    }
}