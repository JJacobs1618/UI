using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomGUI
{
    [CreateAssetMenu(menuName = "CustomUI/ToolbarSO", fileName = "ToolbarSO")]
    public class ToolbarSO : ScriptableObject
    {
        public ThemeSO theme;
        public Sprite toolbarBackgroundImage;
        public List<Sprite> toolbarImages;
    } 
}
