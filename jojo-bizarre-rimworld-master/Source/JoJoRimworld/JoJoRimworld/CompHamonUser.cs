using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using Verse.AI;
using AbilityUser;

namespace JoJoRimworld
{
    public class CompHamonUser : CompAbilityUser
    {
        

        public bool IsHamonUser => HamonUtility.IsHamonUser(this.Pawn);

        public override bool TryTransformPawn()
        {
            return this.IsHamonUser;
        }



        public override void PostInitialize()
        {
            base.PostInitialize();

            this.AddPawnAbility(JJBRDefOf.JJBR_OverdriveRush);
            this.AddPawnAbility(JJBRDefOf.JJBR_ChargeHamon);
            this.AddPawnAbility(JJBRDefOf.JJBR_SunlightYellowOverdrive);
            this.AddPawnAbility(JJBRDefOf.JJBR_ZoomPunch);


        }

        public void ResolveHamonTab()
        {
            if (!this.Pawn.story.traits.HasTrait(JJBRDefOf.JJBR_HamonWielder))
            {
                InspectTabBase inspectTabsx = base.AbilityUser.GetInspectTabs().FirstOrDefault((InspectTabBase x) => x.labelKey == "JJBR_TabHamon");
                IEnumerable<InspectTabBase> inspectTabs = base.AbilityUser.GetInspectTabs();
                bool flag = inspectTabs != null && inspectTabs.Count<InspectTabBase>() > 0;
                if (flag)
                {
                    if (inspectTabsx == null)
                    {
                        try
                        {
                            base.AbilityUser.def.inspectorTabsResolved.Add(InspectTabManager.GetSharedInstance(typeof(ITab_Hamon)));
                        }
                        catch (Exception ex)
                        {
                            Log.Error(string.Concat(new object[]
                            {
                            "Could not instantiate inspector tab of type ",
                            typeof(ITab_Hamon),
                            ": ",
                            ex
                            }));
                        }
                    }
                }
            }
        }


    }

    

}
