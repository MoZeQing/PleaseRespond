using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using Random = UnityEngine.Random;

namespace GameMain
{
    public class UtilsComponent : GameFrameworkComponent
    {
        public Dictionary<Vector2,Vector3> buildingPos= new Dictionary<Vector2,Vector3>();
        public Dictionary<Vector2,GameObject> buildings= new Dictionary<Vector2,GameObject>();
        public Sprite[] sprites = null;//�ڵ����ͼ
        public int buildingSlot = 0;//������λ
        public int eletricitySlot = 0;//������λ
        public int peopleSlot = 0;//�˿ڲ�λ
    }
}