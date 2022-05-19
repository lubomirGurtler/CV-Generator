using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVgenerator
{
    class Skill
    {
        public string Ability { get; set; }

        public string Level { get; set; }

        public int LevelSelectedIndex { get; set; }

        public Skill(string ability, string level, int levelSelectedIndexl)
        {
            Ability = ability; Level = level; LevelSelectedIndex = levelSelectedIndexl;
        }

        public override string ToString()
        {
            return Ability + ":" + Level;
        }
    }
}
