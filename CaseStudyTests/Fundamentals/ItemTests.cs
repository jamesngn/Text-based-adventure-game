using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaseStudy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class ItemTests
    {
        Item sword = new Item(new string[] { "sword" }, "a bronze sword", "a bronze sword is good for hunting animals");
        Item shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
        [TestMethod()]
        public void Test_ItemIsIdentifiable()
        {
            //Arrange
            
            //Act

            //Assert
            Assert.AreEqual(true, sword.areYou("sword"));
        }
        [TestMethod()]
        public void Test_ShortDescription()
        {
            //Arrange
            //Act

            //Assert
            Assert.AreEqual("a bronze sword (sword)", sword.ShortDescription);
        }
        [TestMethod()]
        public void Test_FullDescription()
        {
            //Arrange

            //Act

            //Assert
            Assert.AreEqual("a bronze sword is good for hunting animals", sword.FullDescription);
        }
    }
}