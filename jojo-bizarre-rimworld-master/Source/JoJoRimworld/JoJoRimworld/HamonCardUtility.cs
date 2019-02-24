using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;

namespace JoJoRimworld
{
    public class HamonCardUtility
    {  
    
            public static Vector2 hamonCardSize = new Vector2(395f, 536f); // set the card's size

            public static void DrawHamonCard(Rect rect, ThingWithComps wornAtThing)
            {
            GUI.BeginGroup(rect);
            
            GUI.EndGroup();
            }
        
    }
}
