
using UnityEngine;

public class script : MonoBehaviour
{

   
void Start() 
 {
   

   bool tasksdone = false;

   bool roomCleaned = true ; 
    // && - u
    // || - или
    // ! - не


    if (tasksdone && roomCleaned)
      {
        Debug.Log("можно играть в доту");
      }
    
    else
      {
        Debug.Log("сделай задания");
      }

 } 
}
