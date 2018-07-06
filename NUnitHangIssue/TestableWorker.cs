using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnitHangIssue
{
    public class TestableWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Start working hard, uff..");
            Thread.Sleep(100); // Emulate some work
            Console.WriteLine("End of the work!");
        }
    }
}
