
using UnityEngine;

public class script : MonoBehaviour
{

   [SerializeField]private string switchName ;
void Start() 
 {
   
    
    // && - u
    // || - или
    // ! - не
    switch (switchName)
    {
        case "Bob":
        {
            Debug.Log("Ваше имя Bob");
            break ; 
        }
        case "Bogdan":
        {
            Debug.Log("Ваше имя Bogdan");
            break;
        }
        case "Vova":
        {
            Debug.Log("Ваше имя Vova");
            break;
        }
        case "Neo":
        {
            Debug.Log("Ваше имя NEO");
            break;
        }
        default:
        {
            Debug.Log("Undefined Name");
            break;
        }
    }
  } 
}
