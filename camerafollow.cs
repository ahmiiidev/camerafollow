using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;

    Vector3 offs;

    // Start is called before the first frame update
    void Start()
    {
        offs = target.position - transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = target.position - offs;
    }


}
