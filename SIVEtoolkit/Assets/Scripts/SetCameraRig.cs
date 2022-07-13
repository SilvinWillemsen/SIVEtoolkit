using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.CameraRigs.TrackedAlias;
using Zinnia.Tracking.CameraRig;
using Tilia.Interactions.Interactables.Interactors;
using Tilia.Interactions.Interactables.Interactables;
using Zinnia.Action;
using System.Linq;
using UnityEditor;

[ExecuteInEditMode]
public class SetCameraRig : MonoBehaviour
{
    public enum XRsetup
    {
        UseOculus,
        UseSimulator
    }

    public XRsetup xrSetup;
    private XRsetup curXRSetup;

    public GameObject TrackedAliasObj;
    public LinkedAliasAssociationCollection OculusCameraRig;
    public LinkedAliasAssociationCollection SimulatorCameraRig;
    
    [SerializeField]
    public GameObject LeftInteractorObj;
    [SerializeField]
    public GameObject RightInteractorObj;

    public BooleanAction OculusLeftGrip;
    public BooleanAction OculusRightGrip;
    public BooleanAction SimulatorLeftGrip;
    public BooleanAction SimulatorRightGrip;

    public GameObject instrumentDisplays;
    public GameObject exciters;

    private bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        curXRSetup = xrSetup;
        started = true;
    }

    // Update is called once per frame
    void OnValidate()
    {
        if (!started)
            return;
        if (curXRSetup != xrSetup)
        {
            ChangeXRSettings();
            curXRSetup = xrSetup;
        }
    }

    void ChangeXRSettings()
    {
        bool switchToOculus = xrSetup == XRsetup.UseOculus;
        Debug.Log(xrSetup == XRsetup.UseOculus ? "Changing to Oculus" : "Changing to Simulator");

        // Activate the correct GameObject
        OculusCameraRig.gameObject.SetActive (switchToOculus);
        SimulatorCameraRig.gameObject.SetActive (!switchToOculus);

        // Change interactor grip settings using serializedobjects
        var leftSO = new SerializedObject(LeftInteractorObj.GetComponent<InteractorFacade>());
        var rightSO = new SerializedObject(RightInteractorObj.GetComponent<InteractorFacade>());

        leftSO.FindProperty("grabAction").objectReferenceValue = switchToOculus ? OculusLeftGrip : SimulatorLeftGrip;
        leftSO.ApplyModifiedProperties();

        rightSO.FindProperty("grabAction").objectReferenceValue = switchToOculus ? OculusRightGrip : SimulatorRightGrip;
        rightSO.ApplyModifiedProperties();


        // Change the Tracked alias list (does not seem to work for windows..)
        var rigSO = new SerializedObject(TrackedAliasObj.GetComponent<TrackedAliasFacade>());
        var rigs = TrackedAliasObj.GetComponent<TrackedAliasFacade>().CameraRigs;
        rigs.Clear();
        rigs.Add(switchToOculus ? OculusCameraRig : SimulatorCameraRig);
        rigSO.FindProperty("cameraRigs").objectReferenceValue = rigs;
        rigSO.ApplyModifiedProperties();

        // Change grabaction in instrument interactables
        foreach (Transform child in instrumentDisplays.transform)
        {
            if (child.GetChild(0).tag == "Instrument")
            {                
                var interactableSO = new SerializedObject(child.GetChild(0).GetComponent<InteractableFacade>());
                interactableSO.FindProperty("grabType").enumValueIndex = switchToOculus ? 0 : 1; // 0: Hold Till Release, 1: Toggle
                interactableSO.ApplyModifiedProperties();

            }
        }

        foreach (Transform child in exciters.transform)
        {
            if (child.GetChild(0).tag == "Exciter")
            {
                var interactableSO = new SerializedObject(child.GetChild(0).GetComponent<InteractableFacade>());
                interactableSO.FindProperty("grabType").enumValueIndex = switchToOculus ? 0 : 1; // 0: Hold Till Release, 1: Toggle
                interactableSO.ApplyModifiedProperties();

            }
        }


    }
}
