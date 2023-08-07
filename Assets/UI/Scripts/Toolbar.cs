using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomGUI
{
    public class Toolbar : CustomUIComponent
    {
        public ToolbarSO toolbarData;
        public Style style;
        public GameObject toolbarBackgroundContainer;
        public List<GameObject> toolbarContainers;
        public List<Style> toolbarStyles;

        private Image toolbarBackgroundImage;
#pragma warning disable CS0649
        private List<Image> toolbarImages;

        public override void Setup()
        {
            toolbarBackgroundImage = toolbarBackgroundContainer.GetComponent<Image>();
            toolbarImages = new List<Image>();
            toolbarImages.Clear();
            for (int i = 0; i < toolbarContainers.Count; i++)
            {
                Image containerImageRef = toolbarContainers[i].GetComponent<Image>();
                toolbarImages.Add(containerImageRef);
            }
        }

        public override void Configure()
        {
            toolbarBackgroundImage.color = toolbarData.theme.GetBackgroundColor(style);
            for (int i = 0; i < toolbarContainers.Count; i++)
            {
                toolbarImages[i].color = toolbarData.theme.GetBackgroundColor(toolbarStyles[i]);
                if (toolbarData.toolbarImages.Count > 0)
                {
                    toolbarImages[i].sprite = toolbarData.toolbarImages[i];
                }
            }
        }
    }

}