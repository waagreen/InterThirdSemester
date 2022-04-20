using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    [HideInInspector] public Vector3 grav;
    [HideInInspector] public Vector3 move;
    [Header("Movement Variables")]
    public float _speed;
    public float _gravity;

    [HideInInspector] public float stressLevel = 0f;
    [Header("Stress Variables")]
    public float stressSpeed = 1f;
    public float waitTime = 30f;
}
