using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramTest;

namespace ProgramTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public Program program = new Program();

        [TestMethod()]
        public void AddTest()
        {
            Assert.Equals(3, program.Add(1, 2));
        }
    }
}