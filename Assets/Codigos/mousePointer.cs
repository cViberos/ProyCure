using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePointer : MonoBehaviour
{
    public GameObject cameraPivot;
    public GameObject particle;
    public GameObject selector;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraPivot)
        {
            //cameraPivot.transform.position = transform.position;
            if (Input.GetKey("left"))
            {
                cameraPivot.transform.Rotate(0, 5f, 0);
            }
            if (Input.GetKey("right"))
            {
                cameraPivot.transform.Rotate(0, -5f, 0);
            }
            if(Input.mouseScrollDelta.y != 0f)
            {
                Camera.main.orthographicSize += Input.mouseScrollDelta.y;
            }
        }
        
        
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        LayerMask layerMask = (1 << 9);
        if (Physics.Raycast(inputRay, out hit, layerMask))
        {
            transform.position = new Vector3(hit.point.x,0,hit.point.z);       
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //fisica
    }
    private void OnTriggerEnter(Collider other)
    {
        //colision sin fisica
        //print("trig");
        //print(other.gameObject.name);
        //print(other.GetComponent<tileData>().posX);
        //print(other.GetComponent<tileData>().posY);
        particle.transform.position = other.transform.position;
        selector.transform.position = other.transform.position;

    }

}
