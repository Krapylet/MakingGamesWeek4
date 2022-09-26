using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using KartGame.KartSystems;

public class SpeedCameraShake : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public AnimationCurve curveShake;
    private CinemachineBasicMultiChannelPerlin noise;

    public float minShake;
    public float shakeScale;

    private ArcadeKart kart;
    private float maxSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        noise = vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        kart = gameObject.GetComponent<ArcadeKart>();
        maxSpeed = kart.baseStats.TopSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = kart.Rigidbody.velocity.magnitude;
        float currentSpeedPercentage = currentSpeed / maxSpeed;

        noise.m_AmplitudeGain = curveShake.Evaluate(currentSpeedPercentage) + minShake;
  
    }
}