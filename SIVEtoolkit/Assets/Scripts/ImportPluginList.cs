using System;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.InteropServices;

[ExecuteInEditMode] // IMPORTANT! Also runs in edit mode now
public class ImportPluginList : MonoBehaviour
{
    public GameObject instrumentDisplays;
    // Start is called before the first frame update

    public List<String> pluginNames;
    void Start()
    {
        // PrintPluginNamesFromPlugin();

        // check if presetlist from the plugin has changed
        if (pluginNames.Count != getNumPresets())
        {
            // length of the plugin list has changed, so refresh
            refreshPluginList();
        }
        else
        {
            for (int i = 0; i < pluginNames.Count; ++i) // could also use < getNumPresets() but should be the same
            {
                string pluginNamePre = Marshal.PtrToStringAnsi(getPresetAt(i));
                String pluginName = pluginNamePre;
                pluginName = pluginName.Split('_')[0];

                if (pluginNames[i] != pluginName) // a plugin has changed, so refresh the plugin list! 
                {
                    refreshPluginList();
                    break;
                }
            }
        }

        // Added this here in Start() such that new instruments also get the correct list
        foreach (Transform child in instrumentDisplays.transform)
        {
            if (child.GetChild(0).tag == "Instrument")
            {
                Debug.Log("TEST");
                GameObject model = child.GetChild(0).GetChild(0).GetChild(1).gameObject;
                AddPluginsToModelList(model); 
            }
        }

    }

    void refreshPluginList()
    {
        Debug.Log("Refreshing plugin list!!");
        Debug.LogError ("MAKE SURE YOU RESELECT THE RIGHT IN THE SELECTPRESET COMPONENT OF EACH MODEL!");

        pluginNames.Clear();
        for (int i = 0; i < getNumPresets(); ++i)
        {
            string pluginNamePre = Marshal.PtrToStringAnsi(getPresetAt(i));
            String pluginName = pluginNamePre;
            pluginName = pluginName.Split('_')[0];
 
            Debug.Log(pluginName + "Added to list!");
            pluginNames.Add(pluginName);
        }

        foreach (Transform child in instrumentDisplays.transform)
        {
            if (child.GetChild(0).tag == "Instrument")
            {
                GameObject model = child.GetChild(0).GetChild(0).GetChild(1).gameObject;
                if (model.tag != "Model")
                {
                    Debug.LogWarning("Should be looking at model here!");
                    continue;
                }
                Debug.Log("Clearing " + model.name + "'s list");
                model.GetComponent<SelectPreset>().pluginList.Clear();

                AddPluginsToModelList (model);
            }
        }

    }

    void AddPluginsToModelList(GameObject model)
    {
        Debug.Log("Adding to " + model.name + "'s list");
        for (int i = 0; i < getNumPresets(); ++i)
            if (!model.GetComponent<SelectPreset>().pluginList.Contains(pluginNames[i]))
                model.GetComponent<SelectPreset>().pluginList.Add(pluginNames[i]);
        Debug.Log("Adding to NameList");

    }


    void PrintPluginNamesFromPlugin()
    {
        for (int i = 0; i < getNumPresets(); ++i)
        {
            string pluginNamePre = Marshal.PtrToStringAnsi(getPresetAt(i));
            Debug.Log (pluginNamePre);
        }
    }

    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr getPresetAt(int i);

    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern int getNumPresets();
}
