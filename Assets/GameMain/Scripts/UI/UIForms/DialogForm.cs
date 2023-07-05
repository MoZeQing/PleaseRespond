using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using XNode;

namespace GameMain
{
    public class DialogForm : UIFormLogic
    {
        public Text nameText;
        public Text dialogText;

        public Button autoBtn;
        public Button quickBtn;
        public Button memoryBtn;
        public Button dialogBtn;

        public Image image;

        public GameObject BtnPrefab;

        public Transform eventCanvas;
        public Transform dialog;

        public float playTime;

        private int _index;

        private DialogueGraph m_Dialogue = null;
        private StartNode m_StartNode = null;
        private ChatTag chatTag;
        private Node m_Node = null;
        private List<GameObject> m_Btns = new List<GameObject>();
        private bool hasQuestion = false;
        // Start is called before the first frame update
        void Start()
        {
            dialogBtn.onClick.AddListener(Next);
        }

        // Update is called once per frame
        public void FixedUpdate()
        {
            //以固定频率快进
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            {
                Next();
            }
        }
        //不要靠近协程，会变得不幸
        public IEnumerator PlayWord(string word)
        {
            dialogText.text = null;
            for (int i = 0; i < word.Length; i++)
            {
                dialogText.text += word[i];
                yield return new WaitForSeconds(playTime);
            }
        }
        public void ClearButtons()
        {
            hasQuestion = false;
            foreach (GameObject go in m_Btns)
            {
                Destroy(go);
            }
            m_Btns.Clear();
        }
        public void Next()
        {
            switch (chatTag)
            { 
                case ChatTag.None:
                    ChatNode chatNode = (ChatNode)m_Node;
                    Play(chatNode);
                    break;
                case ChatTag.Option:
                    OptionNode optionNode = (OptionNode)m_Node;

                    break;
            }
        }
        public void Play(ChatNode chatNode)
        {
            ChatData chatData = chatNode.chatDatas[_index];
            nameText.text = chatData.charName;
            dialogText.text = chatData.text;
            _index++;
        }
        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);

            DialogueGraph data = (DialogueGraph)userData;
            _index = 0;
            m_Dialogue=data;
            Next();
        }
        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown, userData);
        }
    }
}
