using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecionavel : MonoBehaviour
{
    public Material original;
    public Material selecionado;
    public string texto;
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = original;
    }

    public void AtivaSelecao()
    {
        renderer.material = selecionado;
    }

    public void DesativaSelecao()
    {
        renderer.material = original;
    }
}
