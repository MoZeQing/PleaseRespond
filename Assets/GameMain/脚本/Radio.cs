using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    [SerializeField] private GameObject buildMenu;//��ȡ����˵�
    /// <summary>
    /// ��굥�����ü���˵�
    /// </summary>
    private void OnMouseDown()
    {
        buildMenu.SetActive(true);
    }
}

