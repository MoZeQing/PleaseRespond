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

        private void InitCompenent()
        {
            CompenentData compenentData = new CompenentData(GameEntry.Entity.GenerateSerialId(), 10001, Id, Data);
            //工厂模式
            switch (Data.BuilingTag)
            {
                case BuilingTag.None:

                    break;
                case BuilingTag.Training1:
                case BuilingTag.Training2:
                case BuilingTag.Training3:
                    break;
                case BuilingTag.Workbench1:
                case BuilingTag.Workbench2:
                case BuilingTag.Workbench3:
                    break;
                case BuilingTag.Elevator1:
                case BuilingTag.Elevator2:
                    break;
                case BuilingTag.Garden1:
                case BuilingTag.Garden2:
                case BuilingTag.Garden3:
                    break;
                case BuilingTag.Dorm1:
                case BuilingTag.Dorm2:
                    break;
                case BuilingTag.Electricity1:
                case BuilingTag.Electricity2:
                case BuilingTag.Electricity3:
                    GameEntry.Entity.ShowElectricity(compenentData);
                    break;
            }
        }
    }
}

