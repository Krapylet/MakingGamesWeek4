using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;
using Cinemachine.PostFX;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;


public class SpeedMotionBlur : MonoBehaviour
{

    public ArcadeKart kart;
    public Volume volume;

    private float maxSpeed;

    private void Start()
    {
        maxSpeed = kart.baseStats.TopSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate motion blur intensity
        float currentSpeed = kart.Rigidbody.velocity.magnitude;
        float currentSpeedPercentage = currentSpeed / maxSpeed;

        volume.weight = currentSpeedPercentage;
    }
}
