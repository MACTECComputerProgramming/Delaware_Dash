using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionsScript : MonoBehaviour
{

    public GameObject[] Question;

    
  

    void Start()
    {
        Invoke("spawnQuestion", 0);
    }
    
    void spawnQuestion()
    {
        
        int qIndex = Random.Range(0, Question.Length);
        Vector3 spawnPos = new Vector3(0,0,0);
        Instantiate(Question[qIndex], spawnPos, Question[qIndex].transform.rotation);
    }
   
    
    


}
