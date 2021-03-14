using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MaxG {
    public class UIController : IInitializer {
        public Transform MainCanvas => _canvas.transform;
        
        private readonly Canvas _canvas;
        private UIConfig _uiConfig;
        

        public UIController(UIConfig uiConfig) {
            _canvas = new GameObject("UICanvas").AddComponent<Canvas>();
            _uiConfig = uiConfig;
        }

        public void Init() {
            _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            var canvasScaler = _canvas.gameObject.AddComponent<CanvasScaler>();
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            canvasScaler.referenceResolution = _uiConfig.ReferenceResolution;
            var graphicRaycaster = _canvas.gameObject.AddComponent<GraphicRaycaster>();

            Button reloadButton = GameObject.Instantiate(_uiConfig.ReloadButton, MainCanvas).GetComponent<Button>();
            reloadButton?.onClick.AddListener(OnReloadButtonClick);
        }

        private void OnReloadButtonClick() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}