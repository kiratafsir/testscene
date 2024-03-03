using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubespawn : MonoBehaviour
{
    public GameObject boxPrefab;

    private Vector3 MyPosition;
    private Quateranion myRotation;
    // Start is called before the first frame update
    void Start()
    {
        MyPosition = transform.position;
        MyPosition = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
