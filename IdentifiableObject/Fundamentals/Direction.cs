using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    public class Direction
    {
        private int _n, _s, _w, _e;
        public Direction(int n, int s, int w, int e)
        {
            this._n = n;
            this._s = s;
            this._w = w;
            this._e = e;
        }
        public string Exit
        {
            get
            {
                List<string> exits = new List<string>();
                string e = "";
                if (North != -1) { exits.Add("north"); }
                if (South != -1) { exits.Add("south"); }
                if (East != -1) { exits.Add("east"); }
                if (West != -1) { exits.Add("west"); }
                for (int i = 0; i < exits.Count; i++)
                {
                    if (i == exits.Count - 1 && exits.Count != 1)
                    {
                        e += "and " + exits[i] + ". ";
                    }
                    else if (exits.Count == 1)
                    {
                        e += exits[i] + ".";
                    }
                    else
                    {
                        e += exits[i] + ", ";
                    }
                }
                return e;
            }
        }
        public int North
        {
            get => this._n;
            set => this._n = value;
        }
        public int South
        {
            get => this._s;
            set => this._s = value;
        }
        public int West
        {
            get => this._w;
            set => this._w = value;
        }
        public int East
        {
            get => this._e;
            set => this._e = value;
        }
    }
}
