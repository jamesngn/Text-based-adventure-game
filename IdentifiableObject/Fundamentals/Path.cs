using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    public class Path : IdentifiableObject
    {
        private List<Location> _map = new List<Location>();

        public Path() : base(new string[] { string.Empty }) 
        {
            _map.Add(new Location(new string[] { "midlane", "mid"}, "the Faker Midlane", "Mid lane allows you to experiment with champions that are weak earlier in the game.\n Try out some champions like Veigar and Kassadin that scale well as the game progresses.\n Make sure you track the enemy jungler as best you can before going for trades in lane.", new Direction(-1, 4, -1, 1)));
            _map.Add(new Location(new string[] { "baron" }, "the Baron Cave", "Baron Nashor is a neutral monster that appears on the map Summoner's Rift and is currently the most powerful neutral monster.", new Direction(3, -1, 0, 2)));
            _map.Add(new Location(new string[] { "toplane", "top"}, "the Shy TopLane", "Top is a long lane and there is no ally champion to lane with.\n This means top laners are most often tanks or high damage champions that can make use of the long lane to run down enemies.\n The 1v1 nature of top also means there are more champion options than any other role.", new Direction(-1, -1, 1, -1)));
            _map.Add(new Location(new string[] { "blue" }, "a Blue Sentinel", "The blue buff gives Increased Mana Regeneration and Cooldown Reduction by Twenty Percent.", new Direction(-1, 1, -1, -1)));
            _map.Add(new Location(new string[] { "dragon" }, "a Dragon Cave", "Killing the dragon grants experience to killer and nearby allies. If the killing team is lower average level than their opponents, the Dragon grants a bonus XP of +25% per average level difference.", new Direction(0, 6, -1, 5)));
            _map.Add(new Location(new string[] { "bot" }, "a Doublelife Botlane", "Bot laners are usually under-leveled from sharing experience in game, making them easy to kill.\n Bot laners also are a big damage threat on the team and that makes you a target for the enemy team in fights. ", new Direction(-1, -1, 4, -1)));
            _map.Add(new Location(new string[] { "red" }, "a Red Sentinel", "Grants health regen, causes your basic attacks to slow, and your basic attacks true damage over time", new Direction(4, -1, -1, -1)));
        }

        private int directMapNumber(Location a, string dir) 
        {
            if (dir == "north" || dir == "n")
            {
                return a.Direction.North;
            }
            if (dir == "south" || dir == "s")
            {
                return a.Direction.South;
            }
            if (dir == "east" || dir == "e")
            {
                return a.Direction.East;
            }
            if (dir == "west" || dir == "w")
            {
                return a.Direction.West;
            }
            return -1;                
        }
        public Location Move(Location loc,  string dir)
        {
            if (directMapNumber(loc, dir) >= 0) { return Map[directMapNumber(loc, dir)]; }
            return loc;
        }

        public List<Location> Map
        {
            get => this._map;
            set => this._map = value;
        }
    }
}


/*all locations are stored in the map, in the location (List)
 *path class can tell the current location to the direction --> return a destination --> player.Location = destination
 *location can know the direction to other locations (know exits).
 *Location.northExit = Map[n];
 *  "
 *  if a move command: move north, the keyword "north" can be found in the current location's path ID (p.Location.path.Locate("north") == true)
 *  if true --> switch case statement to transfer the "north" --> 
 */