using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    class CommandProcessor
    {
        List<Command> commandList = new List<Command>(3) { new Look_Command(), new Move_Command(), new Take_Command()};
        public CommandProcessor() { }

        public string Execute(Player p, string text)
        {
            string[] words = text.Split(' ');
            if (commandList[0].areYou(words[0]))
            {
               return commandList[0].Execute(p, words);
            }
            else if (commandList[1].areYou(words[0]))
            {
               return commandList[1].Execute(p, words);
            }
            else if (commandList[2].areYou(words[0]))
            {
                return commandList[2].Execute(p, words);
            }
            return null;
        }
        
    }
}
