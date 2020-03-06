using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreBall : MonoBehaviour
{
    public int ignore1;
    public int ignore2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(ignore1, ignore2);
    }
}
