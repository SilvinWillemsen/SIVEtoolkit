namespace Tilia.Locomotors.Teleporter.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Locomotors/Teleporter/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.locomotors.teleporter.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabTeleporterInstant = "Locomotors.Teleporter.Instant";
        private const string prefabTeleporterDash = "Locomotors.Teleporter.Dash";

        [MenuItem(menuItemRoot + prefabTeleporterInstant, false, priority)]
        private static void AddTeleporterInstant()
        {
            string prefab = prefabTeleporterInstant + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabTeleporterDash, false, priority)]
        private static void AddTeleporterDash()
        {
            string prefab = prefabTeleporterDash + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}