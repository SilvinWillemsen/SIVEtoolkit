using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetExciterPos : MonoBehaviour
{
    // Start is called before the first frame update

    ExciterReferenceList exciterReferenceList;

    [SerializeField] public float timeBeforeDespawn = 1.0f;
    [SerializeField] public float despawnTime = 1.0f;
    [SerializeField] public float spawnTime = 1.0f;
    [SerializeField] public float transitionTime = 0.5f;

    void Start()
    {
        exciterReferenceList = GetComponent<ExciterReferenceList>();
    }
    public void DespawnAndSpawnExciter(GameObject exciter)
    {
        // List<GameObject> thisExciter = new List<GameObject>();
        // thisExciter.Add(exciter);
        StartCoroutine(StartResetCoroutine(exciter, despawnTime, spawnTime, transitionTime));
    }

    public IEnumerator StartResetCoroutine(GameObject thisExciter, float despawnTime, float spawnTime, float transitionTime)
    {
        yield return new WaitForSeconds(timeBeforeDespawn);
        Global.DespawnSingleInteractable(thisExciter.transform.GetChild(0), despawnTime, false);
        yield return new WaitForSeconds(transitionTime + despawnTime); // wait for despawnTime + transition time before spawning agia
        thisExciter.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.transform.localScale = new Vector3(1e-5f, 1e-5f, 1e-5f);

        // Find index of instrument to spawn
        int idx = -1;
        int i = 0;
        foreach (GameObject exciter in exciterReferenceList.exciters)
        {
            if (thisExciter == exciter)
                idx = i;
            ++i;
        }

        if (idx == -1)
        {
            Debug.LogError("exciterNotFound!");
        } 
        else 
        {
            Debug.Log("Index of model to spawn is " + idx);
            Global.SpawnSingleInteractable(thisExciter.transform.GetChild(0), spawnTime, exciterReferenceList.exciterStartPos[idx], exciterReferenceList.exciterStartOrientation[idx], false);
        }
    }
}
