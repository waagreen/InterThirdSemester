using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    Selecionavel selecionado;
    public Text label;
    void Start()
    {
        label.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //projeta um raio a partir do mouse
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 10, new Color(255, 120, 10, 100));

        //testa a colisao do raio
        RaycastHit hit;
        Selecionavel selecao = null;

        if(Physics.Raycast(raio, out hit, 10))
        {
            selecao = hit.transform.GetComponent<Selecionavel>();            
        }

        if(selecao) selecao.AtivaSelecao();

        if(selecao != selecionado)
        {
            if(selecionado) selecionado.DesativaSelecao();
            selecionado = selecao;
        }

        if(selecionado)
        {
            label.text = selecionado.texto;
            if(Input.GetMouseButtonDown(1))
            {
                Clicavel clicado = selecionado.GetComponent<Clicavel>();
                if(clicado) clicado.Ativar();
            }

        }
        else
        {
            label.text = "";
        }
    }
}
