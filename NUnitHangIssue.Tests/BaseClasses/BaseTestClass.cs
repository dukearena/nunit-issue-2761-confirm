using System;
using NUnit.Framework;

namespace NUnitHangIssue.Tests.BaseClasses
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public abstract class BaseTestClass
    {
        public const int TimeoutValue = 5000;
    }
}
