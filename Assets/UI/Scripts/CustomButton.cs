using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace CustomGUI
{
    public class CustomButton : CustomUIComponent
    {
        public ThemeSO theme;
        public Style style;
        public UnityEvent onClick;

        private Button button;
        private TextMeshProUGUI buttonText;


        public override void Setup()
        {
            button = GetComponentInChildren<Button>();
            buttonText = GetComponentInChildren<TextMeshProUGUI>();
        }

        public override void Configure()
        {
            ColorBlock cb = button.colors;
            cb.normalColor = theme.GetBackgroundColor(style);
            button.colors = cb;

            buttonText.color = theme.GetTextColor(style);
        }

        public void OnClick()
        {
            onClick.Invoke();
        }
    }
}