using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public class CompenentData : AccessoryObjectData
    {
        public BuildingData BuildingData
        {
            get;
            set;
        }

        public CompenentData(int entityId, int typeId, int ownerId, BuildingData buildingData)
            : base(entityId, typeId, ownerId)
        { 
            BuildingData= buildingData;
        }
    }
}
