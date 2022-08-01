using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Assets._Nukusi.Scripts.UI
{
    public class Healthbar : MonoBehaviour
    {
        [SerializeField]
        private Vector3 offset;

        private RectTransform rectTransform;
        private Slider slider;

        public RectTransform RectTransform => rectTransform;

        public Vector3 Position
        {
            get { return rectTransform.position; }
            set 
            {
                var pos = Camera.main.WorldToViewportPoint(value + offset);
                rectTransform.position = new Vector3(pos.x * Screen.width, pos.y * Screen.height, 0f); 
            }
        }

        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
            slider = GetComponent<Slider>();
        }

        public void SetValue(float value)
        {
            slider.value = value;
        }

        public class Factory : PlaceholderFactory<Healthbar>
        {

        }
    }
}