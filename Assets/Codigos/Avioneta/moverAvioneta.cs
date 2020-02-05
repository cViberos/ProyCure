using UnityEngine;

public class moverAvioneta : MonoBehaviour
{
    private int leftbound = 10;
    private float speed;
    
    void Start() {
        speed = 5;
    }

    void Update()
    {
        speed = Random.Range(3f, 7f);
        if (gameObject.CompareTag("Derecha"))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (gameObject.CompareTag("Izquierda"))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (gameObject.CompareTag("Arriba"))
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (gameObject.CompareTag("Abajo"))
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.x > leftbound || transform.position.x < -leftbound)
            Destroy(gameObject);

    }
}