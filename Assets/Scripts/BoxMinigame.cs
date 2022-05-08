using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class BoxMinigame : MonoBehaviour
{
    private UnityEvent OnAnimDone = new UnityEvent();
    private Material toyMaterial;
    private GameObject toy;
    private int boxCount;

    private void Awake() => OnAnimDone.AddListener(() => Tdestroy(toy));
    
    private void OnTriggerEnter(Collider boxedObject)
    {
        Debug.Log("Object collided");
        toyMaterial = boxedObject.GetComponent<Renderer>().material;
        toy = boxedObject.gameObject;
        FadeToy(1f, toyMaterial);
    }
    private void FadeToy(float timeToFade, Material material) => material.DOFade(0f, timeToFade).SetEase(Ease.OutQuint).OnComplete(OnAnimDone.Invoke);
    private void Tdestroy(GameObject obj) => Destroy(obj);

    private void OnDestroy() => OnAnimDone.RemoveAllListeners();
}
