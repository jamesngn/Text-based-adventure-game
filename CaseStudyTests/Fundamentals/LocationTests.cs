using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaseStudy.Tests
{
    [TestClass()]
    public class LocationTests
    {
        Player mainCharacter = new Player("Fred", "the mighty programmer");

        Location hallway = new Location(new string[] { "hallway", "location1" }, "the Hallway", "This is a long well lit hallway", new Direction(-1, 1, -1, -1));
        Item sword = new Item(new string[] { "sword" }, "a bronze sword", "a bronze sword is good for hunting animals");
        Item shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
        
        
        [TestMethod()]
        public void Test_LocationIdentifyThemselves()
        {
            Assert.AreEqual(hallway, hallway.Locate("hallway"));
            Assert.AreEqual(hallway, hallway.Locate("location1"));
        }

        [TestMethod()]
        public void Test_LocateItemsInLocation()
        {
            hallway.Inventory.Put(shovel);
            Assert.AreEqual(shovel, hallway.Locate("shovel"));
            Assert.AreEqual(null, hallway.Locate("sword"));
        }

        [TestMethod()]
        public void Test_LocateItemsInPlayerLocation()
        {
            mainCharacter.Location = hallway;
            hallway.Inventory.Put(shovel);

            Assert.AreEqual(shovel, mainCharacter.Locate("shovel"));
            Assert.AreEqual(null, mainCharacter.Locate("sword"));
        }
        [TestMethod()]
        public void Test_LookAtItemInPlayerLocation()
        {
            mainCharacter.Location = hallway;
            hallway.Inventory.Put(shovel);
            Look_Command Look = new Look_Command(new string[] { "look" });
            Assert.AreEqual(shovel.FullDescription, Look.Execute(mainCharacter,new string[] {"Look","At","shovel" }));
            Assert.AreEqual("I can't find the sword", Look.Execute(mainCharacter, new string[] { "Look", "At", "sword" }));
        }
    }
}