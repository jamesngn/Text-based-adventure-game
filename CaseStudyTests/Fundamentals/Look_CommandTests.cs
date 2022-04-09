using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaseStudy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class Look_CommandTests
    {
        Player mainCharacter = new Player("Fred", "the mighty programmer");

        Item gem = new Item(new string[] { "gem" }, "beautiful gem", "This is a beautiful gem");
        Bag bag = new Bag(new string[] { "bag 1", "bag" }, "a leather bag", "This bag can contain everything");

        Look_Command Look = new Look_Command(new string[] { "look" });

        [TestMethod()]
        public void Test_LookAtMe()
        {
            Assert.AreEqual(mainCharacter.FullDescription,Look.Execute(mainCharacter,new string[] { "Look", "at", "inventory" }));
        }

        [TestMethod()]
        public void Test_LookAtGen()
        {
            mainCharacter.Inventory.Put(gem);
            Assert.AreEqual(gem.FullDescription, Look.Execute(mainCharacter, new string[] { "Look", "at", "gem" }));
        }

        [TestMethod()]
        public void Test_LookAtUnk()
        {
            Assert.AreEqual("I can't find the gem", Look.Execute(mainCharacter, new string[] { "Look", "at", "gem" }));
        }

        [TestMethod()]
        public void Test_LookAtGemInMe()
        {
            mainCharacter.Inventory.Put(bag);
            bag.Inventory.Put(gem);
            Assert.AreEqual(gem.FullDescription, Look.Execute(mainCharacter, new string[] { "Look", "at", "gem","in","bag" }));
        }
        [TestMethod()]
        public void Test_LookAtGemInBag()
        {
            mainCharacter.Inventory.Put(gem);
            Assert.AreEqual(gem.FullDescription, Look.Execute(mainCharacter, new string[] { "Look", "at", "gem", "in", "inventory" }));
        }
        [TestMethod()]
        public void Test_LookAtGemInNoBag()
        {
            bag.Inventory.Put(gem);
            Assert.AreEqual("I can't find the bag", Look.Execute(mainCharacter, new string[] { "Look", "at", "gem", "in", "bag" }));
        }
        [TestMethod()]
        public void Test_LookAtNoGemInBag()
        {
            mainCharacter.Inventory.Put(bag);
            Assert.AreEqual("I can't find the gem in the " + bag.Name, Look.Execute(mainCharacter, new string[] { "Look", "at", "gem", "in", "bag" }));
        }
        [TestMethod()]
        public void Test_InvalidLook()
        {
            mainCharacter.Inventory.Put(gem);
            Assert.AreEqual("What do you want to look at?", Look.Execute(mainCharacter, new string[] { "Look", "around", "gem", "in", "inventory" }));
            Assert.AreEqual("Error in look input", Look.Execute(mainCharacter, new string[] { "hello" }));
            Assert.AreEqual("What do you want to look in?", Look.Execute(mainCharacter, new string[] { "Look", "at", "gem", "at", "inventory" }));
        }
    }
}