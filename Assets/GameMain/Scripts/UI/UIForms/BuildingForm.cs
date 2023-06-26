using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using UnityEngine.UI;
using GameFramework.Event;
using GameFramework.DataTable;

namespace GameMain
{
    public class BuildingForm : UIFormLogic
    {
        [SerializeField] private Text m_TitleText = null;
        [SerializeField] private Text m_ProdureText = null;
        [SerializeField] private Text m_DescriptionText = null;
        [SerializeField] private Button m_BuildingBtn = null;
        [SerializeField] private Transform m_Content = null;

        private BuildingData m_BuildingData = null;
        private BuildingTag[] m_BuildingTags = new BuildingTag[]
        {
            BuildingTag.None,
            BuildingTag.Electricity1,
            BuildingTag.Training1,
            BuildingTag.Dorm1,
            BuildingTag.Garden1,
            BuildingTag.Workbench1,
        };

        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);

            foreach (BuildingTag buildingTag in m_BuildingTags)
            {
                GameObject go = new GameObject();
                go.name = buildingTag.ToString();
                go.transform.parent = m_Content.transform;
                go.AddComponent<Image>();
                //go.GetComponent<SpriteRenderer>().sprite = GameEntry.Utils.sprites[(int)buildingTag];
                go.AddComponent<BuildingItem>();
                go.AddComponent<Button>();
                go.GetComponent<BuildingItem>().OnInit(this, buildingTag);
            }

            m_BuildingBtn.onClick.AddListener(Building_OnClick);
        }

        public void SetBuilding(object sender)
        {
            BuildingTag buildingTag = (BuildingTag)sender;

            IDataTable<DRBuilding> dtBuilding = GameEntry.DataTable.GetDataTable<DRBuilding>();
            DRBuilding drBuilding = dtBuilding.GetDataRow((int)buildingTag);

            m_TitleText.text = drBuilding.Title.ToString();
            m_ProdureText.text = drBuilding.Produre.ToString();
            m_DescriptionText.text = drBuilding.Description.ToString();
        }

        private void Building_OnClick()
        { 
            
        }

        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown, userData);
        }
    }
}

