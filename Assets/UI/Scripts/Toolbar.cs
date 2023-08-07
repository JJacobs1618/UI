using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomGUI
{
    public class Toolbar : CustomUIComponent
    {
        public int numberOfToolbarContainers;
        public ToolbarSO toolbarData;
        public Style style;
        public GameObject toolbarBackgroundContainer;
        public GameObject[] toolbarContainers;
        public List<Style> toolbarStyles;

        private Image toolbarBackgroundImage;
#pragma warning disable CS0649
        private Image[] toolbarImages;
#pragma warning restore CS0649
        private HorizontalLayoutGroup horizontalLayoutGroup;

        public override void Setup()
        {
            horizontalLayoutGroup = GetComponent<HorizontalLayoutGroup>();

            // Set up Arrays
            toolbarContainers = new GameObject[numberOfToolbarContainers];
            toolbarImages = new Image[numberOfToolbarContainers];
            for (int i = 0; i < numberOfToolbarContainers; i++)
            {
                GameObject container = new GameObject("Container");
                RectTransform rect = container.AddComponent<RectTransform>();
                rect.transform.SetParent(container.transform);
                rect.localScale = Vector3.one;
                rect.sizeDelta = toolbarData.preferredSlotSize;

                Image img = container.AddComponent<Image>();
                container.transform.SetParent(this.transform);
                toolbarContainers[i] = container;
                toolbarImages[i] = img;
            }

            //toolbarData.toolbarImages = new Sprite[numberOfToolbarContainers];

            toolbarBackgroundImage = toolbarBackgroundContainer.GetComponent<Image>();

            //for (int i = 0; i < toolbarContainers.Length; i++)
            //    toolbarImages[i] = toolbarContainers[i].GetComponent<Image>();
        }

        public override void Configure()
        {
            horizontalLayoutGroup.padding = toolbarData.padding;
            horizontalLayoutGroup.spacing = toolbarData.spacing;


            toolbarBackgroundImage.color = toolbarData.theme.GetBackgroundColor(style);

        }

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private void OnValidate()
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        {
            while (this.transform.childCount > 1)
                DestroyImmediate(transform.GetChild(1).gameObject);

            base.OnValidate();
        }
    }
}