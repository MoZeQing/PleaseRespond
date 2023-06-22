using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Procedure;
using GameFramework.DataTable;
using GameFramework.Event;
using UnityGameFramework.Runtime;
using GameFramework.Fsm;

namespace GameMain
{
    public class ProcedureMain : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            //GameEntry.UI.OpenUIForm(UIFormId.MainForm, this);
            //GameEntry.UI.OpenUIForm(UIFormId.GameForm, this);

            //// ��ԭ��Ϸ�ٶ�
            //GameEntry.Base.ResetNormalGameSpeed();
            //IDataTable<DRScene> dtScene = GameEntry.DataTable.GetDataTable<DRScene>();
            //DRScene drScene = dtScene.GetDataRow(2);
            ////����������
            //Debug.Log(drScene != null);
            //if (drScene == null)
            //{
            //    Log.Warning("Can not load scene '{0}' from data table.", 2.ToString());
            //    return;
            //}
            //Debug.Log("Start Load Scene");
            //GameEntry.Scene.LoadScene(AssetUtility.GetSceneAsset(drScene.AssetName), /*Constant.AssetPriority.SceneAsset*/0, this);
            ////BgmTask().Coroutine();
            ////GameEntry.Sound.PlaySound(10017);
            //GameEntry.UI.OpenUIForm(UIFormId.GameForm, this);
        }

        protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        }
    }

}