using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private ObstacleSpawner obstSpawner;
    private GameObject player;
    
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Player")
        {
            player = other.gameObject;
            StartCoroutine("GameOverSequence");
        }
       
    }

    IEnumerator GameOverSequence()
    {
        Debug.Log("Dead");
        Destroy(player);
        obstSpawner.enabled = false;
        yield return new WaitForSeconds(5);
        Debug.Log("GameOverScreen");
    }
}
