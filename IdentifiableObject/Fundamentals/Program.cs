using System.Collections.Generic;
using System;
namespace CaseStudy
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommandProcessor command = new CommandProcessor();
            string commandInput = "";

            Player mainCharacter = new Player("Fred", "the mighty programmer");
            
            Item bfsword = new Item(new string[] { "bfsword" }, "a B.F sword", "a B.F sword has +40 attack damage");
            Item boots = new Item(new string[] { "boot"}, "Berserker's Greaves", "the Berserker's Greaves increases 35% attach speed and +45 movement speed.");
            Item rabadon = new Item(new string[] { "rabadon" }, "a Rabadon's Deathcrown", "The Rabadon's Deathcrown has +175 ability power");
            Item deadmanplate = new Item(new string[] { "deadman" }, "a Dead Man's Plate", "While moving, generates 7 stacks of Momentum each 0.25 seconds, \ngranting up to 40 bonus movement speed at 100 stacks after 3.75 seconds of moving. \nMomentum decays by 15 every 0.25 seconds while immobilized.");
            Item infinity_edge = new Item(new string[] { "infinity" }, "an Infinity Edge", "Gain 35% bonus critical strike damage if you have at least 60% critical strike chance.");
            Item bloodthirster = new Item(new string[] { "bloodthirster" }, "a Bloodthirster", "Convert the healing received from life steal in excess of 100% maximum health into a shield for up to 50 − 350 (based on level), which slowly decays after not dealing or taking damage for 25 seconds.");
            Item spiritvisage = new Item(new string[] { "spiritvisage" }, "a Spirit Visage", "Increases all healing and shielding received by 25%.");
            Item warmog = new Item(new string[] { "warmog" }, "a Warmog's Armo", "Regenerate every 0.5 seconds if damage has been taken in the last 6 seconds (3 seconds for damage from non-champions.");
            Item nightharvester = new Item(new string[] { "nightharvester" }, "a Night Harvester", "Damaging an enemy champion deals 125 (+15% AP) bonus magic damage and grants you 25% bonus movement speed for 1.5 seconds,\n with the duration extending on subsequent triggers (40 (per champion) second cooldown)");
            Item blueSword = new Item(new string[] { "bluesword" }, "a Blue Buffed sword", "The Blue Buffed sword can deal more ability power on enemies");
            Item redSword = new Item(new string[] { "redsword" }, "a Red Buffed sword", "The Red Buffed sword can deal more attack damage on enemies");

            mainCharacter.Path.Map[0].Inventory.Put(rabadon);
            mainCharacter.Path.Map[0].Inventory.Put(nightharvester);
            mainCharacter.Path.Map[1].Inventory.Put(bfsword);
            mainCharacter.Path.Map[2].Inventory.Put(deadmanplate);
            mainCharacter.Path.Map[2].Inventory.Put(spiritvisage);
            mainCharacter.Path.Map[2].Inventory.Put(warmog);
            mainCharacter.Path.Map[3].Inventory.Put(blueSword);
            mainCharacter.Path.Map[4].Inventory.Put(bloodthirster);
            mainCharacter.Path.Map[4].Inventory.Put(boots);
            mainCharacter.Path.Map[5].Inventory.Put(infinity_edge);
            mainCharacter.Path.Map[6].Inventory.Put(redSword);

            Console.WriteLine("Command List:\nLook: look, look at [item], look at [me/inventory], look at [item] in [location]\nTake: take [item]\nMove: move, go [direction: North, South, East, West]\n");
            Console.WriteLine(mainCharacter.Location.FullDescription);
            while (commandInput != "quit")
            {
                
                commandInput = Console.ReadLine();
                Console.WriteLine(command.Execute(mainCharacter, commandInput));
            }
        }
    }
}
