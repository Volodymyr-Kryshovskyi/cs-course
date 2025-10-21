
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
// в c# выполнение кода идет сверху вниз 

public class script : MonoBehaviour
{
  void Start()
  {
    string FirstName = "neo";
    string SecondName = "neo2";
    GreetPlayer(FirstName, SecondName);
  }

  
   void GreetPlayer(string FirName,string SecName)
  {

    Debug.Log("Привет, " + FirName + " и " + SecName);
    
   }

   
  } 

