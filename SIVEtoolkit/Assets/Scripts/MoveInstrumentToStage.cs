using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia;
using Zinnia.Action;

public class MoveInstrumentToStage : MonoBehaviour
{
    //public GameObject[] interactors;

    public Tilia.Interactions.Interactables.Interactables.Operation.Extraction.InteractableFacadeExtractor[] interactorExtractors;

    public GameObject instrumentDisplays;
    Vector3 stagePos;
    GameObject currentInstrument;
    public GameObject distanceGrabber;

    private void Start()
    {
        stagePos = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
    }
    public void MoveInstrument(GameObject instrument)
    {
        // if there is no instrument on stage, place new instrument
        if (currentInstrument == null)
        {
            currentInstrument = instrument;
            
            PlaceInstrument(currentInstrument);
        }

        // if there is already an instrument, remove old instrument
        else if (currentInstrument != null)
        {

            if (currentInstrument != instrument)
            {
                RemoveInstrument(currentInstrument, true);
                currentInstrument = instrument;
                PlaceInstrument(currentInstrument);
            }
            else
            {
                RemoveInstrument(currentInstrument.gameObject, false);
                currentInstrument = null;
            }
        }
    }


    void PlaceInstrument(GameObject instrument)
    {
        foreach (Transform child in instrument.transform)
        {
            if (child.tag == "Instrument")
            {
                child.transform.GetChild(0).transform.GetChild(1).GetComponent<CustomGrabAttachment>().moveToStageWhenGrabbed = true;
            }
        }
        //Vector3 moveSpot = new Vector3(stagePos.x, stagePos.y + instrument.transform.position.y, stagePos.z);
        StartCoroutine(DelayBeforeUngrab(instrument));
    }


    void RemoveInstrument(GameObject instrument, bool removeWithoutGrabbing)
    {
        foreach (Transform child in instrument.transform)
        {
            if (child.tag == "Instrument")
            {
                child.transform.GetChild(0).transform.GetChild(1).GetComponent<CustomGrabAttachment>().moveToStageWhenGrabbed = false;
            }
        }
        //Vector3 moveSpot = new Vector3(stagePos.x, stagePos.y + instrument.transform.position.y, stagePos.z);

        if (removeWithoutGrabbing)
        {
            instrumentDisplays.GetComponent<ResetInstrumentPos>().DespawnAndSpawnInstrument(instrument);
        }
        else
        {
            StartCoroutine(DelayBeforeUngrab(instrument));
        }
    }

    

    IEnumerator DelayBeforeUngrab(GameObject instrument)
    {
        yield return new WaitForSeconds(0.1f);

        // Get the instrument to despawn & not an exciter
        for(int i = 0; i < interactorExtractors.Length; i ++)
        {
             if (interactorExtractors[i].Source != null)
            {
                GameObject grabbedObject = interactorExtractors[i].Source.gameObject;
                if (grabbedObject.tag == "Instrument")
                {
                    grabbedObject.GetComponent<Tilia.Interactions.Interactables.Interactables.InteractableFacade>().Ungrab();
                }
            }
        } 
    }

    // All of the following just used for testing.. Not working!
    public void BeforeGrabbedTest(GameObject harp)
    {
        Debug.Log("Before Grabbed");
        Debug.Log(harp.GetComponent<Rigidbody>());
        Debug.Log("Current interactable: " + distanceGrabber.GetComponent<Tilia.Interactions.PointerInteractors.DistanceGrabberFacade>());


        //distanceGrabber.GetComponent<Tilia.Interactions.PointerInteractors.DistanceGrabberFacade>().GrabCanceled.Invoke(harp.GetComponent<Tilia.Interactions.Interactables.Interactables.InteractableFacade>());
        Debug.Log("Invoke cancelgrab");

        //interactor.GetComponent<Tilia.Interactions.Interactables.Interactors.InteractorFacade>().GrabAction.GetComponent<BooleanAction>().Deactivated.Invoke(false);
        //interactor.GetComponent<Tilia.Interactions.Interactables.Interactors.InteractorFacade>().Ungrab();

    }
    public void AfterGrabbedTest()
    {
        //Debug.Log("Current interactable: " + distanceGrabber.GetComponent<Tilia.Interactions.PointerInteractors.DistanceGrabberFacade>().CurrentInteractable);
        Debug.Log("CancelInvoke");
    }
}