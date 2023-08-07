using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomGUI
{    public abstract class CustomUIComponent : MonoBehaviour
    {
        public float ResetInspector;
        private void Awake()
        {
            Init();
        }

        public abstract void Setup();
        public abstract void Configure();
                
        private void Init()
        {
            Setup();
            Configure();
        }

        protected void OnValidate()
        {
            Init();
        }
    }
}