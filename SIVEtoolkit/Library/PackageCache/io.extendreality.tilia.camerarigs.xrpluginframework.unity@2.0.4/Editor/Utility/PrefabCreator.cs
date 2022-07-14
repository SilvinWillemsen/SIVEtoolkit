namespace Tilia.CameraRigs.XRPluginFramework.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "CameraRigs/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.camerarigs.xrpluginframework.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsUnityXRPluginFramework = "CameraRigs.UnityXRPluginFramework";

        [MenuItem(menuItemRoot + prefabCameraRigsUnityXRPluginFramework, false, priority)]
        private static void AddCameraRigsTrackedAlias()
        {
            string prefab = prefabCameraRigsUnityXRPluginFramework + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}