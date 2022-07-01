using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentReferenceList : MonoBehaviour
{

    public List<GameObject> instruments; 
    public List<Vector3> instrumentStartPos = new List<Vector3>();
    public List<Quaternion> instrumentStartOrientation = new List<Quaternion>();

    private void Awake()
    {
        instruments = new List<GameObject>();
        foreach (Transform child in transform)
        {
            instruments.Add(child.gameObject);

            foreach (Transform instrumentChild in child.transform)
            {
                if (instrumentChild.tag == "Instrument")
                {
                    // instrumentChild.GetChild(0).gameObject.AddComponent<AnimationCallBack>();

                    instrumentStartPos.Add(instrumentChild.gameObject.transform.localPosition);
                    instrumentStartOrientation.Add(instrumentChild.gameObject.transform.localRotation);
                }
            }
        }
    }

}
