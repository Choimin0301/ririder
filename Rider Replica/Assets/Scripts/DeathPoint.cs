using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPoint : MonoBehaviour
{
    [SerializeField] GameObject Rider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Line")
        {
            Debug.Log("Die");
            SceneManager.LoadScene("Die");
        }
        
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Rider.transform.position;
        gameObject.transform.rotation = Rider.transform.rotation;
    }
}
