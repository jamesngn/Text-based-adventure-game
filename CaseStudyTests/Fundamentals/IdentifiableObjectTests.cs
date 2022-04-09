using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaseStudy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class IdentifiableObjectTests
    {
        [TestMethod()]
        public void areYouTests()
        {
            //Arrange
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            //Act

            //Assert
            Assert.AreEqual(true, id.areYou("fred"));
            Assert.AreEqual(true, id.areYou("bob"));
            Assert.AreEqual(false, id.areYou("wilma"));
            Assert.AreEqual(false, id.areYou("boby"));
            Assert.AreEqual(true, id.areYou("FRED"));
            Assert.AreEqual(true, id.areYou("bOB"));
        }
        [TestMethod()]
        public void firstIDTests()
        {
            //Arrange
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            //Act

            //Assert
            Assert.AreEqual("fred", id.FirstID);
        }
        [TestMethod()]
        public void addIDTests()
        {
            //Arrange
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            //Act
            id.addIdentifier("wilma");
            //Assert
            Assert.AreEqual(true, id.areYou("fred"));
            Assert.AreEqual(true, id.areYou("bob"));
            Assert.AreEqual(true, id.areYou("wilma"));
        }
    }
}