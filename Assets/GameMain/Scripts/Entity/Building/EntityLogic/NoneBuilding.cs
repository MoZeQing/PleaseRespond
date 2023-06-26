using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using UnityEditor.EventSystems;
using UnityEngine.EventSystems;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using System;
using UnityEngine.Tilemaps;
using GameFramework.DataTable;

namespace GameMain
{
    public class NoneBuilding : BaseBuilding, IPointerDownHandler
    {
        private BuildingData m_BuildingData;
        private CompenentData m_CompenentData;
        private SpriteRenderer m_SpriteRenderer;
        private BoxCollider2D m_Collider2D;

        private int m_Electricity = 0;

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            m_CompenentData = (CompenentData)userData;
            m_BuildingData = m_CompenentData.BuildingData;
            GameEntry.Entity.AttachEntity(this.Entity.Id, m_BuildingData.Id);//回调附加组件
            this.transform.localPosition = Vector3.zero;

            m_SpriteRenderer = this.GetComponent<SpriteRenderer>();
            m_Collider2D = this.GetComponent<BoxCollider2D>();

            m_SpriteRenderer.sprite = GameEntry.Utils.sprites[(int)m_BuildingData.BuildingTag];
            m_Collider2D.size = m_SpriteRenderer.size;
            this.transform.localScale = Vector3.one * 0.16f;
            UpdateBuilding();
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            //弹出升级的按钮
            GameEntry.UI.OpenUIForm(UIFormId.BaseForm, m_BuildingData);
            Debug.Log(1);
        }


        public override void UpdateBuilding()
        {
            base.UpdateBuilding();
            IDataTable<DRBuilding> dtBuilding = GameEntry.DataTable.GetDataTable<DRBuilding>();
            DRBuilding drBuilding = dtBuilding.GetDataRow((int)m_BuildingData.BuildingTag);
            m_BuildingData.Eletricity = drBuilding.Eletricity;
            m_BuildingData.Dorm = drBuilding.Dorm;
            m_BuildingData.Garden = drBuilding.Garden;
            GameEntry.Event.FireNow(this, BuildingEventArgs.Create(m_BuildingData.Pos, m_BuildingData, true));
        }

        //升级组件
        public override void UpgradeBuilding()
        {
            base.UpgradeBuilding();

            UpdateBuilding();
        }

        //降级组件
        public override void DowngradeBuilding()
        {
            base.DowngradeBuilding();
            //UI提醒无法降级或者直接屏蔽降级的按钮
        }
    }
}
