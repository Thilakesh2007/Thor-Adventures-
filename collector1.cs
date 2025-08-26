using System.Collections.Generic;  
using UnityEngine;
using UnityEngine.UI;

public class Collector1 : MonoBehaviour
{
    [SerializeField] private Text countText;  
    private int countFruit = 0;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fruit")  
        {
            countFruit++;  
            countText.text = "Fruit: " + countFruit; 
            Destroy(other.gameObject);  
        }
    }
}
