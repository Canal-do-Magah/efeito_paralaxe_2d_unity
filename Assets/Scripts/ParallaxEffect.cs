using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public List<Transform> objetosDeFundo;
    public float intensidadeParallax = 0.5f;
    private Vector3 posicaoAnteriorCamera;
    void Start()
    {
        posicaoAnteriorCamera = Camera.main.transform.position;
    }

    void Update()
    {
        for(int i = 0; i < objetosDeFundo.Count; i++)
        {
            float parallax = (posicaoAnteriorCamera.x - 
                Camera.main.transform.position.x) * 
                (i * intensidadeParallax + 1);

            float novaPosicaoFundoX = objetosDeFundo[i].position.x 
                + parallax;

            Vector3 novaPosicao = new Vector3(novaPosicaoFundoX, 
                objetosDeFundo[i].position.y, objetosDeFundo[i].position.z);

            objetosDeFundo[i].position = novaPosicao;
        }
        posicaoAnteriorCamera = Camera.main.transform.position;
    }
}
