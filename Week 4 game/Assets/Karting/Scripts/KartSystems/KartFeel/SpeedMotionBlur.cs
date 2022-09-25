using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;
using Cinemachine.PostFX;
//using UnityEngine.Rendering.PostProcessing;

public class SpeedMotionBlur : MonoBehaviour
{

    public ArcadeKart kart;
    public CinemachineVolumeSettings volume;
    public CinemachinePostProcessing Processing;
 

    private float maxSpeed;

    private void Start()
    {
        maxSpeed = kart.GetMaxSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = kart.Rigidbody.velocity.magnitude;
        float currentSpeedPercentage = currentSpeed / maxSpeed;
        //Processing.m_Profile. ???
        //volume.m_Profile;
    }
}
