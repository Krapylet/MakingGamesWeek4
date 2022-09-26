using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealNearby : MonoBehaviour
{
    [SerializeField] private Material revealed;
    [SerializeField] private string checkAgainst = "Red";
    [SerializeField] private float radius = 10f;

    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (var hit in colliders)
        {
            if (hit.transform.CompareTag(checkAgainst))
            {
                hit.transform.GetComponent<MeshRenderer>().material = revealed;
                // var material = hit.transform.GetComponent<MeshRenderer>().material;
                // material.SetFloat("_Visible", -1f);
                // material.SetColor("_Color", Color.green);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
