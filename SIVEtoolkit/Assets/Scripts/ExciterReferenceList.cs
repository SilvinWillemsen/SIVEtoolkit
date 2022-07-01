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
        // exciterStartPos.Add(child.gameObject.transform.localPosition);
        // exciterStartOrientation.Add(child.gameObject.transform.localRotation);

        foreach (GameObject exciters in exciters)
        {
            foreach (Transform child in exciters.transform)
            {
                if (child.tag == "Exciter")
                {
                    // Debug.Log("Looking at " + child.GetChild(0).name);
                    // child.gameObject.GetComponent<Rigidbody>().useGravity = true;
                    // child.GetChild(0).gameObject.AddComponent<AnimationCallBack>();

                    exciterStartPos.Add(child.gameObject.transform.localPosition);
                    exciterStartOrientation.Add(child.gameObject.transform.localRotation);
                }
            }
        }
    }
}
    

