using GameFramework.DataTable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public class Building : Entity
    {
        public BuildingData BuildingData;
        public CompenentData CompenentData;


        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            BuildingData = (BuildingData)userData;

            this.transform.position= Vector3.zero;

            InitCompenent();
        }

        public void ChangeBuilding(BuildingTag buildingTag)
        {
            if (BuildingData.BuildingTag != BuildingTag.Empty)
                this.transform.GetChild(0).GetComponent<BaseBuilding>().DowngradeBuilding();
            GameEntry.Entity.DetachChildEntities(this.Id);
            GameEntry.Entity.HideEntity(CompenentData.Id);

            BuildingData.BuildingTag = buildingTag;
            Debug.Log(1);
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
            CompenentData compenentData = new CompenentData(GameEntry.Entity.GenerateSerialId(), 10001, Id, BuildingData);
            //工厂模式
            switch (BuildingData.BuildingTag)
            {
                case BuildingTag.Empty:
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
                case BuildingTag.Elevator:
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

