using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adm_Game : MonoBehaviour
{
    [Header("HUMANOS ----------------")]
    public int poblacionJ1;
    public Color ColorJ1;
    public GameObject[] tilesJugadorJ1;
    //private int cantTilesJ1 = 0;
    
    [Header("VIRUS --------------------")]
    [Space]
    public int poblacionJ2;
    public Color ColorJ2;
    public GameObject[] tilesJugadorJ2;
    //private int cantTilesJ2 = 0;

    [Header("OBJETOS -----------------")]
    [Space]
    public GameObject PanelTurno;
    public Text TituloTurno; 

    private int turno;

    void Start() {  //configuraciones que se ejecutan al principio del juego
        turno = 0; //Este valor va a cambiar para que se elijga un numero randon
        PasarTurno();
    }

    public void PasarTurno() {
        if ( turno == 0 ) {
           PanelTurno.GetComponent<Image>().color= ColorJ1; //Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
           TituloTurno.text = "Turno del Humano";
           turno = 1;
        }else {
           PanelTurno.GetComponent<Image>().color= ColorJ2;
           TituloTurno.text = "Turno del Virus";
           turno = 0;
        }
    }

}