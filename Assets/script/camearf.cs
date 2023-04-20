using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camearf : MonoBehaviour
{
    public Transform playerTrans;
    public Vector3 zoom;


    private void LateUpdate()
    {
        transform.position = playerTrans.position + zoom;


    }
}
