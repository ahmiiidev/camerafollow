using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothcamerafollow : MonoBehaviour
{
    public Transform target;
    
    public float speed ;

    public float yoffsets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newpos = new Vector3(target.position.x, target.position.y + yoffsets, -10f);

       transform.position = Vector3.Slerp( transform.position , newpos,speed * Time.deltaTime);


    }
}
