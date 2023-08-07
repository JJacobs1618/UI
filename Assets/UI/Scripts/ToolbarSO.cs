using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomGUI
{
    [CreateAssetMenu(menuName = "CustomUI/ToolbarSO", fileName = "ToolbarSO")]
    public class ToolbarSO : ScriptableObject
    {
        [Tooltip("Padding around Toolbar")] public RectOffset padding;
        [Tooltip("Spacing between Toolbar Slots")] public float spacing;
        [Tooltip("Preferred Size of Toolbar Slot H/W")] public Vector2 preferredSlotSize;
        public ThemeSO theme;
        public Sprite toolbarBackgroundImage;
        public Sprite[] toolbarImages;
    } 
}
