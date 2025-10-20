
using UnityEngine;

public class script : MonoBehaviour
{
   private int _myage = 5 ,  _myheight = 180;
   private string _myname = "stas";
   private float _hpmax = 95.021f, _hpmin = 0f;
   private float _nowhp = 30.5f; 
   private bool _ask = 9>2 ; 
   private int _procent = 100; 
   
   

    void Start()

    
    {  
    Debug.Log(_ask);
    Debug.Log("My age is " + _myage + " and my height is " + _myheight + "cm and my name is " + _myname );
    Debug.Log("Max hp hero is " + _hpmax + " and min hp is " + _hpmin );
    Debug.Log("Now hp hero is " + _nowhp ) ;
    Debug.Log("Procent is " + _procent + "%"); 
    Debug.Log("Resut is " + (_ask && _procent > 50));
    }
 
}
