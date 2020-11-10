using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionsScript : MonoBehaviour
{

    public Rigidbody playerRb;
    public GameObject[] Question;
    private SceneScripts sceneScripts;
    public bool pause = false;

    
    void Update()
    {
        if (pause)  { Time.timeScale = 0; }
        if (!pause) { Time.timeScale = 1; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ice"))
        {
            Invoke("spawnQuestion", 0);
        }

    }
    
    void spawnQuestion()
    {
        pause = true;
        int qIndex = Random.Range(0, Question.Length);
        Vector3 spawnPos = new Vector3(0,0,0);
        Instantiate(Question[qIndex], spawnPos, Question[qIndex].transform.rotation);
    }
   
    public void pauseFalse()
    {
        pause = false;
    }
    


}
