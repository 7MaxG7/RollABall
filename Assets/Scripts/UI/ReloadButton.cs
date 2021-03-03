using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class ReloadButton : MonoBehaviour {
    private Button _reloadBtn;

    private void Awake() {
        _reloadBtn = GetComponent<Button>();
        _reloadBtn.onClick.AddListener(ReloadLevel);
    }

    public void ReloadLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
