using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GlowSuppressor
{
	[KSPAddon (KSPAddon.Startup.Flight, false)]
	public class GlowSuppressor : MonoBehaviour
	{
		void LateUpdate ()
		{
			if (!FlightGlobals.ready) {
				print ("GlowSuppressor: FlightGlobals not ready!");
			} else {
				if (FlightGlobals.Vessels == null) {
					print ("GlowSuppressor: FlightGlobals.Vessels is null!");
				} else {
					foreach (Vessel v in FlightGlobals.Vessels) {
						if (v == null) {
							print ("GlowSuppressor: vessel is null!");
						} else {
							if (v.rootPart == null) {
								//print ("GlowSuppressor: ignoring " + v.vesselName);
							} else {
								//print ("GlowSuppressor: unhighlighting " + v.vesselName);
								v.rootPart.SetHighlight (false, true);
							}
						}
					}
				}
			}
		}
	}
}
