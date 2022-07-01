namespace Tilia.Mutators.ObjectFollower.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Mutators/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.mutators.objectfollower.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabObjectFollower = "Mutators.ObjectFollower";
        private const string prefabRigidbodyFollower = "Mutators.RigidbodyFollower";

        [MenuItem(menuItemRoot + prefabObjectFollower, false, priority)]
        private static void AddObjectFollower()
        {
            string prefab = prefabObjectFollower + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + prefabRigidbodyFollower, false, priority)]
        private static void AddRigidbodyFollower()
        {
            string prefab = prefabRigidbodyFollower + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}