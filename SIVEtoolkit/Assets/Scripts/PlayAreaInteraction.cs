using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

/*
 Make sure that you scale the playarea transform, NOT the collider! That should have a scale of 1,1,1.
 */


public class PlayAreaInteraction : MonoBehaviour
{
    public enum StringOrientation
    {
        Horizontal,
        Vertical,
    };

    [SerializeField] AudioMixer audioMixer;
    [HideInInspector] public String instrumentType;

    private GameObject excitationLoc;
    [SerializeField] private StringOrientation stringOrientation;

    private float velocity;

    private bool outOfBounds1 = false;
    private bool outOfBounds2 = false;

    // Start is called before the first frame update
    void Start()
    {        
        // create an object indicating where it is excited 
        excitationLoc = Instantiate(new GameObject(), transform);
        excitationLoc.name = "excitationLoc";
    }

    public void SetInstrumentType(String instrumentTypeToSet)
    {
        Debug.Log("instrumentTypeToSet is " + instrumentTypeToSet);
        instrumentType = instrumentTypeToSet;
    }

    private void OnTriggerEnter (Collider other)
    {
        // Code to determine whether play area is triggered
        if (other.gameObject.tag == "ExciterArea")
        {
            string exciterName = other.transform.parent.name;
            if (exciterName == "Bow")
                audioMixer.SetFloat("excite", 1.0f);

            // calculate where on the instrument it's exciting:
            excitationLoc.transform.position = other.transform.position;

            Vector3 localPos = new Vector3(excitationLoc.transform.localPosition.x, excitationLoc.transform.localPosition.y, excitationLoc.transform.localPosition.z);


            // map & limit values (swap y)
            float xPos = Global.Limit(Global.Map(localPos.x, -0.5f, 0.5f, 0, 1), 0, 1);
            float yPos = 1.0f - Global.Limit(Global.Map(localPos.y, -0.5f, 0.5f, 0, 1), 0, 1);

            if (other.transform.parent.name == "Hammer1" || other.transform.parent.name == "Hammer2")
            {
                velocity = Global.Limit (other.GetComponent<VelocityTracker>().getVelocity().magnitude / 4.0f, 0.0f, 1.0f);
                StartCoroutine (triggerHammer (xPos, yPos, exciterName));
            }

            if (exciterName == "Pick")
                StartCoroutine (initialisePick(xPos, yPos));

        }
    }

    IEnumerator triggerHammer(float xPos, float yPos, string name)
    {
        audioMixer.SetFloat("velocity", velocity);

        if (name == "Hammer1")
        {
            audioMixer.SetFloat("mouseX1", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
            audioMixer.SetFloat("mouseY1", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
        }
        else if (name == "Hammer2")
        {
            audioMixer.SetFloat("mouseX2", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
            audioMixer.SetFloat("mouseY2", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
        }

        yield return new WaitForSeconds(0.05f);


        if (name == "Hammer1")
        {
            if (!outOfBounds1)
                audioMixer.SetFloat("trigger1", 1.0f);

            yield return new WaitForSeconds(0.05f);

            audioMixer.SetFloat("trigger1", 0.0f);
        } 
        else if (name == "Hammer2")
        {
            if (!outOfBounds2)
                audioMixer.SetFloat("trigger2", 1.0f);
            yield return new WaitForSeconds(0.05f);

            audioMixer.SetFloat("trigger2", 0.0f);

        }
    }
    IEnumerator initialisePick (float xPos, float yPos)
    {
        audioMixer.SetFloat ("mouseX1", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
        audioMixer.SetFloat ("mouseY1", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
        yield return new WaitForSeconds(0.05f);
        audioMixer.SetFloat ("smooth", 1.0f);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ExciterArea")
        {
            string exciterName = other.transform.parent.name;
            // bool useBow = exciterName == "Bow";

            float xPos;
            float yPos;

            //// calculate where on the instrument it's exciting: ////
            excitationLoc.transform.position = other.transform.position;

            Vector3 localPos = new Vector3(excitationLoc.transform.localPosition.x, excitationLoc.transform.localPosition.y, excitationLoc.transform.localPosition.z);

            // map & limit values from -0.5 <-> 0.5 to 0 <-> 1, swap y value for JUCE
            xPos = Global.Limit(Global.Map(localPos.x, -0.5f, 0.5f, 0, 1), 0, 1);
            yPos = 1.0f - Global.Limit(Global.Map(localPos.y, -0.5f, 0.5f, 0, 1), 0, 1);

            // Hard-coded mappings of the play area to the x and y positions //
            switch (instrumentType)
            {
                case "Guitar":
                    yPos = 0.75f * yPos; // 6/8ths of the plugin are strings, the other 8ths are the bridge and body
                    float range = 0.1f;
                    float yPosPre = yPos;
                    yPos = Global.Limit(Global.Map(yPos, 0, 0.75f, -(1.0f - xPos) * range, 0.75f + (1.0f - xPos) * range), 0, 1);
                    break;

                case "Harp":
                    // Map to nonlinear shape of the harp. Top of harp is at at y-coordinate 0, bottom is y-coordinate 1
                    float upperBound = -0.5288f * xPos * xPos + 0.7488f * xPos; // coefficients found using MATLAB cftool
                    float lowerBound = (1.0f-0.74f*xPos);
                    yPos = Global.Map(yPos, upperBound, lowerBound, 0.0f, 1.0f);;
                    outOfBounds1 = (yPos >= 0 && yPos < 1) ? false : true;
                    audioMixer.SetFloat("excite", outOfBounds1 ? 0.0f : 1.0f);
                    break;

                //// ADD YOUR OWN CASES HERE FOR THE MAPPINGS OF YOUR CUSTOM INSTRUMENTS ////
                
                default:
                    Debug.LogWarning("No custom playarea defined");
                    break;
            }

            // Map according to the string orientation
            // Flip x and y positions if vertical
            if (exciterName == "Hammer2")
            {
                audioMixer.SetFloat("mouseX2", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
                audioMixer.SetFloat("mouseY2", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
            }
            else
            {
                // Get the velocity from the bow
                if (exciterName == "Bow")
                {
                    Vector3 velInteractable = (GetComponent<VelocityTracker>() == null) ? Vector3.zero : GetComponent<VelocityTracker>().getVelocity();
                    Vector3 vel = other.GetComponent<VelocityTracker>().getVelocity() - velInteractable;
                    
                    Debug.Log("Vel interactable: " + velInteractable + " " + " Bow velocity " + other.GetComponent<VelocityTracker>().getVelocity());

                    // Use the magnitude
                    float velToMixer = Global.Limit(Math.Sign(vel.x) * vel.magnitude + 0.5f, 0, 1);
                    audioMixer.SetFloat("velocity", Global.Limit(velToMixer, 0.0f, 1.0f));
                    
                }
                audioMixer.SetFloat("mouseX1", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
                audioMixer.SetFloat("mouseY1", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
            }
        }
    }

    private void OnTriggerExit (Collider other)
    {
        // Stop exciting if the bow leaves the play area (otherwise it keeps bowing)
        if (other.transform.parent.name == "Bow")
            audioMixer.SetFloat("excite", 0.0f);

        // Turn of smoothing such that the pick does not traverse all resonator modules when picked at a completely different location after leaving the play area
        if (other.transform.parent.name == "Pick")
            audioMixer.SetFloat("smooth", 0.0f);

    }

}
