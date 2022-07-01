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
            Debug.Log(this.name);
        }
        else
        {
            Debug.Log("The instrumentType is " + InstrumentType);
            for (int i = 0; i < transform.childCount; ++i)
                if (transform.GetChild(i).tag == "PlayArea")
                    transform.GetChild(i).GetComponent<PlayAreaInteraction>().SetInstrumentType (InstrumentType);

            selectedPreset = (pluginList.IndexOf(InstrumentType) + 0.5f) / getNumPresets();
            Debug.Log("The selected preset f-value of " + InstrumentType + " is " + selectedPreset);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstrumentGrabbed()
    {
        // StartCoroutine(ChangePreset());
        Debug.Log("Selected preset is " + selectedPreset);
        Debug.Log(InstrumentType + " grabbed!"); 
        audioMixer.SetFloat("presetSelect", selectedPreset);

    }


    // IEnumerator ChangePreset()
    // {
    //     Debug.Log("Selected preset is " + selectedPreset);
    //     Debug.Log(InstrumentType + " grabbed!"); 
    //     audioMixer.SetFloat("presetSelect", selectedPreset);
    //     // yield return new WaitForSeconds(0.1f);
    //     // audioMixer.SetFloat("loadPreset", 1.0f);
    //     // yield return new WaitForSeconds(0.1f);
    //     // audioMixer.SetFloat("loadPreset", 0.0f);
    // }

    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern int getNumPresets();


}
