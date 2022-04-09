using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaseStudy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class InventoryTests
    {
        Player mainCharacter = new Player("Fred", "the mighty programmer");

        Item sword = new Item(new string[] { "sword" }, "a bronze sword", "a bronze sword is good for hunting animals");
        Item shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
        Bag bag = new Bag(new string[] { "bag 1", "bag" }, "leather bag", "This bag can countless items");
        

        [TestMethod()]
        public void Test_FindItem()
        {
            Assert.AreEqual(false, mainCharacter.Inventory.HasItem("shovel"));
            mainCharacter.Inventory.Put(shovel);
            Assert.AreEqual(true, mainCharacter.Inventory.HasItem("shovel"));
        }

        [TestMethod()]
        public void Test_NoItemFind()
        {
            mainCharacter.Inventory.Put(shovel);
            Assert.AreEqual(false,mainCharacter.Inventory.HasItem("sword"));
        }

        [TestMethod()]
        public void TestFetchItem()
        {
            mainCharacter.Inventory.Put(shovel);
            Assert.AreEqual(shovel, mainCharacter.Inventory.Fetch("shovel"));
            Assert.AreEqual(true, mainCharacter.Inventory.HasItem("shovel"));
        }

        [TestMethod()]
        public void TestTakeItem()
        {
            mainCharacter.Inventory.Put(shovel);
            Assert.AreEqual(shovel, mainCharacter.Inventory.Take("shovel"));
            Assert.AreEqual(false, mainCharacter.Inventory.HasItem("shovel"));
        }

        [TestMethod()]
        public void Test_ItemList()
        {
            mainCharacter.Inventory.Put(shovel);
            mainCharacter.Inventory.Put(sword);
            Assert.AreEqual("\ta shovel (shovel)\n\ta bronze sword (sword)\n", mainCharacter.Inventory.ItemList);
        }
    }
}