namespace Tilia.Input.UnityInputManager
{
    using System;
    using System.Reflection;
    using UnityEditor;
    using UnityEngine;

    [InitializeOnLoad]
    public sealed class UnityInputManagerAxisCreator : EditorWindow
    {
        public enum AxisType
        {
            KeyOrMouseButton = 0,
            MouseMovement = 1,
            JoystickAxis = 2
        };

        public class InputAxis
        {
            public string name;
            public string descriptiveName;
            public string descriptiveNegativeName;
            public string negativeButton;
            public string positiveButton;
            public string altNegativeButton;
            public string altPositiveButton;

            public float gravity;
            public float dead;
            public float sensitivity;

            public bool snap;
            public bool invert;

            public AxisType type;

            public int axis;
            public int joyNum;
        }

        private const string windowTitle = "Manage Unity Input Manager Axis Definitions";
        private const string hidePromptKey = "Tilia.Input.UnityInputManager.HideInputMappingPrompt";
        private static UnityInputManagerAxisCreator promptWindow;
        private static bool isManualCheck;
        private static Vector2 scrollPosition;

        private static readonly InputAxis axis1 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis1", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 1, joyNum = 0 };
        private static readonly InputAxis axis2 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis2", dead = 0.001f, sensitivity = 1f, snap = true, invert = true, type = AxisType.JoystickAxis, axis = 2, joyNum = 0 };
        private static readonly InputAxis axis3 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis3", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 3, joyNum = 0 };
        private static readonly InputAxis axis4 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis4", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 4, joyNum = 0 };
        private static readonly InputAxis axis5 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis5", dead = 0.001f, sensitivity = 1f, snap = true, invert = true, type = AxisType.JoystickAxis, axis = 5, joyNum = 0 };
        private static readonly InputAxis axis6 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis6", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 6, joyNum = 0 };
        private static readonly InputAxis axis7 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis7", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 7, joyNum = 0 };
        private static readonly InputAxis axis8 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis8", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 8, joyNum = 0 };
        private static readonly InputAxis axis9 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis9", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 9, joyNum = 0 };
        private static readonly InputAxis axis10 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis10", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 10, joyNum = 0 };
        private static readonly InputAxis axis11 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis11", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 11, joyNum = 0 };
        private static readonly InputAxis axis12 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis12", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 12, joyNum = 0 };
        private static readonly InputAxis axis13 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis13", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 13, joyNum = 0 };
        private static readonly InputAxis axis14 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis14", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 14, joyNum = 0 };
        private static readonly InputAxis axis15 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis15", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 15, joyNum = 0 };
        private static readonly InputAxis axis16 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis16", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 16, joyNum = 0 };
        private static readonly InputAxis axis17 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis17", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 17, joyNum = 0 };
        private static readonly InputAxis axis18 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis18", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 18, joyNum = 0 };
        private static readonly InputAxis axis19 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis19", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 19, joyNum = 0 };
        private static readonly InputAxis axis20 = new InputAxis() { name = "Tilia.Input.UnityInputManager_Axis20", dead = 0.001f, sensitivity = 1f, snap = true, type = AxisType.JoystickAxis, axis = 20, joyNum = 0 };

        static UnityInputManagerAxisCreator()
        {
            EditorApplication.delayCall += ManageInputMappings;
        }

        public void OnGUI()
        {
            using (GUILayout.ScrollViewScope scrollViewScope = new GUILayout.ScrollViewScope(scrollPosition))
            {
                scrollPosition = scrollViewScope.scrollPosition;

                bool mappingsExist = AxisDefined(axis3.name);
                const string mappingsNotFound = "The required Input Axis Definitions have not been found.\n\nClick the 'Add Input Axis Definitions' button below to automatically created the required Input Axis Definitions.";
                const string mappingsFound = "The required Input Axis Definitions have already been created.\n\nClick the 'Delete Input Definitions' button below to delete these Input Axis Definitions.";
                const string hideToggleLabel = "Do not prompt again.";
                const string addMappingsButtonLabel = "Add Input Definitions";
                const string deleteMappingsButtonLabel = "Delete Input Definitions";
                string mappingText = mappingsExist ? mappingsFound : mappingsNotFound;
                MessageType messageType = mappingsExist ? MessageType.Info : MessageType.Warning;

                EditorGUILayout.HelpBox("The Unity Input Manager Prefabs contained in this package requires additional Unity Input Axes to be defined.\n\n" + mappingText, messageType);

                using (EditorGUI.ChangeCheckScope changeCheckScope = new EditorGUI.ChangeCheckScope())
                {
                    bool hideToggle = EditorPrefs.HasKey(GetProjectKeyName());

                    hideToggle = GUILayout.Toggle(hideToggle, hideToggleLabel);
                    GUILayout.FlexibleSpace();

                    using (new EditorGUILayout.HorizontalScope())
                    {
                        if (!mappingsExist)
                        {
                            if (GUILayout.Button(addMappingsButtonLabel))
                            {
                                AddInputMappings();
                                Close();
                            }
                        }
                        else
                        {
                            if (GUILayout.Button(deleteMappingsButtonLabel))
                            {
                                DeleteInputMappings();
                            }
                        }

                    }

                    if (changeCheckScope.changed)
                    {
                        if (hideToggle)
                        {
                            EditorPrefs.SetBool(GetProjectKeyName(), true);
                        }
                        else
                        {
                            EditorPrefs.DeleteKey(GetProjectKeyName());
                        }
                    }
                }
            }
        }

