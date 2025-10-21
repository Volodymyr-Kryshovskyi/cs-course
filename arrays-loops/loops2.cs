
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class script : MonoBehaviour
{

  private int number;
  private void Start()
  {
    Debug.Log("Start");
    while (number < 5)
    {
      
      number++;
      Debug.Log("Молодец твои очки :" + number);
    }
     Debug.Log("Finish");
  }

  


   
} 

