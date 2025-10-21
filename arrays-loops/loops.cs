
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class script : MonoBehaviour
{

  private int number;
  private IEnumerator Start()
  {
    Debug.Log("Start");
    while (true)
    {
      yield return new WaitForSeconds(1);
      number++;
      Debug.Log("Молодец твои очки :" + number);
    }
    // Debug.Log("Finish");
  }

  


   
} 

