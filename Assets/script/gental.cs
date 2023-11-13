using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gental : MonoBehaviour
{
    public GameObject position;
    public GameObject man;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(man, position.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
