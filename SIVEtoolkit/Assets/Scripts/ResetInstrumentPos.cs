    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetInstrumentPos : MonoBehaviour
{
    InstrumentReferenceList instrumentReferenceList;
    [SerializeField] GameObject instrumentStage;

    Vector3 instrumentStageLoc; 
    [SerializeField] public float timeBeforeDespawn = 1.0f;
    [SerializeField] public float despawnTime = 1.0f;
    [SerializeField] public float spawnTime = 1.0f;
    [SerializeField] public float transitionTime = 0.5f;

    [SerializeField] public float timeBeforeDespawnStageInstrument = 0.0f;
    [SerializeField] public float transitionTimeStage= 0.2f;

    private void Start()
    {
        instrumentReferenceList = GetComponent<InstrumentReferenceList>();
        instrumentStageLoc = instrumentStage.transform.position;
        instrumentStageLoc.y += 0.5f;
    }
    public void DespawnAndSpawnInstrument(GameObject instrument)
    {
        // List<GameObject> thisInstrument = new List<GameObject>();
        // thisInstrument.Add(instrument);

        bool moveToStage = false;
        
        StartCoroutine(StartResetCoroutine(instrument, timeBeforeDespawn, transitionTime, moveToStage)); 
    }

    public void DespawnAndSpawnInstrumentStage(GameObject instrument)
    {
        // List<GameObject> thisInstrument = new List<GameObject>();
        // thisInstrument.Add(instrument);

        bool moveToStage = false;
        // check if need to be moved to stage
        int idx = 0;
        foreach (Transform child in instrument.transform)
        {
            if (child.tag == "Instrument")
            {
                if (child.transform.GetChild(idx).transform.GetChild(1).GetComponent<CustomGrabAttachment>() != null)
                {
                    moveToStage = child.transform.GetChild(0).transform.GetChild(1).GetComponent<CustomGrabAttachment>().moveToStageWhenGrabbed;
                }
            }
            ++idx;

        }

        StartCoroutine(StartResetCoroutine(instrument, timeBeforeDespawnStageInstrument, transitionTimeStage, moveToStage));
    }

    public IEnumerator StartResetCoroutine(GameObject thisInstrument, float timeBeforeDespawn, float transitionTime, bool moveToStage)
    {
        yield return new WaitForSeconds(timeBeforeDespawn);
        Global.DespawnSingleInteractable(thisInstrument.transform.GetChild(0), despawnTime, false);
        yield return new WaitForSeconds(transitionTime + despawnTime); // wait for despawnTime + transition time before spawning agia
        thisInstrument.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(1e-5f, 1e-5f, 1e-5f);

        // Find index of instrument to spawn
        int idx = -1;
        int i = 0;
        foreach (GameObject instrument in instrumentReferenceList.instruments)
        {
            if (thisInstrument == instrument)
                idx = i;
            ++i;
        }

        if (idx == -1)
        {
            Debug.LogError("instrumentNotFound!");
        } 
        else 
        {
            Debug.Log("Index of model to spawn is " + idx);
            if(moveToStage)
            {
                Vector3 instrumentLocToUse = new Vector3 (instrumentStageLoc.x + (thisInstrument.name == "Harp" ? 0.25f : 0), instrumentStageLoc.y + (thisInstrument.name == "Harp" ? 0.75f : 0.25f), instrumentStageLoc.z);
                Global.SpawnSingleInteractable(thisInstrument.transform.GetChild(0), spawnTime, instrumentLocToUse, instrumentStage.transform.rotation, true);
                //thisInstrument.GetComponent<Rigidbody>().isKinematic = true;
                Debug.Log(instrumentStage.transform.localRotation);
            }
            else
            {
                Global.SpawnSingleInteractable(thisInstrument.transform.GetChild(0), spawnTime, instrumentReferenceList.instrumentStartPos[idx], instrumentReferenceList.instrumentStartOrientation[idx], false);

            }
        }
    }
}
