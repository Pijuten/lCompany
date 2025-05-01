using BepInEx;
using HarmonyLib;

namespace lCompany
{
    [BepInPlugin("com.yourname.modname", "Mod Name", "1.0.0")]
    public class ModName : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony harmony = new Harmony("com.yourname.modname");
            harmony.PatchAll();
            Logger.LogInfo("Mod Name loaded.");
        }
    }
}
