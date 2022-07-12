using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExciterReferenceList : MonoBehaviour
{

    public List<GameObject> exciters;
    public List<Vector3> exciterStartPos = new List<Vector3>();
    public List<Quaternion> exciterStartOrientation = new List<Quaternion>();

    private void Awake()
    {
        exciters = new List<GameObject>();
        foreach (Transform child in transform)
        {
            exciters.Add(child.gameObject);

        }

        foreach (GameObject exciters in exciters)
        {
            foreach (Transform child in exciters.transform)
            {
                if (child.tag == "Exciter")
                {
                    exciterStartPos.Add(child.gameObject.transform.localPosition);
                    exciterStartOrientation.Add(child.gameObject.transform.localRotation);
                }
            }
        }
    }
}
    

