using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitHangIssue.Tests.BaseClasses;

namespace NUnitHangIssue.Tests
{
    public class FastRunningTearDownTests : BaseTestClass

    {
        [TearDown]
        public void OnTearDown()
        {
            Console.WriteLine($"Fast TearDown start/end with thread state {Thread.CurrentThread.ThreadState.ToString()}");
        }


        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_1()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_2()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_3()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_4()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_5()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_6()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_7()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_8()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }

        [Test]
        [Timeout(TimeoutValue)]
        public void DoWork_Wait_9()
        {
            var testSubject = new TestableWorker();
            testSubject.DoWork();
            Assert.True(true);
        }
    }
}
