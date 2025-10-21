
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class script : MonoBehaviour
{

  //private int number;
  [SerializeField] float[] numberArray = { 50.50f, 20.20f, 40.23f, 60.79f, 20.23f , 49.001f }; // float or int
  private void Start()
  {
    for (int i = 0; i <= numberArray.Length - 2; i++)
    {
      Debug.Log(numberArray[i].ToString("F2"));
    }



    foreach (var numberr in numberArray)
    {
      Debug.Log(numberr);
    }
  }

    
    

   
   
  //   Debug.Log("Start");
  //   while (number < 5)
  //   {
      
  //     number++;
  //     Debug.Log("Молодец твои очки :" + number);
  //   }
  //    Debug.Log("Finish");
}

  


   


