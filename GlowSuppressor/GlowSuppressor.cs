using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GlowSuppressor
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class GlowSuppressor : MonoBehaviour
    {
        void Update()
        {
            foreach (Vessel v in FlightGlobals.Vessels)
            {
                if (v != null)
                    SuppressGlow(FlightGlobals.ActiveVessel.rootPart);
            }
        }

        private static void SuppressGlow(Part part)
        {
            part.SetHighlightType(Part.HighlightType.Disabled);
            part.SetHighlight(false);

            // Reset the glow for all the child parts
            foreach (Part child in part.children)
                GlowSuppressor.SuppressGlow(child);
        }

    }
}