        private static void ManageInputMappings()
        {
            if (isManualCheck)
            {
                ShowWindow();
            }
            else if (EditorPrefs.HasKey(GetProjectKeyName()) || AxisDefined(axis3.name))
            {
                EditorApplication.delayCall -= ManageInputMappings;
                return;
            }

            EditorApplication.delayCall -= ManageInputMappings;

            ShowWindow();
            isManualCheck = false;
        }

        private static void AddInputMappings()
        {
            for (int axisIndex = 1; axisIndex <= 20; axisIndex++)
            {
                AddAxis((InputAxis)Type.GetType("Tilia.Input.UnityInputManager.UnityInputManagerAxisCreator").GetField("axis" + axisIndex, BindingFlags.NonPublic | BindingFlags.Static).GetValue(null));
            }
        }

        private static void DeleteInputMappings()
        {
            RemoveAllAxes();
        }

        private static SerializedProperty GetChildProperty(SerializedProperty parent, string name)
        {
            SerializedProperty child = parent.Copy();
            child.Next(true);
            do
            {
                if (child.name == name) return child;
            }
            while (child.Next(false));
            return null;
        }

        private static bool AxisDefined(string axisName)
        {
            SerializedObject serializedObject = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0]);
            SerializedProperty axesProperty = serializedObject.FindProperty("m_Axes");

            axesProperty.Next(true);
            axesProperty.Next(true);
            while (axesProperty.Next(false))
            {
                SerializedProperty axis = axesProperty.Copy();
                if (axis.Next(true))
                {
                    if (axis.stringValue == axisName) return true;
                }
            }
            return false;
        }

        private static void AddAxis(InputAxis axis)
        {
            if (AxisDefined(axis.name))
            {
                return;
            }

            SerializedObject serializedObject = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0]);
            SerializedProperty axesArrayProperty = serializedObject.FindProperty("m_Axes");

            axesArrayProperty.arraySize++;
            serializedObject.ApplyModifiedProperties();

            SerializedProperty axisProperty = axesArrayProperty.GetArrayElementAtIndex(axesArrayProperty.arraySize - 1);

            GetChildProperty(axisProperty, "m_Name").stringValue = axis.name;
            GetChildProperty(axisProperty, "descriptiveName").stringValue = axis.descriptiveName;
            GetChildProperty(axisProperty, "descriptiveNegativeName").stringValue = axis.descriptiveNegativeName;
            GetChildProperty(axisProperty, "negativeButton").stringValue = axis.negativeButton;
            GetChildProperty(axisProperty, "positiveButton").stringValue = axis.positiveButton;
            GetChildProperty(axisProperty, "altNegativeButton").stringValue = axis.altNegativeButton;
            GetChildProperty(axisProperty, "altPositiveButton").stringValue = axis.altPositiveButton;
            GetChildProperty(axisProperty, "gravity").floatValue = axis.gravity;
            GetChildProperty(axisProperty, "dead").floatValue = axis.dead;
            GetChildProperty(axisProperty, "sensitivity").floatValue = axis.sensitivity;
            GetChildProperty(axisProperty, "snap").boolValue = axis.snap;
            GetChildProperty(axisProperty, "invert").boolValue = axis.invert;
            GetChildProperty(axisProperty, "type").intValue = (int)axis.type;
            GetChildProperty(axisProperty, "axis").intValue = axis.axis - 1;
            GetChildProperty(axisProperty, "joyNum").intValue = axis.joyNum;

            serializedObject.ApplyModifiedProperties();
        }

        private static void RemoveAllAxes()
        {
            SerializedObject serializedObject = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0]);
            SerializedProperty axesArrayProperty = serializedObject.FindProperty("m_Axes");

            for (int i = axesArrayProperty.arraySize - 1; i >= 0; i--)
            {
                SerializedProperty axisProperty = axesArrayProperty.GetArrayElementAtIndex(i);
                string axisName = GetChildProperty(axisProperty, "m_Name").stringValue;
                if (axisName.Contains("Tilia.Input.UnityInputManager"))
                {
                    axesArrayProperty.DeleteArrayElementAtIndex(i);
                }
            }
            serializedObject.ApplyModifiedProperties();
        }

        private static string GetProjectKeyName()
        {
            return hidePromptKey + AssetDatabase.AssetPathToGUID("Assets");
        }

        private static void ShowWindow()
        {
            if (promptWindow != null)
            {
                promptWindow.ShowUtility();
                promptWindow.Repaint();
                return;
            }

            promptWindow = GetWindow<UnityInputManagerAxisCreator>(true);
            promptWindow.titleContent = new GUIContent(windowTitle);
        }

        [MenuItem("Window/Tilia/Input/" + windowTitle)]
        private static void CheckManually()
        {
            isManualCheck = true;
            EditorApplication.delayCall += ManageInputMappings;
        }
    }
}