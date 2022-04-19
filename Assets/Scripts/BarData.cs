using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BarData : MonoBehaviour
{
    //bar body and color
    public Color barColor;
    public RectTransform barTransform;
    public Transform endPos;
    public Transform startPos;

    //arrow body and speed
    public Transform arrowTransform;
    public float arrowSpeed;
    public int nPoints;
    private Sequence aMove;

    //point prefab

    public List<GameObject> tint = new List<GameObject>();

    private void Awake()
    {
        ArrowMove(1f);
    }

    //function responsible for instanciate and custom the stressed bar
    public BarData BarSetup(Transform barHolder, Color barColor, float arrowSpeed, int nPoints)
    {
        var nB = Instantiate(this, barHolder);
        nB.barColor = barColor;
        nB.arrowSpeed = arrowSpeed;
        nB.nPoints = nPoints;

        return nB;
    }

    public void ArrowMove(float speed)
    {
        aMove = DOTween.Sequence();

        aMove.Append(arrowTransform.DOMoveX(startPos.position.x, speed));
        
        aMove.Append(arrowTransform.DOMoveX(endPos.position.x, speed));
        aMove.Play().SetLoops(-1, LoopType.Restart);
    }
}
