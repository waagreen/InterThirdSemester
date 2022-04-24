using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    [HideInInspector] public bool isComforting = false;
    [HideInInspector] public Vector3 grav;
    [HideInInspector] public Vector3 move;
    [Header("Movement Variables")]
    public float _speed;
    public float _gravity;
    public RaycastHit hit;
    public Ray ray;
    

    [HideInInspector] public int stressLevel = 1;
    [Header("Stress Variables")]
    public float stressSpeed = 1f;
    public float waitTime = 30f;

    //Setup das interações
    [Header("Interaction Variables")]
    public float contactDistance = 1.5f;
    public GameObject playerHands;
    public bool isHolding = false;
    public bool testBool = false;
    [HideInInspector] public GameObject selectedObject;
    
}
