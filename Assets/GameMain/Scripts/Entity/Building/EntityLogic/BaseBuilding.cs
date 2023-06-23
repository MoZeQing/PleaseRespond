using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace GameMain
{
    public class BaseBuilding : EntityLogic
    {
        public virtual void UpgradeBuilding()
        {
            
        }

        public virtual void DowngradeBuilding() { }

        public virtual void UpdateBuilding() { }
    }
}