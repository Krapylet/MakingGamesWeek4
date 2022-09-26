using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretObstacle : MonoBehaviour
{
    [SerializeField] private Transform CartTransform;
    private Material material;

    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        material.SetVector("_Player", CartTransform.position);
        
    }
}
