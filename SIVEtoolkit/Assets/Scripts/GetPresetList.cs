using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class GetPresetList : MonoBehaviour
{

    // Use this for initialization
    void OnEnable()
    {
        Debug.Log(getNumPresets());
        for (int i = 0; i < getNumPresets(); ++i)
        {
            string test = Marshal.PtrToStringAuto (getPresetAt(i));
            Debug.Log (test);
        }
        // for (int i = 0; i < getNumPresets(); ++i)
        // {
        //     Debug.Log (test);
        // }
    }

    // // //------------------------------------------------------------------------------------------------
    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr getPresetAt (int i);
    
    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern int getNumPresets();
}