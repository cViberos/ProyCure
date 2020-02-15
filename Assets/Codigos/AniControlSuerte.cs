using UnityEngine;
using UnityEngine.UI;
//using Random = UnityEngine.Random;

public class AniControlSuerte : MonoBehaviour
{
    [Header("PANELES -----------------")]
    [Space]
    public GameObject PanelAnuncio;
    public Text TextoContador;
    public Text SumaDados;
    private int OrdenAnim = 0;

    [Header("DADOS -------------------")]
    [Space]
    public Image Dado1;
    public Image Dado2;
    private int valDado1, valDado2;
    public Sprite[] DadoCaras;
    public Animation[] DadoAnimacion;
    
    void MensajeBoton(string textoInfo) {
        TextoContador.text = textoInfo;
        //Usamos  este comando para saber que valor tiene algun parametro del animator:
        //  this.GetComponent<Animator>().GetInteger("SuerteOrden")
    }

    public void LanzarDado() {
        valDado1 = Random.Range(0, 5);
        valDado2 = Random.Range(0, 5);
        Dado1.sprite = DadoCaras[valDado1];
        Dado2.sprite = DadoCaras[valDado2];
        SumaDados.text = (valDado1 + valDado2 + 2).ToString();
        //se suma 2 xq se elije aleatoriamente valores de 0 a 5
    }

    public void OnClicLanzar() {  //Procedimiento que puede asiganar la animacion 1,2,etc
        OrdenAnim++;
        this.GetComponent<Animator>().SetInteger("SuerteOrden",OrdenAnim);
    }

    public void TerminarAnuncio() {
        PanelAnuncio.SetActive(false);
    }
}
