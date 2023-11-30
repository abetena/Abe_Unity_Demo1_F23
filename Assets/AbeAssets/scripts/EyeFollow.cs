using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeFollow : MonoBehaviour
{
    //the object to follow
    public GameObject Target;

    // Update is called once per frame
    void Update()
    {
        //check if there is a target (in case it is destroyed)
        if (Target)
        {

            //take the target, and find the opposite direction in degrees
            Vector3 Look = transform.InverseTransformPoint(Target.transform.position);
            float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg - 90;

            //rotate this object using the degrees obtained above
            transform.Rotate(0, 0, Angle);
        }
    }
}
