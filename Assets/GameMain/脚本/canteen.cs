using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canteen : MonoBehaviour
{
    private void Start()
    {
        ProvideFood();
    }
    /// <summary>
    ///�ṩʳ�� 
    /// </summary>
    public void ProvideFood()
    {
        GameManager.instance.ChangeFood(2);
    }
}
