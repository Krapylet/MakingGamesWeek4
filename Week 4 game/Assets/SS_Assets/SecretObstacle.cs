using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretObstacle : MonoBehaviour
{
    [SerializeField] private string oppositePlayer = "PlayerRed";
    private GameObject cart;
    private Material material;

    void Start()
    {
        cart = GameObject.FindWithTag(oppositePlayer);
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        material.SetVector("_Player", cart.transform.position);
    }
}
