using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildMenu : MonoBehaviour
{
    [SerializeField] GameObject buildMenu;//��ȡ����˵�
    [SerializeField] GameObject buildInterface;//��ȡ�������
    [SerializeField] GameObject mainUI;//��ȡ��ҪUI
    [SerializeField] GameObject DestroyInferface;//��ȡ�������
    /// <summary>
    /// �������ģʽ
    /// </summary>
    public void Build()
    {
        buildInterface.SetActive(true);
        buildMenu.SetActive(false);
        mainUI.SetActive(false);
        DestroyInferface.SetActive(false);
    }
    /// <summary>
    /// �˳��˵�
    /// </summary>
    public void Esc()
    {
        buildMenu.SetActive(false);
    }
    /// <summary>
    /// ���ģʽ
    /// </summary>
    public void Destroy()
    {
        DestroyInferface.SetActive(true);
        mainUI.SetActive(false);
        buildMenu.SetActive(false);
        buildInterface.SetActive(false);
    }
    /// <summary>
    /// ��������ģʽ
    /// </summary>
    public void LevelUp()
    {

    }
}
