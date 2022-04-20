using System;
public class Gameclock
{
    public int tickspeed = 1000;
    public int ticksDone;
    public static System.Timers.Timer tick;
    public static void Main()
    {
        while (ticksDone <= 10)
        {
        StartTicks();
        }
        tick.Stop;
        tick.Dispose;
    }
    
    public static void StartTicks()
    {
        tick = new System.Timers.Timer(tickspeed);
        tick.Elapsed += OnTimedEvent;
        tick.AutoReset = true;
        tick.Enabled = true;
    }

    public static void OnTimedEvent()
    {
        ticksDone ++;
    }
}