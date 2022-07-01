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

    // Start is called before the first frame update
    void Start()
    {
        curXRSetup = xrSetup;
    }

    // Update is called once per frame
    void OnValidate()
    {
        Debug.Log("OnValidate");
        if (curXRSetup != xrSetup)
        {
            //StartCoroutine (ChangeXRSettings());
            ChangeXRSettings();
            curXRSetup = xrSetup;
        }
    }

    void ChangeXRSettings()
    {
        bool switchToOculus = xrSetup == XRsetup.UseOculus;
        Debug.Log(xrSetup == XRsetup.UseOculus ? "Changing to Oculus" : "Changing to Simulator");

        Debug.Log("Activating correct GameObject");
        // Activate the correct GameObject
        OculusCameraRig.gameObject.SetActive (switchToOculus);
        SimulatorCameraRig.gameObject.SetActive (!switchToOculus);

        Debug.Log("Change interactor grip settings");

        // Change interactor grip settings using serializedobjects
        var leftSO = new SerializedObject(LeftInteractorObj.GetComponent<InteractorFacade>());
        var rightSO = new SerializedObject(RightInteractorObj.GetComponent<InteractorFacade>());

        leftSO.FindProperty("grabAction").objectReferenceValue = switchToOculus ? OculusLeftGrip : SimulatorLeftGrip;
        leftSO.ApplyModifiedProperties();

        rightSO.FindProperty("grabAction").objectReferenceValue = switchToOculus ? OculusRightGrip : SimulatorRightGrip;
        rightSO.ApplyModifiedProperties();

        // LeftInteractorObj.GetComponent<InteractorFacade>().GrabAction = switchToOculus ? OculusLeftGrip : SimulatorLeftGrip;
        // RightInteractorObj.GetComponent<InteractorFacade>().GrabAction = switchToOculus ? OculusRightGrip : SimulatorRightGrip;


        // Change the Tracked alias list (apparently no need for serializedobjects)
        Debug.Log("Change the Tracked alias list");

        TrackedAliasObj.GetComponent<TrackedAliasFacade>().CameraRigs.Clear();
        TrackedAliasObj.GetComponent<TrackedAliasFacade>().CameraRigs.Add(switchToOculus ? OculusCameraRig : SimulatorCameraRig);

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
                Debug.Log("Changing to " + switchToOculus + " for " + child.GetChild(0).name);
                var interactableSO = new SerializedObject(child.GetChild(0).GetComponent<InteractableFacade>());
                interactableSO.FindProperty("grabType").enumValueIndex = switchToOculus ? 0 : 1; // 0: Hold Till Release, 1: Toggle
                interactableSO.ApplyModifiedProperties();

            }
        }


    }
}
