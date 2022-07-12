using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using UnityEngine;
using System;
using UnityEngine.Audio;


public class SelectPreset : MonoBehaviour
{

    private float selectedPreset = 0.0f;

    public AudioMixer audioMixer;
    [HideInInspector] public List<String> pluginList; 
     
    [Dropdown("pluginList")]//input the path of the list
    public String InstrumentType;
    // [SerializeField] Global.InstrumentType instrumentType;

    // Start is called before the first frame update
    void Start()
    {
        int nPresets = getNumPresets();

        // changing instrument preset
        if (gameObject.GetComponentInChildren<PlayAreaInteraction>() == null)
        {
            Debug.LogWarning("There is no playarea in this instrument! (and if there is it doesn't have a playareainteraction script..)");
        }
        else
        {
            for (int i = 0; i < transform.childCount; ++i)
                if (transform.GetChild(i).tag == "PlayArea")
                    transform.GetChild(i).GetComponent<PlayAreaInteraction>().SetInstrumentType (InstrumentType);

            selectedPreset = (pluginList.IndexOf(InstrumentType) + 0.5f) / getNumPresets();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstrumentGrabbed()
    {
        // StartCoroutine(ChangePreset());
        audioMixer.SetFloat("presetSelect", selectedPreset);

    }

    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern int getNumPresets();


}
