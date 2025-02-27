﻿using Units.Skills;

namespace Units.FriendlyUnits
{
    /// <summary>
    /// 武僧
    /// </summary>
    public class Monk : Friendly
    {
        public Monk()
        {
            this.type = 4;
            this.UnitName = "Monk";
            this.level = 1;
            this.BaseHealth = 28;
            this.BaseMp = 17;
            this.BaseMv = 4;
            this.BaseDefense = 5;
            this.BaseDamage = 15;
            this.BaseAtkRange = 1;
            this.DefenseUpdateRate = 1.1f;
            this.Skills.AddLast(new Ban());
            foreach (Skill skill in Skills)
            {
                skill.BelongTo = this;
            }
            UpdatePanel();
        }
    }
}