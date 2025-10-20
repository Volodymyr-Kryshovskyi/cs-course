
using UnityEngine;
// в c# выполнение кода идет сверху вниз 

public class script : MonoBehaviour
{
   void Start()  
    {
      Debug.Log("Aim");
      Shot();  // вызывание метода shot 
      Shot();
      Shot();
      Debug.Log("GunDown"); 
    }
    
    
    void Shot() // void - метод
      {
        Debug.Log("Shot"); // метод shot ,сейчас не вызванный 
        Debug.Log("Shot2");
        Debug.Log("Shot3");
      }
  } 

