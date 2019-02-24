using RimWorld;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbilityUser;
using AbilityUserAI;

namespace JoJoRimworld
{
    public class HamonData
    {
        private Pawn pawn;
        private bool initialized = false;
        public bool hamonPowersInitialized = false;
        private List<HamonSkill> skills;
        private List<HamonPower> powers;
        public bool HamonPowersInitialized { get => hamonPowersInitialized; set => hamonPowersInitialized = value; }
        public Pawn Pawn => pawn;

        public List<HamonSkill> Skills
        {
            get
            {
                if (skills == null)
                {
                    skills = new List<HamonSkill>
                    {

                    };
                }
                return skills;
            }
        }

        public List<HamonPower> Powers
        {
            get
            {
                if (powers == null)
                {
                    powers = new List<HamonPower>
                    {
                        new HamonPower(new List<AbilityDef> { JJBRDefOf.JJBR_ChargeHamon }),
                        new HamonPower(new List<AbilityDef> { JJBRDefOf.JJBR_ZoomPunch }),
                        new HamonPower(new List<AbilityDef> { JJBRDefOf.JJBR_OverdriveRush }),
                        new HamonPower(new List<AbilityDef> { JJBRDefOf.JJBR_SunlightYellowOverdrive }),


                    };
                }
                return powers;
            }
        }

        public HamonData()
        {

        }

        public HamonData(CompHamonUser newUser)
        {
            this.pawn = newUser.AbilityUser;
        }


    }
}
