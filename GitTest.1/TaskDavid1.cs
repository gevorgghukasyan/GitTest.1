using System;

namespace GitTest._1
{
    internal class TaskDavid1
    {
        public double RefTask(ref double x, ref double y)
        {
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            return x + y;
        }
    }
}
