using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionsScript : MonoBehaviour
{

    public Rigidbody playerRb;
    public GameObject[] Question;
   

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ice"))
        {
            spawnQuestion();
            Time.timeScale = 0;
        }

    }
    
    void spawnQuestion()
    {
            int qIndex = Random.Range(0, Question.Length);
            Vector3 spawnPos = new Vector3(0,0,0);
            Instantiate(Question[qIndex], spawnPos, Question[qIndex].transform.rotation);
    }
   
    
    


}
