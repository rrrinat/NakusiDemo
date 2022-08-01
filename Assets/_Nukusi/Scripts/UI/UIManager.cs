using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.UI
{
    public class UIManager : MonoBehaviour
    {
        private RectTransform rectTransform;
        public RectTransform RectTransform => rectTransform;

        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
        }
    }
}