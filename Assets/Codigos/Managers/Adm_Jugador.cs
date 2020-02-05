using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adm_Jugadores : MonoBehaviour
{
    [Space]
    [Header("Datos del Humano")]
    public int HumanoPoblacion;
    public int HumanoRecursos;
    public int HumanoPuntos;
    public int HumanoAreas;
    [Space]
    [Header("Datos del Virus")]
    public int VirusPoblacion;
    public int VirusRecursos;
    public int VirusPuntos;
    public int VirusAreas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("poblacion" + poblacion);
    }
}
