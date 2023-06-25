using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public class BuildingPlotDebugger : MonoBehaviour
    {
        void Start()
        {
            GameEntry.Utils.buildingPos.Add(new Vector2(0, 0), this.transform.GetChild(0).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(0, 1), this.transform.GetChild(1).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(0, 2), this.transform.GetChild(2).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(0, 3), this.transform.GetChild(3).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(1, 0), this.transform.GetChild(4).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(1, 1), this.transform.GetChild(5).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(1, 2), this.transform.GetChild(6).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(1, 3), this.transform.GetChild(7).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(2, 0), this.transform.GetChild(8).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(2, 1), this.transform.GetChild(9).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(2, 2), this.transform.GetChild(10).transform.position);
            GameEntry.Utils.buildingPos.Add(new Vector2(2, 3), this.transform.GetChild(11).transform.position);

            GameEntry.Entity.ShowBuilding(new BuildingData(GameEntry.Entity.GenerateSerialId(), 10000, BuilingTag.Electricity1, new Vector2(0, 0))
            {
                Position = GameEntry.Utils.buildingPos[new Vector2(0, 0)]
            });
        }
    }
}
