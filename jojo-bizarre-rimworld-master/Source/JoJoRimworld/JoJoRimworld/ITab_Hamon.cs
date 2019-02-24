using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace JoJoRimworld
{
    [StaticConstructorOnStartup]
    public class ITab_Hamon : ITab
    {




        private Pawn PawnToShowInfoAbout
        {
            get
            {
                Pawn pawn = null;
                bool flag = base.SelPawn != null;
                if (flag)
                {
                    pawn = base.SelPawn;
                }
                else
                {
                    Corpse corpse = base.SelThing as Corpse;
                    bool flag2 = corpse != null;
                    if (flag2)
                    {
                        pawn = corpse.InnerPawn;
                    }
                }
                bool flag3 = pawn == null;
                Pawn result;
                if (flag3)
                {
                    Log.Error("Character tab found no selected pawn to display.");
                    result = null;
                }
                else
                {
                    result = pawn;
                }
                return result;
            }
        }

        public override bool IsVisible
        {
            get
            {

                bool flag = base.SelPawn.story != null && base.SelPawn.IsColonist;
                if (flag)
                {
                    if (base.SelPawn.story.traits.HasTrait(JJBRDefOf.JJBR_HamonWielder))
                    {
                        return flag && true;
                    }


                }
                return false;


            }
        }



        public ITab_Hamon()
        {
            this.size = HamonCardUtility.hamonCardSize + new Vector2(17f, 17f) * 2f;
            this.labelKey = "JJBR_TabHamon";
        }

        protected override void FillTab()
        {
            Rect rect = new Rect(17f, 17f, HamonCardUtility.hamonCardSize.x, HamonCardUtility.hamonCardSize.y);
            HamonCardUtility.DrawHamonCard(rect, this.PawnToShowInfoAbout);
        }


       

    }

   
}
        
