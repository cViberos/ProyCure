using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int sizeX, sizeY;
    public float separationX,separationY, offset;
    public GameObject[] modeloTile;
    GameObject newCopy;
    void Start()
    {
        
       for (int i = 0; i<sizeY ; i++)
        {
            for (int j = 0 ; j<sizeX ; j++)
            {
                float actualOffset;
                if(i%2 == 0)
                {
                    actualOffset = 0; 
                }else
                {
                    actualOffset = offset;
                }
                GameObject unidad = modeloTile[Random.Range(0,10)] ; 
                newCopy = Instantiate(  unidad,new Vector3
                                        (j * unidad.transform.localScale.x * separationX + actualOffset,
                                        0, 
                                        i * unidad.transform.localScale.z * separationY)
                                        ,Quaternion.identity);
                newCopy.transform.parent = transform;
                newCopy.SetActive(true);
                //newCopy.GetComponent<MeshRenderer>().material.SetColor("_Color", Random.ColorHSV());
                //newCopy.GetComponent<tileData>().posX = j;
                //newCopy.GetComponent<tileData>().posY = i;

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
