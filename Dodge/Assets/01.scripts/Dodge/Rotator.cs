using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotation_speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotation_speed * Time.deltaTime, 0);
        //Rotate(프레임 마다 지정한 값만큼 회전한다.
        
    }
}
