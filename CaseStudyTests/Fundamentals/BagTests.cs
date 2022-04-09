using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaseStudy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class BagTests
    {
        Item gun = new Item(new string[] { "gun", "ak47" }, "a powerful gun", "This is one shot one kill gun ...");
        Item energyDrink = new Item(new string[] { "drink", "redbull" }, "an energy drink", "This is energy drink that increases power ...");
        Bag bag = new Bag(new string[] { "bag 1", "bag" }, "leather bag", "This bag can countless items");

        Player mainCharacter = new Player("Fred", "the mighty programmer");
        [TestMethod()]
        public void Test_BagLocatesItems()
        {
            bag.Inventory.Put(gun);
            Assert.AreEqual(gun, bag.Locate("ak47"));
            Assert.AreEqual(true, bag.Inventory.HasItem("ak47"));
        }

        [TestMethod()]
        public void Test_BagLocatesItself()
        {
            Assert.AreEqual(bag, bag.Locate("bag 1"));
            Assert.AreEqual(bag, bag.Locate("bag"));
        }
        [TestMethod()]
        public void Test_BagLocatesNothing()
        {
            bag.Inventory.Put(gun);
            Assert.AreEqual(null, bag.Locate("drink"));
        }
        [TestMethod()]
        public void Test_BagFullDescription()
        {
            bag.Inventory.Put(gun);
            bag.Inventory.Put(energyDrink);
            Assert.AreEqual("In the leather bag you can see:\n\ta powerful gun (gun)\n\tan energy drink (drink)\n", bag.FullDescription);
        }
    }
}