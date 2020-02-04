using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class AvionSpawn : MonoBehaviour
{

    public GameObject[] avionetas;

    private Vector2 RandomPos;
    private bool spawn = true;

    // Procedimiento que se actualiza por cada frame
    void Update() {
        int position = Random.Range(0, 2);

        //Modificado por Chuku
        if (spawn == true && (position == 0 || position == 1)) {
            if (position == 0) {
                spawn = false;
                RandomPos.x = 9.5f;
            }
            else {
                spawn = false;
                RandomPos.x = -6.3f;
            }
            RandomPos.y = Random.Range(-7.5f, -0.43f);
            Instantiate(avionetas[position], new Vector3(RandomPos.x, RandomPos.y, -0.6f), transform.rotation);
            StartCoroutine("Wait");
        }
    }

    private void StartDelay() {
        spawn = true;
    }

    IEnumerator Wait() {
        yield return new WaitForSecondsRealtime(5.0f);
        StartDelay();
    }
} 