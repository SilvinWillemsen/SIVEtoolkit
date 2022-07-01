using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    //public static Global instance;

    /*private static void Init()
    {
        //If the instance not exit the first time we call the static class
        if (instance == null)
        {
            //Create an empty object called MyStatic
            GameObject gameObject = new GameObject("MyStatic");


            //Add this script to the object
            instance = gameObject.AddComponent<Global>();
        }
    }*/

    // interactables here can be instuments or exciters
    public static void DespawnInteractables(List<GameObject> interactables, float despawnTime, bool disableGravity)
    {
        foreach (GameObject interactable in interactables)
        {
            foreach (Transform child in interactable.transform)
            {
                if (child.tag == "Instrument" || child.tag == "Exciter")
                {
                    DespawnSingleInteractable(child, despawnTime, disableGravity);
                }
            }
        }
    }
    public static void DespawnSingleInteractable(Transform child, float despawnTime, bool disableGravity)
    {
        if (disableGravity) child.gameObject.GetComponent<Rigidbody>().useGravity = false;
        GameObject target = child.GetChild(0).gameObject;
        // iTween.ScaleTo(target, Vector3.zero, 0.5f);
        iTween.ScaleTo(target, iTween.Hash("x", 1e-5f, "y", 1e-5f, "z", 1e-5f, "time", despawnTime, "onComplete", "OnDespawn"));
    }

    public static void SpawnInteractables(List<GameObject> interactables, float spawnTime, List<Vector3> interactableStartPos, List<Quaternion> interactableStartOrientation, bool moveToStage)
    {
        //Init();
        int i = 0;
        foreach (GameObject interactable in interactables)
        {
            foreach (Transform child in interactable.transform)
            {
                if (child.tag == "Instrument" || child.tag == "Exciter")
                {
                    SpawnSingleInteractable (child, spawnTime, interactableStartPos[i], interactableStartOrientation[i], moveToStage);
                    i++;
                }
            }
        }
    }

    public static void SpawnSingleInteractable(Transform child, float spawnTime, Vector3 interactableStartPos, Quaternion interactableStartOrientation, bool moveToStage)
    {
        child.gameObject.GetComponent<Rigidbody>().useGravity = false;
        child.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        child.gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        if (moveToStage)
        {
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            child.gameObject.transform.position = interactableStartPos;
            child.gameObject.transform.rotation = interactableStartOrientation;

        }
        else 
        {
            child.gameObject.transform.localPosition = interactableStartPos;
            child.gameObject.transform.localRotation = interactableStartOrientation;
        }
        GameObject target = child.GetChild(0).gameObject;
        iTween.ScaleTo(target, iTween.Hash("x", 1.0f, "y", 1.0f, "z", 1.0f, "time", spawnTime, "onComplete", "OnSpawn"));
        child.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    public static void SpaceEqually(List<GameObject> instruments, float radius, int maxNInstruments)
    {
        if (instruments.Count > maxNInstruments) Debug.Log("Inserted instruments exceeding max number of instruments specified!");
        //float angleOffset = - Mathf.PI / (instruments.Count + 1);
        //float angleOffset = 2.0f * Mathf.PI / maxNInstruments * instruments.Count / 2.0f;
        float angleOffset = 0;
        for (int i = 0; i < maxNInstruments; i++)
        {
            float angle = i * Mathf.PI * 2f / maxNInstruments - angleOffset;
            if (i < instruments.Count)
            {
                Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 0.0f, Mathf.Sin(angle) * radius);
                instruments[i].transform.localPosition = newPos;
                Debug.Log(instruments[i].name + " gets position " + newPos);
            }
        }
    }

    public static void FaceInstrumentsToOrigin(List<GameObject> instruments)
    {
        for (int i = 0; i < instruments.Count; i++)
        {
            instruments[i].transform.LookAt(Vector3.zero, Vector3.up);
        }
    }

    public static float Map(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public static float Limit(float val, float min, float max)
    {
        if (val < min) return min;
        else if (val > max) return max;
        else return val;
    }



}
