using HarmonyLib;


namespace KeepFarming
{

    [HarmonyPatch]
    internal class FarmPatch
    {
        static private int canPlace = 0;

        [HarmonyPatch(typeof(PlacementHandlerWatering))]
        [HarmonyPatch("CanPlaceObjectAtPosition")]
        [HarmonyPostfix]
        static void CanPlacePatch(int __result)
        {
            canPlace = __result;
        }


        [HarmonyPatch(typeof(WaterCanSlot))]
        [HarmonyPatch("PlaceItem")]
        [HarmonyPostfix]
        static void WateringPatch()
        {
            if (canPlace >= 1)
            {
                PlayerController pc = CoreLib.Players.GetCurrentPlayer();
                pc.AddSkill(SkillID.Gardening, canPlace);
            }
        }

    }
}
