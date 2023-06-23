using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using UnityEngine.UI;
using GameFramework.Event;

namespace GameMain
{
    public class GameForm : UIFormLogic
    {
        [SerializeField] private Text m_ElectricityText = null;
        [SerializeField] private Text m_DormText= null;
        [SerializeField] private Text m_GardenText= null;

        private int m_Electricity = 0;
        private int m_Dorm = 0;
        private int m_Garden = 0;

        private Dictionary<Vector2,BuildingData> m_Maps= new Dictionary<Vector2,BuildingData>();

        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);
            GameEntry.Event.Subscribe(BuildingEventArgs.EventId, BuildingEvent);
        }

        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown, userData);
            GameEntry.Event.Unsubscribe(BuildingEventArgs.EventId, BuildingEvent);
        }

        private void BuildingEvent(object sender, GameEventArgs e)
        {
            Debug.Log("asd1");
            BuildingEventArgs building =(BuildingEventArgs)e;
            if (m_Maps.ContainsKey(building.BuildingPos))
            {
                m_Electricity -= m_Maps[building.BuildingPos].Eletricity;
                m_Dorm -= m_Maps[building.BuildingPos].Dorm;
                m_Garden -= m_Maps[building.BuildingPos].Garden;
            }
            m_Electricity += building.BuildingData.Eletricity;
            m_Dorm += building.BuildingData.Dorm;
            m_Garden += building.BuildingData.Garden;

            m_Maps[building.BuildingPos] = building.BuildingData;

            m_ElectricityText.text = m_Electricity.ToString();
            m_DormText.text = m_Dorm.ToString();
            m_GardenText.text = m_Garden.ToString();
        }
    }
}
