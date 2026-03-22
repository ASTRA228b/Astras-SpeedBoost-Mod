using UnityEngine;
using BepInEx;
using Astras_SpeedBoost_Mod.Core;
using Astras_SpeedBoost_Mod.Stuff;


namespace Astras_Velmax_Mod.Plugin;

[BepInPlugin(Constantss.GUID, Constantss.Name, Constantss.Version)]
public class Plugin : BaseUnityPlugin
{
    void Start()
    {
        PatchLoader.Apply();
    }

    void Awake()
    {
        GameObject Plugin = new GameObject(Constantss.ObjectName);
        Plugin.AddComponent<Main>();
        DontDestroyOnLoad(Plugin);
    }
}