using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littleboymoveend : MonoBehaviour
{
    public float speed;
    private Vector3 targerPosition = new Vector3(9,-3,0); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position,targerPosition,0.001f);
    }
}
