using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RNG : MonoBehaviour
{
    public int randomNumber;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(1, 3);
        //Debug.Log("Random Number: " + randomNumber);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            randomNumber = Random.Range(1, 3);
            Debug.Log("Random Number: " + randomNumber);
        }
        if (other.gameObject.CompareTag("Player") && randomNumber == 1)
        {
            SceneManager.LoadScene("Loser");
        }
        else if (other.gameObject.CompareTag("Player") && randomNumber == 2)
        {
            SceneManager.LoadScene("Winner");
        }
    }
}
