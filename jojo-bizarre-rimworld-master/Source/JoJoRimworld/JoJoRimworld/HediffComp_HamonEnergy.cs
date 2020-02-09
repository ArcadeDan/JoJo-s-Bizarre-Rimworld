using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace JoJoRimworld
{
    [StaticConstructorOnStartup]
    class HediffComp_HamonEnergy : HediffComp
    {
        public Pawn hamonPawn = null;


        public string labelCap
        {
            get
            {
                return base.Def.LabelCap;
            }
        }

        public string label
        {
            get
            {
                return base.Def.label;
            }
        }

        private void Initialize()
        {
            bool spawned = base.Pawn.Spawned;
            CompHamonUser comp = this.hamonPawn.GetComp<CompHamonUser>();
         
           
        }



    }
}
