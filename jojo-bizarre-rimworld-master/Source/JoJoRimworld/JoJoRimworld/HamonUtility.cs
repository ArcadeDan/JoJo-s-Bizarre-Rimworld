using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;


namespace JoJoRimworld
{
    static class HamonUtility
    {
        public static bool IsHamonUser(this Pawn p)
        {
            if (p != null)
            {
                if (p?.story?.traits is TraitSet t)
                {
                    if (t.HasTrait(JJBRDefOf.JJBR_HamonWielder))
                        return true;
                }
            }
            return false;
        }

         public static CompHamonUser GetHamonUser(Pawn pawn)
        {
            if (pawn?.GetComp<CompHamonUser>() is CompHamonUser hamonUser)
            {
                return hamonUser;
            }

            return null;
        }

    }
}
