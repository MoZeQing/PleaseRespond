using GameFramework.DataTable;
using GameFramework.Entity;
using System;
using TreeEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine.Tilemaps;
using UnityGameFramework.Runtime;

namespace GameMain
{
    public static class EntityExtension
    {
        // ���� EntityId ��Լ����
        // 0 Ϊ��Ч
        // ��ֵ���ںͷ�����ͨ�ŵ�ʵ�壨����ҽ�ɫ��NPC���ֵȣ�������ֻ������ֵ��
        // ��ֵ���ڱ������ɵ���ʱʵ�壨����Ч��FakeObject�ȣ�
        private static int s_SerialId = 0;

        public static void ShowBuilding(this EntityComponent entityComponent, BuildingData data)
        {
            entityComponent.ShowEntity(typeof(Building), "Building", 90, data);
        }
        public static void ShowElectricity(this EntityComponent entityComponent, CompenentData data)
        {
            entityComponent.ShowEntity(typeof(ElectricityBuilding), "Building", 90, data);
        }

        public static void ShowNone(this EntityComponent entityComponent, CompenentData data)
        {
            entityComponent.ShowEntity(typeof(ElectricityBuilding), "Building", 90, data);
        }

        private static void ShowEntity(this EntityComponent entityComponent, Type logicType, string entityGroup, int priority, EntityData data)
        {
            if (data == null)
            {
                Log.Warning("Data is invalid.");
                return;
            }

            IDataTable<DREntity> dtEntity = GameEntry.DataTable.GetDataTable<DREntity>();
            DREntity drEntity = dtEntity.GetDataRow(data.TypeId);
            if (drEntity == null)
            {
                Log.Warning("Can not load entity id '{0}' from data table.", data.TypeId.ToString());
                return;
            }

            entityComponent.ShowEntity(data.Id, logicType, AssetUtility.GetEntityAsset(drEntity.AssetName), entityGroup, priority, data);
        }

        public static int GenerateSerialId(this EntityComponent entityComponent)
        {
            return --s_SerialId;
        }
    }
}


