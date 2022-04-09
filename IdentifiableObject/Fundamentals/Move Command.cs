namespace CaseStudy
{
    public class Move_Command : Command
    {
        public Move_Command() : base(new string[] { "move", "go"})
        {

        }
        public override string Execute(Player p, string[] text)
        {
            //if (text[0].ToLower() != "move" || text[0].ToLower() != "go") { return "Error in ";//later }
            if (areYou(text[0].ToLower()))
            {
                if (text.Length == 2)
                {
                    if (p.Path.areYou(text[1]))
                    {
                        p.Location = p.Path.Move(p.Location, text[1].ToLower());
                        return "\nYou are heading " + text[1].ToLower() + "\nYou have arrived in " + p.Location.Name + "\n";
                    }
                }
            }
            return null;
        }
    }
}
