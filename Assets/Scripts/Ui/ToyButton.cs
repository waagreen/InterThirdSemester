using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToyButton : MonoBehaviour
{
    public TMP_Text nick;
    public Image gif;
    private Toy toy;

    public void ToySetup(Toy toy)
    {
        this.toy = toy;
        UpdateComponent();
    }

    private void UpdateComponent()
    {
        this.gif.sprite = toy.gif;
        nick.SetText(toy.toyName);
    }
}
