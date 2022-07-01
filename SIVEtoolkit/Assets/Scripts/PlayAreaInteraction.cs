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

    // Update is called once per frame
    void Update()
    {
        
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


            // map & limit values, swap value for juce (Silvin: turns out it's always from -0.5 to 0.5)
            float xPos = Global.Limit(Global.Map(localPos.x, -0.5f, 0.5f, 0, 1), 0, 1);
            float yPos = 1.0f - Global.Limit(Global.Map(localPos.y, -0.5f, 0.5f, 0, 1), 0, 1);

            switch (instrumentType)
            {
                case "Marimba":
                    bool outOfBoundsBlackNotes = mapMarimba(ref xPos, ref yPos);
                    if (exciterName == "Hammer1")
                        outOfBounds1 = outOfBoundsBlackNotes;
                    else if (exciterName == "Hammer2")
                        outOfBounds2 = outOfBoundsBlackNotes;
                    if (!outOfBoundsBlackNotes)
                        checkMarimbaOutOfBounds(yPos, other.transform.parent.name);
                    xPos = (Mathf.Floor(xPos * 49.0f) + 0.5f) / 49.0f; 
                    break;
                case "Timpani":
                    float xNormalised = (xPos - 0.5f) * 2.0f;
                    float yNormalised = (yPos - 0.5f) * 2.0f;
                    if (exciterName == "Hammer1")
                        outOfBounds1 = (xNormalised * xNormalised + yNormalised * yNormalised >= 1);
                    else if (exciterName == "Hammer2")
                        outOfBounds2 = (xNormalised * xNormalised + yNormalised * yNormalised >= 1);
                    Debug.Log(xNormalised + " " + yNormalised);
                    break;
                default:
                    
                    break;
            }
            if (other.transform.parent.name == "Hammer1" || other.transform.parent.name == "Hammer2")
            {
                velocity = Global.Limit (other.GetComponent<VelocityTracker>().getVelocity().magnitude / 4.0f, 0.0f, 1.0f);
                StartCoroutine (triggerHammer (xPos, yPos, exciterName));
            }

            if (exciterName == "Pick")
                StartCoroutine (initialisePick(xPos, yPos));

        }
    }
    private void checkMarimbaOutOfBounds(float yPos, string name)
    {
        if (name == "Hammer1")
            outOfBounds1 = (yPos >= 0 && yPos < 1) ? false : true;
        else if (name == "Hammer2")
            outOfBounds2 = (yPos >= 0 && yPos < 1) ? false : true;
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
            // Debug.Log(transform.GetComponent<Collider>().ClosestPoint(other.transform.position));
            // other.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position)


            //transform.GetChild(0).transform.position = transform.GetComponent<Collider>().ClosestPoint(other.transform.GetComponent<Collider>().ClosestPoint(transform.position));
            // transform.GetChild(0).transform.position = other.transform.GetComponent<Collider>().ClosestPoint(transform.position);
            string exciterName = other.transform.parent.name;
            bool useBow = exciterName == "Bow";

            float xPos;
            float yPos;

            //// calculate where on the instrument it's exciting: ////
            excitationLoc.transform.position = other.transform.position;

            Vector3 localPos = new Vector3(excitationLoc.transform.localPosition.x, excitationLoc.transform.localPosition.y, excitationLoc.transform.localPosition.z);

            // Debug.Log("localPoses: " + localPos.x + " " + localPos.y);
            // Debug.Log("exciter pos: " + excitationLoc.transform.position +  " exciter local pos: " + excitationLoc.transform.localPosition);

            if (useBow)
            {
                // THIS IS SEMI CORRECT FOR THE HEIGHT (position along the string of the cello)
                transform.GetChild(0).transform.position = other.transform.GetComponent<Collider>().ClosestPoint(transform.position);

                //Debug.Log("Transform diff: " + (transform.GetComponent<Collider>().transform.position - other.transform.position) + " Scale exciter area: " + other.gameObject.transform.lossyScale + " Scale play area: " + transform.lossyScale);
                float diff = stringOrientation == StringOrientation.Vertical ? (transform.GetComponent<Collider>().transform.position.x - other.transform.position.x) : (transform.GetComponent<Collider>().transform.position.y - other.transform.position.y);
                //Debug.Log("Transform diff perpendicular to strings: " + diff);
                //Debug.Log("Normalised difference " + (diff / other.gameObject.transform.lossyScale.z + 0.5f));
                //xPos = (diff / other.gameObject.transform.lossyScale.z + 0.5f);

                // not sure why we're doing the 1.0f - y
                xPos = stringOrientation == StringOrientation.Vertical ? Global.Limit(Global.Map(localPos.x, -0.5f, 0.5f, 0, 1), 0, 1) : 1.0f - Global.Limit(Global.Map(localPos.y, -0.5f, 0.5f, 0, 1), 0, 1);
                yPos = stringOrientation == StringOrientation.Vertical ? 1.0f - Global.Limit(Global.Map(localPos.y, -0.5f, 0.5f, 0, 1), 0, 1) : Global.Limit(Global.Map(localPos.x, -0.5f, 0.5f, 0, 1), 0, 1);
            }
            else
            {
                // map & limit values, swap value for juce (Silvin: turns out it's always from -0.5 to 0.5)
                xPos = Global.Limit(Global.Map(localPos.x, -0.5f, 0.5f, 0, 1), 0, 1);
                yPos = 1.0f - Global.Limit(Global.Map(localPos.y, -0.5f, 0.5f, 0, 1), 0, 1);
            }

            // Debug.Log(Global.Map(localPos.x, -xBounds / 2, xBounds / 2, 0, 1) + " " + Global.Map(localPos.y, -yBounds / 2, yBounds / 2, 0, 1));

            // Hard-coded mappings of the play area to the x and y positions

            double[] yVec = new double[3] { xPos, yPos, 1.0 };
            double[] locOnSquare = new double[3];

            switch (instrumentType)
            {
                case "Guitar":
                    yPos = 0.75f * yPos;
                    float range = 0.1f;
                    float yPosPre = yPos;
                    yPos = Global.Limit(Global.Map(yPos, 0, 0.75f, -(1.0f - xPos) * range, 0.75f + (1.0f - xPos) * range), 0, 1);
                    break;
                case "Harp":
                    // top of harp is at at y-coordinate 0, bottom is y-coordinate 1
                    float upperBound = -0.5288f * xPos * xPos + 0.7488f * xPos; // matlab cftool
                    float lowerBound = (1.0f-0.74f*xPos);
                    yPos = Global.Map(yPos, upperBound, lowerBound, 0.0f, 1.0f);;
                    outOfBounds1 = (yPos >= 0 && yPos < 1) ? false : true;
                    audioMixer.SetFloat("excite", outOfBounds1 ? 0.0f : 1.0f);

                    // //float yPosN = xPos; 
                    // yPos = 1 - yPos;
                    // xPos = xPos;
                    // if (yPos > 0.7419)
                    // {
                    //     double[,] m = new double[3, 3] { { 10.6214, 0.0, 0.0 }, { 7.1381, 1.0, 0.0 }, { 9.6214, 0.0, 1.0 } };

                    //     double det = m[0, 0] * (m[1, 1] * m[2, 2] - m[2, 1] * m[1, 2]) -
                    //         m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                    //         m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

                    //     double invdet = 1 / det;

                    //     double[,] minv = new double[3, 3]; // inverse of matrix m
                    //     minv[0, 0] = (m[1, 1] * m[2, 2] - m[2, 1] * m[1, 2]) * invdet;
                    //     minv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) * invdet;
                    //     minv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) * invdet;
                    //     minv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) * invdet;
                    //     minv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) * invdet;
                    //     minv[1, 2] = (m[1, 0] * m[0, 2] - m[0, 0] * m[1, 2]) * invdet;
                    //     minv[2, 0] = (m[1, 0] * m[2, 1] - m[2, 0] * m[1, 1]) * invdet;
                    //     minv[2, 1] = (m[2, 0] * m[0, 1] - m[0, 0] * m[2, 1]) * invdet;
                    //     minv[2, 2] = (m[0, 0] * m[1, 1] - m[1, 0] * m[0, 1]) * invdet;

                    //     locOnSquare[0] = minv[0, 0] * yVec[0] + minv[1, 0] * yVec[1] + minv[2, 0] * yVec[2];
                    //     locOnSquare[1] = minv[0, 1] * yVec[0] + minv[1, 1] * yVec[1] + minv[2, 1] * yVec[2];
                    //     locOnSquare[2] = minv[0, 2] * yVec[0] + minv[1, 2] * yVec[1] + minv[2, 2] * yVec[2];

                    //     yPos = (float)(locOnSquare[1] / locOnSquare[2]);
                    //     //if (yPos > 1 || xPos > 1)
                    //     //{
                    //     //    yPos = 0;
                    //     //    xPos = 0;
                    //     //}
                    //     Debug.Log("calculated area B");
                    // }
                    // else if (xPos > 0.1328 && yPos <= 0.7419)
                    // {
                    //     double[,] m = new double[3, 3] { { -8.9858, 0.0, 1.1706 }, { -6.5399, -0.1706, 0.8685 }, { -8.8151, 0.0, 1.0 } };


                    //     double det = m[0, 0] * (m[1, 1] * m[2, 2] - m[2, 1] * m[1, 2]) -
                    //         m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                    //         m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

                    //     double invdet = 1 / det;

                    //     double[,] minv = new double[3, 3]; // inverse of matrix m
                    //     minv[0, 0] = (m[1, 1] * m[2, 2] - m[2, 1] * m[1, 2]) * invdet;
                    //     minv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) * invdet;
                    //     minv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) * invdet;
                    //     minv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) * invdet;
                    //     minv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) * invdet;
                    //     minv[1, 2] = (m[1, 0] * m[0, 2] - m[0, 0] * m[1, 2]) * invdet;
                    //     minv[2, 0] = (m[1, 0] * m[2, 1] - m[2, 0] * m[1, 1]) * invdet;
                    //     minv[2, 1] = (m[2, 0] * m[0, 1] - m[0, 0] * m[2, 1]) * invdet;
                    //     minv[2, 2] = (m[0, 0] * m[1, 1] - m[1, 0] * m[0, 1]) * invdet;

                    //     locOnSquare[0] = minv[0, 0] * yVec[0] + minv[1, 0] * yVec[1] + minv[2, 0] * yVec[2];
                    //     locOnSquare[1] = minv[0, 1] * yVec[0] + minv[1, 1] * yVec[1] + minv[2, 1] * yVec[2];
                    //     locOnSquare[2] = minv[0, 2] * yVec[0] + minv[1, 2] * yVec[1] + minv[2, 2] * yVec[2];

                    //     yPos = (float)(locOnSquare[1] / locOnSquare[2]);
                    //     //if (yPos > 1 || xPos > 1)
                    //     //{
                    //     //    yPos = 0;
                    //     //    xPos = 0;
                    //     //}
                    //     Debug.Log("calculated area C");
                    // }
                    // else Debug.Log("calculated area A");
                    break;
                case "BanjoLele":
                    yPos = 0.66f * yPos; // 4/6 are strings 
                    break;
                case "Shamisen":
                    yPos = 0.6f * yPos; // 3/5 resonators are strings
                    break;
                case "Timpani":
                    break;
                case "Marimba":
                    // only do hammers in OnTriggerEnter
                    if (exciterName == "Hammer1" || exciterName == "Hammer2")
                        return;

                    bool outOfBoundsBlackNotes = mapMarimba (ref xPos, ref yPos);
                    if (exciterName == "Hammer1")
                        outOfBounds1 = outOfBoundsBlackNotes;
                    else if (exciterName == "Hammer2")
                        outOfBounds2 = outOfBoundsBlackNotes;

                    if (!outOfBoundsBlackNotes)
                        checkMarimbaOutOfBounds(yPos, exciterName);
                    break;
                case "Cello":
                    break;
                default:
                    Debug.LogWarning("No custom playarea defined");
                    break;
            }

            //Debug.Log("xPos: " + xPos +" ypos: " + yPos);

            // Map according to the string orientation
            // Flip x and y positions if vertical
            if (exciterName == "Hammer2")
            {
                audioMixer.SetFloat("mouseX2", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
                audioMixer.SetFloat("mouseY2", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
            }
            else
            {
                if (exciterName == "Bow")
                {
                    Vector3 velInteractable = (GetComponent<VelocityTracker>() == null) ? Vector3.zero : GetComponent<VelocityTracker>().getVelocity();
                    Vector3 vel = other.GetComponent<VelocityTracker>().getVelocity() - velInteractable;
                    //vel *= 1.5f;
                    Debug.Log("Vel interactable: " + velInteractable + " " + " Bow velocity " + other.GetComponent<VelocityTracker>().getVelocity());
                    //Debug.Log(vel);

                    float velToMixer = Global.Limit(Math.Sign(vel.x) * vel.magnitude + 0.5f, 0, 1);
                    audioMixer.SetFloat("velocity", Global.Limit(velToMixer, 0.0f, 1.0f));
                    
                }
                audioMixer.SetFloat("mouseX1", stringOrientation == StringOrientation.Vertical ? yPos : xPos);
                audioMixer.SetFloat("mouseY1", stringOrientation == StringOrientation.Vertical ? xPos : yPos);
            }
            // if (exciterName == "Pick")
            //     audioMixer.SetFloat("smooth", 1.0f);


            // visual representation
            //excitelocIcon.GetComponent<RectTransform>().anchoredPosition = new Vector2(xPos * 10, yPos * 10);

        }
    }
    private bool mapMarimba (ref float xPos, ref float yPos)
    {
        bool outOfBoundsBlackNotes = false; 
        // the "white" notes             
        if (yPos < 0.5f)
        {
            // mapping of the visual slope of the white notes
            yPos = yPos * 2;
            yPos = Global.Map(yPos, 0.5f * xPos, 1, 0, 1);
            // 49 notes, only select the first 29
            xPos *= 29.0f/49.0f;
        }
        else  // the "black" notes             
        {       
            // mapping of the visual slope of the black notes
            yPos = (yPos - 0.5f) * 2;
            yPos = Global.Map(yPos, 0, (1-0.5f * xPos), 0, 1);

            // exclude the "holes" between the black notes
            float barWidth = 1.0f/29.0f; // the width of a bar as the ratio of the playarea

            // the index of the bar which is hit (including the holes)
            int idx = (int)Math.Floor((xPos - 0.5f * barWidth) / barWidth); // notice that the xPos is shifted to start at the first note (half a barwidth)

            // the holes have index 2 and 6 in the octave (0: C#, 1: D#, 2: <hole>, 3: F#, etc.)
            if (idx % 7 == 2 || idx % 7 == 6 || idx < 0 || idx > 27) // 27 because of 4 octaves (including holes) minus 1 due to the last hole
            {
                outOfBoundsBlackNotes = true;
            }

            Debug.Log("Idx = " + idx);
            // Map xPos to plugin. As the holes are not included in the plugin, these need to be subtracted from the xPos
            float barWidthsTakenAway = 2.0f * (float)Math.Floor(idx / 7.0f); // for every octave take away two barWidths
            // take away an extra barWidth if the idx is that of a F#, G# or A#
            if (idx % 7 > 2)
                barWidthsTakenAway += 1;


            // always reduced by one half at left side of the play area
            barWidthsTakenAway += 0.5f; 

            // 4 octaves, 2 per octave, 0.5 extra on both sides
            int totBarWidthsOutOfBounds = 4 * 2 + 1;
            // scale xPos between 0 and 1
            xPos = (xPos - barWidth * barWidthsTakenAway) / (1.0f - barWidth * totBarWidthsOutOfBounds); // NEED TO LOOK AT THIS

            //The last 20 out of 49 notes are the black ones
            xPos *= 20.0f/49.0f;
            xPos += 29.0f/49.0f;
            
            // xPos = (29.0f + (idx - barWidthsTakenAway) + 0.5f) / 49.0f;
        }
        return outOfBoundsBlackNotes;
    }
    private void OnTriggerExit (Collider other)
    {
        if (other.transform.parent.name == "Bow")
            audioMixer.SetFloat("excite", 0.0f);
        if (other.transform.parent.name == "Pick")
            audioMixer.SetFloat("smooth", 0.0f);

    }

}
