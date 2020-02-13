using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int sizeX, sizeY;
    public float separationX,separationY, offset;
    public bool reCenter=true,canBeRay=true;
    public GameObject[] modeloTile;
    GameObject newCopy;
    void Start()
    {
        
       for (int i = 0; i<sizeY ; i++)
       {
            for (int j = 0 ; j<sizeX ; j++)
            {
                //offset indica la posicion en q se colocara el tile
                float actualOffset;
                if(i%2 == 0)
                {
                    actualOffset = 0; 
                }else
                {
                    actualOffset = offset;
                }
                //crear un tile nuevo
                GameObject unidad = modeloTile[Random.Range(0,modeloTile.Length)] ; 
                newCopy = Instantiate(  unidad,new Vector3
                                        (j * unidad.transform.localScale.x * separationX + actualOffset,
                                        0, 
                                        i * unidad.transform.localScale.z * separationY)
                                        ,unidad.transform.rotation);

                newCopy.transform.parent = transform;
                newCopy.SetActive(true);
                if(canBeRay)
                {
                    newCopy.layer = LayerMask.NameToLayer("noRay");
                    newCopy.GetComponent<tileData>().posX = j;
                    newCopy.GetComponent<tileData>().posY = i;
                }
                

            }
       }
        //if recenter,posicionar todo al medio de la camara
        if (reCenter)
        {
            transform.SetPositionAndRotation(transform.position + new Vector3(sizeX*(-0.6f),0,sizeY*(-0.21f)), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
