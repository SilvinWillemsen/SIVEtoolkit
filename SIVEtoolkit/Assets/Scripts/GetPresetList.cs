using AOT;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class GetPresetList : MonoBehaviour
{

    // Use this for initialization
    void OnEnable()
    {
        for (int i = 0; i < getNumPresets(); ++i)
        {
            string test = Marshal.PtrToStringAuto (getPresetAt(i));
        }
    }

    // // //------------------------------------------------------------------------------------------------
    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr getPresetAt (int i);
    
    [DllImport("audioPlugin_ModularVST", CallingConvention = CallingConvention.Cdecl)]
    static extern int getNumPresets();
}