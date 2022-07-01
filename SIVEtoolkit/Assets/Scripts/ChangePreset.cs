using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class ChangePreset : MonoBehaviour
{   
    private int presetToLoad;
    // DebugTextScript debugTextScript;
    int numPresets;
    public int currentlyActivePreset;
    public AudioMixer audioMixer;
    void Start()
    {
        numPresets = getNumPresets();
        Debug.Log("Number of presets in app = " + numPresets);
        float currentPresetFloat;
        audioMixer.GetFloat ("presetSelect", out currentPresetFloat);
        Debug.Log("CurrentPresetFloat = " + currentPresetFloat);

        currentlyActivePreset = (int)Mathf.Floor (currentPresetFloat * numPresets);
        Debug.Log("currentlyActivePreset = " + currentlyActivePreset);
        presetToLoad = currentlyActivePreset;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(loadPreset());
        }
    }
    IEnumerator loadPreset()
    {
        audioMixer.SetFloat ("loadPreset", 0.0f);

        presetToLoad = (presetToLoad + 1) % numPresets;
        Debug.Log("Right Mouse Button Clicked");
        Debug.Log("presetToLoad = " + presetToLoad);
        audioMixer.SetFloat ("presetSelect", (presetToLoad + 0.5f) * 1.0f / numPresets);
        if (currentlyActivePreset != presetToLoad)
        {
            currentlyActivePreset = presetToLoad;
            yield return new WaitForSeconds (0.1f);

            audioMixer.SetFloat ("loadPreset", 1.0f);
            string presetName = Marshal.PtrToStringAuto (getPresetAt(currentlyActivePreset));
        }
    }
        
    [DllImport("audioPlugin_ModularVST")]
    static extern int getNumPresets();

    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr getPresetAt (int i);
}
