using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;

namespace KeepFarming {
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency(CoreLib.PluginInfo.PLUGIN_GUID, CoreLib.PluginInfo.PLUGIN_VERSION)]
    public class KeepFarming : BasePlugin {
        internal static ManualLogSource Logger { get; private set; }
        public override void Load() {
            Logger = base.Log;

            var harmony = new Harmony("com.le4fless.keepfarming");
            harmony.PatchAll();

            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
