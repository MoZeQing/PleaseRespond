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


        public static int GenerateSerialId(this EntityComponent entityComponent)
        {
            return --s_SerialId;
        }
    }
}


