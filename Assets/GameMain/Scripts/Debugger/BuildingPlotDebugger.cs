using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public class BuildingPlotDebugger : MonoBehaviour
    {
        
        void Start()
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                GameEntry.Utils.buildingPos.Add(this.transform.GetChild(i).transform.position);
                Destroy(this.transform.GetChild(i).gameObject);
            }
            foreach (Vector3 pos in GameEntry.Utils.buildingPos)
            {
                GameEntry.Entity.ShowBuilding(new BuildingData(GameEntry.Entity.GenerateSerialId(), 10000, BuildingTag.Empty, new Vector2(0, 0))
                {
                    Position = pos
                });
            }
        }
    }
}
