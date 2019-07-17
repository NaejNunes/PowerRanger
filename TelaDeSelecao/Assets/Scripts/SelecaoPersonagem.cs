using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecaoPersonagem : MonoBehaviour
{

    public Sprite spriteSelecionado;

    public Sprite spriteNaoSelecionado;

    public Sprite personagemFoto;

    public int vida;
    public int agilidade;
    public int forca;
    public int defesa;

    public bool selecionado;

    void Start()
    {
        var spritePersonagem = transform.GetChild(4).GetComponent<Image>();
        spritePersonagem.sprite = personagemFoto;

        var sliderVida = transform.GetChild(0).GetComponentInChildren<Slider>();
        sliderVida.value = vida;

        var sliderAgilidade = transform.GetChild(1).GetComponentInChildren<Slider>();
        sliderAgilidade.value = agilidade;

        var sliderForca = transform.GetChild(2).GetComponentInChildren<Slider>();
        sliderForca.value = forca;

        var sliderDefesa = transform.GetChild(3).GetComponentInChildren<Slider>();
        sliderDefesa.value = defesa;

        if (selecionado)
        {
            AtivarBotao();
        }
        else
        {
            DesativarBotao(); 
        }
    }

    void Update(){}

    public void AtivarBotao()
    {
        selecionado = true;
        GetComponent<Image>().sprite = spriteSelecionado;
    }

    public void DesativarBotao()

    {
        selecionado = false;
        GetComponent<Image>().sprite = spriteNaoSelecionado;
    }

    public void Clicou()
    {
        var listaBotoes = FindObjectsOfType<SelecaoPersonagem>();
        foreach (var botao in listaBotoes)
        {
            botao.DesativarBotao();
        }
        AtivarBotao();
    }
}
