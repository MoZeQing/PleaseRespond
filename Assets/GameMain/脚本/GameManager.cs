using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int m_partNum=0;//零件数量
    public int coreNum=0;//能源核心
    public int foodNum=0;//食物资源
    public int power = 0;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int ChangePart
    {
        get
        {
            return m_partNum;
        }
        set
        {
            m_partNum += value;
            if (m_partNum <= 0)
            {
                m_partNum = 0;
            }
        }
    }

    public void ChangeCoreNum(int changeNum)
    {
        coreNum += changeNum;
        if (coreNum <= 0)
        {
            coreNum = 0;
        }
    }
    public void ChangeFood(int changeNum)
    {
        foodNum += changeNum;
        if (foodNum <= 0)
        {
            foodNum = 0;
        }
    }
    public void ChangePower(int changeNum)
    {
        power += changeNum;
        if (power <= 0)
        {
            power = 0;
        }
    }
}
