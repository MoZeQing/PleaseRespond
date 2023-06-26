using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public class Building : Entity
    {
        public BuildingData Data;


        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            Data = (BuildingData)userData;

            this.transform.position= Vector3.zero;

            InitCompenent();
        }

        public void UpgradeBuilding()
        { 
            this.transform.GetChild(0).GetComponent<BaseBuilding>().UpdateBuilding();
        }

        public void DowngradeBuilding()
        { 
            this.transform.GetChild(0).GetComponent<BaseBuilding>().DowngradeBuilding();
        }

        private void InitCompenent()
        {
            CompenentData compenentData = new CompenentData(GameEntry.Entity.GenerateSerialId(), 10001, Id, Data);
            //工厂模式
            switch (Data.BuildingTag)
            {
                case BuildingTag.None:
                    GameEntry.Entity.ShowNone(compenentData);
                    break;
                case BuildingTag.Training1:
                case BuildingTag.Training2:
                case BuildingTag.Training3:
                    break;
                case BuildingTag.Workbench1:
                case BuildingTag.Workbench2:
                case BuildingTag.Workbench3:
                    break;
                case BuildingTag.Elevator1:
                case BuildingTag.Elevator2:
                    break;
                case BuildingTag.Garden1:
                case BuildingTag.Garden2:
                case BuildingTag.Garden3:
                    break;
                case BuildingTag.Dorm1:
                case BuildingTag.Dorm2:
                    break;
                case BuildingTag.Electricity1:
                case BuildingTag.Electricity2:
                case BuildingTag.Electricity3:
                    GameEntry.Entity.ShowElectricity(compenentData);
                    break;
            }
        }
    }
}

