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
        void LateUpdate()
        {
            foreach (Vessel v in FlightGlobals.Vessels)
            {
                v.rootPart.SetHighlight(false, true);
            }
        }
    }
}
