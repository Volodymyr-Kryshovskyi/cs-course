
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
// в c# выполнение кода идет сверху вниз 

public class script : MonoBehaviour
{

  [SerializeField] private List<int> listnumbers = new List<int>();
  void Start()
  {
    listnumbers.Add(5);
    listnumbers.Add(6);
    listnumbers.Add(7); 
    Debug.Log(listnumbers.Count);
    listnumbers.RemoveAt(1); //  removeAt - удалить один выбранный елемент ,Remove - удалить первый елемент(тоесть 0) , RemoveAll - удалить все
    listnumbers.Insert(2, 100); // - добавить елемент в начало
  }

  


   
} 

