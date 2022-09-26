using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;
using Cinemachine.PostFX;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;


public class SpeedMotionBlur : MonoBehaviour
{
    public float hyperspeedThreshold;
    private ArcadeKart kart;
    public VolumeProfile slowVolume;
    public VolumeProfile fastVolume;
    public CinemachineVolumeSettings volumeSettings;

    private float maxSpeed;

    private void Awake()
    {
        kart = gameObject.GetComponent<ArcadeKart>();
        maxSpeed = kart.baseStats.TopSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate motion blur intensity
        float currentSpeed = kart.Rigidbody.velocity.magnitude;
        float currentSpeedPercentage = currentSpeed / maxSpeed;

        print(currentSpeedPercentage + " < " + hyperspeedThreshold + " = " + (currentSpeedPercentage < hyperspeedThreshold));
        if (currentSpeedPercentage < hyperspeedThreshold)
        {
            volumeSettings.InvalidateCachedProfile();
            print("Slow");
            volumeSettings.m_Profile = slowVolume;
            volumeSettings.InvalidateCachedProfile();
        }
        else
        {
            volumeSettings.InvalidateCachedProfile();
            print("Fast");
            volumeSettings.m_Profile = fastVolume;
            volumeSettings.InvalidateCachedProfile();
        }


    }
}
