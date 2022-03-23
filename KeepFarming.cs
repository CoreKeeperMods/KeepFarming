using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;

namespace KeepFarming {
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInDependency("com.le4fless.corelib", "0.0.1")]
    public class KeepFarming : BasePlugin {

        public const string GUID = "com.le4fless.keepfarming";
        public const string NAME = "KeepFarming";
        public const string VERSION = "0.0.1";

        internal static ManualLogSource Logger { get; private set; }
        public override void Load() {
            Logger = base.Log;

            var harmony = new Harmony("com.le4fless.keepfarming");
            harmony.PatchAll();

            Log.LogInfo($"{PluginInfo.PLUGIN_NAME} is loaded!");
        }
    }
}
