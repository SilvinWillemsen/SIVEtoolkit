namespace Tilia.CameraRigs.TrackedAlias.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "CameraRigs/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.camerarigs.trackedalias.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsTrackedAlias = "CameraRigs.TrackedAlias";

        [MenuItem(menuItemRoot + prefabCameraRigsTrackedAlias, false, priority)]
        private static void AddCameraRigsTrackedAlias()
        {
            string prefab = prefabCameraRigsTrackedAlias + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}