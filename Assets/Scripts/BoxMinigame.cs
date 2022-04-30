using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BoxMinigame : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider toyEraser;
    public Material toyMaterial;
    public int boxCount;

    
        void OnTriggerEnter(Collider boxedObject)
        {
            //if (boxedObject.CompareTag("PickUp"))
            
                toyMaterial = boxedObject.GetComponent<Material>();
                boxCount++;
                FadeToy(0.5f,toyMaterial);
                Destroy(boxedObject.gameObject, 1);
            
        }
    

    public void FadeToy(float timeToFade, Material toyMaterial)
    {
        toyMaterial.DOFade(0, timeToFade);
    }
}
