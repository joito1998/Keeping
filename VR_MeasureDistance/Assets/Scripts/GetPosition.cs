using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Playables;
using System;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

public class GetPosition : MonoBehaviour
{
    [SerializeField] TextMeshPro _Distance;

    public Vector3 RHP;
    public Vector3 Pos1;
    public Vector3 Pos2;

    public float Dis1;
    public float Dis2;
    public float Dis3;
    public GameObject Pin1;
    public GameObject Pin2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PositionGet()
    {
        Vector3 RHP = InputTracking.GetLocalPosition(XRNode.RightHand);

        Vector3 Pos1 = Pin1.transform.localPosition;

        Vector3 Pos2 = Pin2.transform.localPosition;

        Dis1 = (float)Math.Sqrt((float)Math.Pow(RHP.x - Pos1.x, 2) + (float)Math.Pow(RHP.y - Pos1.y, 2) + (float)Math.Pow(RHP.z - Pos1.z, 2));
        Dis2 = (float)Math.Sqrt((float)Math.Pow(RHP.x - Pos2.x, 2) + (float)Math.Pow(RHP.y - Pos2.y, 2) + (float)Math.Pow(RHP.z - Pos2.z, 2));
        Dis3 = (float)Math.Sqrt((float)Math.Pow(Pos1.x - Pos2.x, 2) + (float)Math.Pow(Pos1.y - Pos2.y, 2) + (float)Math.Pow(Pos1.z - Pos2.z, 2));

        //Debug.Log("RHP.x:"+RHP.x+"RHP.y"+RHP.y+"RHP.z"+RHP.z);
        //Debug.Log("Pos1.x:" + Pos1.x + "Pos1.y" + Pos1.y + "Pos1.z" + Pos1.z);
        Debug.Log("DistanceControllerToPin1" + Dis1 + "m");
        Debug.Log("DistanceControllerToPin2" + Dis2 + "m");
        Debug.Log("DistancePin1ToPin2" + Dis3 + "m");

        _Distance.text = "ControllerToPin1\n" + Dis1 + "m\n" + "ControllerToPin2\n" + Dis2 + "m\n" + "Pin1ToPin2\n" + Dis3 + "m";
    }
}
