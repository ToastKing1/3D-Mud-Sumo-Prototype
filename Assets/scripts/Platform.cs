using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform platTrans;
    public double speed = 0.1;

    // Update is called once per frame
    void Update()
    {
        if (platTrans.localScale.x > 0.1)
        {
            platTrans.localScale = new Vector3((float)(platTrans.localScale.x - speed * Time.deltaTime), (float)0.04, (float)(platTrans.localScale.z - speed * Time.deltaTime));
        }
        }
}
