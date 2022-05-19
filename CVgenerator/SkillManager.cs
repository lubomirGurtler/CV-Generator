using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CVgenerator
{
    class SkillManager
    {
        public BindingList<Skill>  skills = new BindingList<Skill>();

        public void AddSkill(Skill skill)
        {
            skills.Add(skill);
        }

        public List<string> GetSkills()
        {
            List<string> skill = new List<string>();
            var request = from x in skills
                          orderby x.LevelSelectedIndex descending
                          select x.ToString();
            foreach (var element in request)
            {
                skill.Add(element);
            }
            return skill;
        }
    }
}
