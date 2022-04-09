using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        Location location;
        Player mainCharacter = new Player("Fred", "the mighty programmer");
        Item shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
        Item sword = new Item(new string[] { "sword", "katana" }, "a sword", "This is a king sword ...");

        [TestMethod()]
        public void Test_PlayerIsIdentifiable()
        {
            Assert.AreEqual(true, mainCharacter.areYou("me"));
            Assert.AreEqual(true, mainCharacter.areYou("inventory"));
        }

        [TestMethod()]
        public void Test_LocateItem()
        {
            mainCharacter.Inventory.Put(shovel);
            mainCharacter.Inventory.Put(sword);
            Assert.AreEqual(shovel, mainCharacter.Locate("shovel"));
            Assert.AreEqual(mainCharacter, mainCharacter.Locate("me"));
            Assert.AreEqual(mainCharacter, mainCharacter.Locate("inventory"));
        }
        [TestMethod()]
        public void Test_LocateItself()
        {
            Assert.AreEqual(mainCharacter, mainCharacter.Locate("me"));
            Assert.AreEqual(mainCharacter, mainCharacter.Locate("inventory"));
        }
        [TestMethod()]
        public void Test_LocateNothing()
        {
            Assert.AreEqual(null, mainCharacter.Locate("gun"));
        }
        [TestMethod()]
        public void Test_PlayerFullDescription()
        {
            mainCharacter.Inventory.Put(shovel);
            mainCharacter.Inventory.Put(sword);
            Assert.AreEqual("You are carrying:\n\ta shovel (shovel)\n\ta sword (sword)\n", mainCharacter.FullDescription);
        }
    }
}