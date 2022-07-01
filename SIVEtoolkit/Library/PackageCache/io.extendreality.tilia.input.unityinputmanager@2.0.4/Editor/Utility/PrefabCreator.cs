namespace Tilia.Input.UnityInputManager.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Input/UnityInputManager/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;
        private const string actionRoot = "Actions/";
        private const string mappingRoot = "ControllerMappings/";

        private const string package = "io.extendreality.tilia.input.unityinputmanager";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabUnityInputManager1DAxisAction = "Input.UnityInputManager.1DAxisAction";
        private const string prefabUnityInputManager2DAxisAction = "Input.UnityInputManager.2DAxisAction";
        private const string prefabUnityInputManagerButtonAction = "Input.UnityInputManager.ButtonAction";

        private const string prefabUnityInputManagerOculusRemote = "Input.UnityInputManager.Oculus.Remote";
        private const string prefabUnityInputManagerOculusTouchLeftController = "Input.UnityInputManager.Oculus.TouchLeftController";
        private const string prefabUnityInputManagerOculusTouchRightController = "Input.UnityInputManager.Oculus.TouchRightController";
        private const string prefabUnityInputManagerOpenVRLeftController = "Input.UnityInputManager.OpenVR.LeftController";
        private const string prefabUnityInputManagerOpenVRRightController = "Input.UnityInputManager.OpenVR.RightController";
        private const string prefabUnityInputManagerWindowsMixedRealityLeftController = "Input.UnityInputManager.WindowsMixedReality.LeftController";
        private const string prefabUnityInputManagerWindowsMixedRealityRightController = "Input.UnityInputManager.WindowsMixedReality.RightController";
        private const string prefabUnityInputManagerXboxController = "Input.UnityInputManager.XboxController";

        [MenuItem(menuItemRoot + actionRoot + prefabUnityInputManager1DAxisAction, false, priority)]
        private static void AddUnityInputManager1DAxisAction()
        {
            string prefab = prefabUnityInputManager1DAxisAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, actionRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + actionRoot + prefabUnityInputManager2DAxisAction, false, priority)]
        private static void AddUnityInputManager2DAxisAction()
        {
            string prefab = prefabUnityInputManager2DAxisAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, actionRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + actionRoot + prefabUnityInputManagerButtonAction, false, priority)]
        private static void AddUnityInputManagerButtonAction()
        {
            string prefab = prefabUnityInputManagerButtonAction + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, actionRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerOculusRemote, false, priority)]
        private static void AddUnityInputManagerOculusRemote()
        {
            string prefab = prefabUnityInputManagerOculusRemote + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerOculusTouchLeftController, false, priority)]
        private static void AddUnityInputManagerOculusTouchLeftController()
        {
            string prefab = prefabUnityInputManagerOculusTouchLeftController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerOculusTouchRightController, false, priority)]
        private static void AddUnityInputManagerOculusTouchRightController()
        {
            string prefab = prefabUnityInputManagerOculusTouchRightController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerOpenVRLeftController, false, priority)]
        private static void AddUnityInputManagerOpenVRLeftController()
        {
            string prefab = prefabUnityInputManagerOpenVRLeftController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerOpenVRRightController, false, priority)]
        private static void AddUnityInputManagerOpenVRRightController()
        {
            string prefab = prefabUnityInputManagerOpenVRRightController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerWindowsMixedRealityLeftController, false, priority)]
        private static void AddUnityInputManagerWindowsMixedRealityLeftController()
        {
            string prefab = prefabUnityInputManagerWindowsMixedRealityLeftController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerWindowsMixedRealityRightController, false, priority)]
        private static void AddUnityInputManagerWindowsMixedRealityRightController()
        {
            string prefab = prefabUnityInputManagerWindowsMixedRealityRightController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }

        [MenuItem(menuItemRoot + mappingRoot + prefabUnityInputManagerXboxController, false, priority)]
        private static void AddUnityInputManagerXboxControllerr()
        {
            string prefab = prefabUnityInputManagerXboxController + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, mappingRoot, prefab);
            CreatePrefab(packageLocation);
        }
    }
}