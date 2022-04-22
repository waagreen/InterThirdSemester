using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    [HideInInspector] public bool isComforting = false;
    [HideInInspector] public bool isHolding = false;
    [HideInInspector] public Vector3 grav;
    [HideInInspector] public Vector3 move;
    [Header("Movement Variables")]
    public float _speed;
    public float _gravity;

    [HideInInspector] public int stressLevel = 1;
    [Header("Stress Variables")]
    public float stressSpeed = 1f;
    public float waitTime = 30f;
}
