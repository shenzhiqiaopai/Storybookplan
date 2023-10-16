using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littleboymove2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.5f*Time.deltaTime,-0.5f*Time.deltaTime,0);
        Destroy(gameObject, 10.0f);
    }
}
