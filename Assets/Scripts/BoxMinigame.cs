using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class BoxMinigame : MonoBehaviour
{
    public ToyPickerUI hud;
    public Transform container;

    public int maxCount;
    private int boxCount;

    private UnityEvent OnAnimDone = new UnityEvent();
    private UnityEvent OnMinigameDone = new UnityEvent();

    private Transform test;

    private Material toyMaterial;
    private GameObject toy;

    private void Awake()
    {
        boxCount = 0;
        OnAnimDone.AddListener(() => Tdestroy(toy));
        OnMinigameDone.AddListener(SpawnHud);
    }
    private void OnTriggerEnter(Collider boxedObject)
    {
        Debug.Log("Object collided");
        toyMaterial = boxedObject.GetComponent<Renderer>().material;
        toy = boxedObject.gameObject;
        FadeToy(1f, toyMaterial);
        boxCount++;
        
        if(boxCount >= maxCount)
        {
            OnMinigameDone.Invoke();
            Core.Data.isInteracting = true;
        }
    }
    private void OnDestroy()
    {
        OnAnimDone.RemoveAllListeners();
        OnMinigameDone.RemoveAllListeners();
    }
    private void SpawnHud() => Instantiate(hud, container);
    private void FadeToy(float timeToFade, Material material) => material.DOFade(0f, timeToFade).SetEase(Ease.OutQuint).OnComplete(OnAnimDone.Invoke);
    private void Tdestroy(GameObject obj) => Destroy(obj);
}
