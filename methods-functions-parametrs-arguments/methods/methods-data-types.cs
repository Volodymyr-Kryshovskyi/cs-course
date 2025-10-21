
using UnityEngine;
// в c# выполнение кода идет сверху вниз 

public class script : MonoBehaviour
{
   void Start()  
    {
    Debug.Log(NumberofPts());
    }

  int NumberofPts() //    метод возвращаемый и мы можем его присвоить так и данные как и ссылки
  {      // названием переменной могут быть любой тип данных например: float , bool , string , decimal  и тд.
    int currentPts = 2300;   // и чтобы код работал ему нужно присвоить значение иначе код не будет работать
    int newPts = 6500;
    Debug.Log("You have won a lot of games");
    return currentPts + newPts;
  }
    

     script FirstScript() // ссылочный метод чтобы вернуть ссылку
    {
    return this;      
    }

  } 

