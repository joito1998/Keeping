using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.XR;
using System.Net;
using System;

public class GetPositionOVR : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;

    public Vector3 RHP;
    public Vector3 Pos1;
    public Vector3 Pos2;

    public float Dis;

    GameObject selectedObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            selectedObj = eventSystem.currentSelectedGameObject.gameObject;

            Vector3 RHP = InputTracking.GetLocalPosition(XRNode.RightHand);

            Vector3 Pos1 = selectedObj.transform.localPosition;

            Dis = (float)Math.Sqrt((float)Math.Pow(RHP.x - Pos1.x, 2) + (float)Math.Pow(RHP.y - Pos1.y, 2) + (float)Math.Pow(RHP.z - Pos1.z, 2));

            Debug.Log("RHP.x:" + RHP.x + "RHP.y" + RHP.y + "RHP.z" + RHP.z);
            Debug.Log("RHP.x:" + Pos1.x + "RHP.y" + Pos1.y + "RHP.z" + Pos1.z);
            Debug.Log("Distance" + Dis + "m");
        }
    }
}
