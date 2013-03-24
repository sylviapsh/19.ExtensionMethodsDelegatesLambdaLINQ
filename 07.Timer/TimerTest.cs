namespace Timer
{
    class TimerTest
    {
        static void Main()
        {
            Timer timerOne = new Timer(5000, Timer.TestMethodOne);
            Timer timerTwo = new Timer(1000, Timer.TestMethodTwo);
        }
    }
}
