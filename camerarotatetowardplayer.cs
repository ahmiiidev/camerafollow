using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotatetowardplayer : MonoBehaviour
{
    public Transform rotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.LookAt(rotate); 
        
    }

}
