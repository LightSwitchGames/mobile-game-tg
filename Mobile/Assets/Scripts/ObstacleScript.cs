using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Finish"))
        {
            Debug.Log("work god fucking dammit");
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine("GameOverSequence");
        }
       
    }

    IEnumerator GameOverSequence()
    {
        Debug.Log("Dead");
        yield return new WaitForSeconds(5);
        Debug.Log("GameOverScreen");
    }
}
