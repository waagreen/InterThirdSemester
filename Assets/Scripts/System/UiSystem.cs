using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiSystem : MonoBehaviour
{
    [SerializeField] private Transform barHolder;
    
    public BarData stress;

    public RectTransform point;
    private List<RectTransform> points = new List<RectTransform>();

    private bool isStressed = false;
    private BarData activeBar;

    public void CreateStressBar(float stressLevel)
    {
        if (isStressed) return;

        if (stressLevel >= 0.75f) activeBar = stress.BarSetup(barHolder, Color.red, 5f, 5);
        else if (stressLevel >= 0.50f) activeBar = stress.BarSetup(barHolder, Color.yellow, 15f, 4);
        else if (stressLevel >= 0.25f) activeBar = stress.BarSetup(barHolder, Color.blue, 20f, 3);
        else activeBar = stress.BarSetup(barHolder, Color.cyan, 5f, 3);

        CreatePoints(activeBar.nPoints);
        isStressed = true;
    }


    public void CreatePoints(int nPoints)
    {
        for (int i = 0; i < nPoints; i++)
        {
            Debug.Log($"Instaciate {i} bars: ");
            var a = Instantiate(point, new Vector3(Random.Range(activeBar.startPos.position.x, activeBar.endPos.position.x), 0.5f, 0f), transform.rotation, activeBar.transform);
            a.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, activeBar.barTransform.rect.x);
        }
    }
}
