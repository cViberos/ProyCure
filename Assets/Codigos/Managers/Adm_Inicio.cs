using UnityEngine;
using UnityEngine.SceneManagement;

public class Adm_Inicio : MonoBehaviour
{
    [Header("Escena a Cargar")]
    [Tooltip("Es el nombre de la escena que se cargará si todo esta OK")]
    public string NombreEscena = "";
    
    //Codigo para cargar la escena siguiente
    public void Cargar (){
        SceneManager.LoadScene(NombreEscena, LoadSceneMode.Single);
    }

    //Codigo para salir del juego
    public void Salir (){
		Application.Quit();
	}
}
